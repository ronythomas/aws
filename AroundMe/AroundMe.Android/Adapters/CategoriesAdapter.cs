using Android.App;
using Android.Views;
using Android.Widget;
using AroundMe.Android.Views;
using AroundMe.Service.Models;
using AroundMe.Service.ViewModels;

namespace AroundMe.Android.Adapters
{
    public class ExpenseWrapper : Java.Lang.Object
    {
        public TextView CategoryName { get; set; }
    }

    public class CategoriesAdapter : BaseAdapter<Category>
    {
        private CategoriesViewModel viewModel;
        private Activity context;

        public CategoriesAdapter(Activity context, CategoriesViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.context = context;
        }

        public override long GetItemId(int position)
        {
            return viewModel.Categories[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ExpenseWrapper wrapper = null;
            var view = convertView;
            if (convertView == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.CategoryItem, null);
                wrapper = new ExpenseWrapper {CategoryName = view.FindViewById<TextView>(Resource.Id.categoryName)};
                view.Tag = wrapper;
            }
            else
            {
                wrapper = convertView.Tag as ExpenseWrapper;
            }

            var category = viewModel.Categories[position];
            wrapper.CategoryName.Text = category.DisplayName;

            return view;
        }

        public override int Count
        {
            get { return viewModel.Categories.Count; }
        }

        public override Category this[int position]
        {
            get { return viewModel.Categories[position]; }
        }
    }
}