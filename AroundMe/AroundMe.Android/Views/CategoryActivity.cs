﻿using Android.App;

namespace AroundMe.Android.Views
{
    [Activity(Label = "New Expense", Icon = "@drawable/icon")]
    public class CategoryActivity : Activity
    {
//        private ExpenseViewModel viewModel;
//        private EditText notes, name, total;
//        private DatePicker date;
//        private CheckBox billable;
//        private Spinner category;
//        private IMessageDialog dialog;
//        protected async override void OnCreate(Bundle bundle)
//        {
//            base.OnCreate(bundle);
//
//            SetContentView(Resource.Layout.view_expense);
//
//            dialog = ServiceContainer.Resolve<IMessageDialog>();
//
//            var id = Intent.GetIntExtra("ID", -1);
//            viewModel = ServiceContainer.Resolve<ExpenseViewModel>();
//            await viewModel.Init(id);
//
//            this.ActionBar.Title = viewModel.Title;
//            viewModel.IsBusyChanged = (busy) =>
//            {
//                if (busy)
//                    AndHUD.Shared.Show(this, "Loading...");
//                else
//                    AndHUD.Shared.Dismiss(this);
//            };
//
//            name = FindViewById<EditText>(Resource.Id.name);
//            date = FindViewById<DatePicker>(Resource.Id.date);
//            notes = FindViewById<EditText>(Resource.Id.notes);
//            total = FindViewById<EditText>(Resource.Id.total);
//            billable = FindViewById<CheckBox>(Resource.Id.billable);
//            category = FindViewById<Spinner>(Resource.Id.category);
//            category.Adapter = new ArrayAdapter<string>(this, global::Android.Resource.Layout.SimpleSpinnerDropDownItem, viewModel.Categories);
//            category.SetSelection(viewModel.Categories.IndexOf(viewModel.Category));
//            name.Text = viewModel.Name;
//            date.DateTime = viewModel.Due;
//            notes.Text = viewModel.Notes;
//            total.Text = viewModel.Total;
//            billable.Checked = viewModel.Billable;
//        }
//
//        protected override void OnStart()
//        {
//            base.OnStart();
//            MyExpensesApplication.CurrentActivity = this;
//        }
//
//        public override bool OnCreateOptionsMenu(IMenu menu)
//        {
//            MenuInflater.Inflate(Resource.Menu.menu_expense, menu);
//            return base.OnCreateOptionsMenu(menu);
//        }
//
//        public override bool OnOptionsItemSelected(IMenuItem item)
//        {
//            switch (item.ItemId)
//            {
//                case (Resource.Id.menu_save_expense):
//                    viewModel.Name = name.Text;
//                    viewModel.Billable = billable.Checked;
//                    viewModel.Due = date.DateTime;
//                    viewModel.Notes = notes.Text;
//                    viewModel.Total = total.Text;
//                    viewModel.Category = viewModel.Categories[category.SelectedItemPosition];
//                    Task.Run(async () =>
//                    {
//                        await viewModel.ExecuteSaveExpenseCommand();
//
//                        if (!viewModel.CanNavigate)
//                            return;
//
//                        Finish();
//                    });
//                    return true;
//            }
//            return base.OnOptionsItemSelected(item);
//        }
    }
}