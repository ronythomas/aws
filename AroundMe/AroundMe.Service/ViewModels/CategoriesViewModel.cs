using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using AroundMe.Service.Models;

namespace AroundMe.Service.ViewModels
{
    public class CategoriesViewModel : ViewModelBase
    {
        private ILocationService locationService;

        public bool NeedsUpdate { get; set; }

        private ObservableCollection<Category> categories = new ObservableCollection<Category>();

        public ObservableCollection<Category> Categories
        {
            get { return categories; }
            set { categories = value; OnPropertyChanged("Categories"); }
        }

        public CategoriesViewModel()
        {
            locationService = new LocationService();
            NeedsUpdate = true;
        }

        public async Task ExecuteLoadCategoriesCommandAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            await UpdateCategoriesAsync();
        }

        private async Task UpdateCategoriesAsync()
        {
            Categories.Clear();
            
            try
            {
                var categories = await locationService.GetCategoriesAsync();

                foreach (var category in categories)
                {
                    Categories.Add(category);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Unable to query and gather categories");
            }
            finally
            {
                IsBusy = false;
                NeedsUpdate = false;
            }
        }
    }
}