using System.Collections.Generic;
using System.Threading.Tasks;
using AroundMe.Service.Models;

namespace AroundMe.Service
{
    public interface ILocationService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }

    public class LocationService : ILocationService
    {
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await  Task.Factory.StartNew(() => new List<Category>
            {
                new Category { Id = 1, Term = "airport", DisplayName = CategoriesConstants.Airports, Image = "Airport.png"},
                new Category { Id = 2, Term = "atm", DisplayName = CategoriesConstants.ATM, Image = "ATM.png"},
                new Category { Id = 3, Term = "bank", DisplayName = CategoriesConstants.Banks, Image = "Bank.png"},
                new Category { Id = 4, Term = "bar", DisplayName = CategoriesConstants.Bars, Image = "Bars.jpg"},
                new Category { Id = 5, Term = "bus_station", DisplayName = CategoriesConstants.BusStations, Image = "Bus.jpg"},
                new Category { Id = 6, Term = "movie_theater", DisplayName = CategoriesConstants.Cinema, Image = "Theater.png"},
                new Category { Id = 7, Term = "cafe", DisplayName = CategoriesConstants.Coffee, Image = "Coffee.png"},
                new Category { Id = 8, Term = "gas_station", DisplayName = CategoriesConstants.GasStations, Image = "Gas.png"},
                new Category { Id = 9, Term = "grocery_or_supermarket", DisplayName = CategoriesConstants.Grocery, Image = "Grocery.jpg"},
                new Category { Id = 10, Term = "hospital", DisplayName = CategoriesConstants.Hospitals, Image = "Hospital.png"},
                new Category { Id = 11, Term = "lodging", DisplayName = CategoriesConstants.Hotels, Image = "Hotel.jpg"},
                new Category { Id = 12, Term = "library", DisplayName = CategoriesConstants.Library, Image = "Library.png"},
                new Category { Id = 13, Term = "parking", DisplayName = CategoriesConstants.Parking, Image = "Parking.png"},
                new Category { Id = 14, Term = "car_rental", DisplayName = CategoriesConstants.RentalCars, Image = "RentalCar.png"},
                new Category { Id = 15, Term = "restaurant", DisplayName = CategoriesConstants.Restaurants, Image = "Restraunt.jpg"},
                new Category { Id = 16, Term = "train_station", DisplayName = CategoriesConstants.TrainStation, Image = "TrainStation.jpg"}
            });
        }
    }

    public static class CategoriesConstants
    {
        public static string All = "All";
        public static string Airports = "Airports";
        public static string ATM = "ATM";
        public static string Banks = "Banks";
        public static string Bars = "Bars";
        public static string BusStations = "Bus Stations";
        public static string Cinema = "Cinema";
        public static string Coffee = "Coffee";
        public static string GasStations = "Gas Stations";
        public static string Grocery = "Grocery / Supermarket";
        public static string Hospitals = "Hospitals";
        public static string Hotels = "Hotels";
        public static string Library = "Library";
        public static string Parking = "Parking";
        public static string RentalCars = "Rental Cars";
        public static string Restaurants = "Restaurants";
        public static string TrainStation = "Train Station";
        public static string Pizza = "Pizza";
        public static string Mexican = "Mexican";
        public static string Indian = "Indian";
    }
}