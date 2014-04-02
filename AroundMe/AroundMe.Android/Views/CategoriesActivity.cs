using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using AroundMe.Android.Adapters;
using AroundMe.Service.ViewModels;

namespace AroundMe.Android.Views
{
    [Activity(Label = "AroundMe.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class CategoriesActivity : ListActivity
    {
        private CategoriesViewModel viewModel;
        private ProgressBar progressBar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Categories);

            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);

            viewModel = new CategoriesViewModel();

            viewModel.IsBusyChanged = (busy) =>
            {
                progressBar.Visibility = busy ? ViewStates.Visible : ViewStates.Gone;
            };

            ListAdapter = new CategoriesAdapter(this, viewModel);
        }

        protected async override void OnStart()
        {
            base.OnStart();

            AroundMeApplication.CurrentActivity = this;

            if (viewModel.NeedsUpdate)
            {
                await viewModel.ExecuteLoadCategoriesCommandAsync();
                RunOnUiThread(() => ((CategoriesAdapter)ListAdapter).NotifyDataSetChanged());
            }
        }
    }
}

