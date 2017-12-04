using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Data;
using Linq.Data.Interfaces;
using Linq.Model;
using Linq.Samples.Interfaces;

namespace Linq.Samples
{
    public class MethodSamples : ISamples
    {
        private IDataProvider _dataProvider;

        public MethodSamples()
        {
            _dataProvider = new DataProvider();
        }

        public IEnumerable<Animal> GetAnimalsByClass(string @class)
        {
            return _dataProvider.Animals.Where(x=>x.Class.Equals(@class));
        }

        public IEnumerable<Animal> GetAnimalsWithPopulationLessThan(int population)
        {
            return _dataProvider.Animals.Where(x=>x.Population<population);
        }

        public IEnumerable<Item> GetItemsByCategory(string category)
        {
            return _dataProvider.Items.Where(x=>x.Category.Equals(category));
        }

        public IEnumerable<Item> GetItemsWithExpirationDateInLessThan(int days)
        {
            return _dataProvider.Items.Where(x=>x.ExpirationDate.Day<DateTime.Now.AddDays(days).Day);
        }

        public IEnumerable<Item> GetItemsWithPriceBetween(decimal lowerPrice, decimal higherPrice)
        {
            return _dataProvider.Items.Where(x=>x.Price>lowerPrice).Where(x=>x.Price<higherPrice);
        }

        public IEnumerable<Item> GetItemsWithPriceLessThan(decimal price)
        {
            return _dataProvider.Items.Where(x=>x.Price<price);
        }

        public IEnumerable<Item> GetItemsWithPriceMoreThan(decimal price)
        {
            return _dataProvider.Items.Where(x=>x.Price>price);
        }

        public IEnumerable<Person> GetPeopleBornIn(string city)
        {
            return _dataProvider.People.Where(x=>x.BirthPlace.Equals(city));
        }

        public IEnumerable<Person> GetPeopleOrderedByirthDate()
        {
            return _dataProvider.People.OrderBy(x=>x.BirthDate);
        }

        public IEnumerable<Person> GetPeopleWithGender(string gender)
        {
            return _dataProvider.People.Where(x=>x.Gender.Equals(gender));
        }
    }
}