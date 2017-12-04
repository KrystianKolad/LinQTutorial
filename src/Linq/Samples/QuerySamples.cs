using System.Collections.Generic;
using Linq.Data;
using Linq.Data.Interfaces;
using Linq.Model;
using Linq.Samples.Interfaces;
using System.Linq;
using System;

namespace Linq.Samples
{
    public class QuerySamples : ISamples
    {
        private IDataProvider _dataProvider;

        public QuerySamples()
        {
            _dataProvider = new DataProvider();
        }

        public IEnumerable<Animal> GetAnimalsByClass(string @class)
        {
            return from a in _dataProvider.Animals
                   where a.Class.Equals(@class)
                   select a;
        }

        public IEnumerable<Animal> GetAnimalsWithPopulationLessThan(int population)
        {
            return from a in _dataProvider.Animals
                   where a.Population<population
                   select a;
        }

        public IEnumerable<Item> GetItemsByCategory(string category)
        {
            return from item in _dataProvider.Items
                   where item.Category.Equals(category)
                   select item;
        }

        public IEnumerable<Item> GetItemsWithExpirationDateInLessThan(int days)
        {
            return from item in _dataProvider.Items
                   where item.ExpirationDate.Day<DateTime.Now.AddDays(days).Day
                   select item;
        }

        public IEnumerable<Item> GetItemsWithPriceBetween(decimal lowerPrice, decimal higherPrice)
        {
            return from item in _dataProvider.Items
                   where item.Price>lowerPrice
                   where item.Price<higherPrice
                   select item;
        }

        public IEnumerable<Item> GetItemsWithPriceLessThan(decimal price)
        {
            return from item in _dataProvider.Items
                   where item.Price<price
                   select item;
        }

        public IEnumerable<Item> GetItemsWithPriceMoreThan(decimal price)
        {
            return from item in _dataProvider.Items
                   where item.Price>price
                   select item;
        }

        public IEnumerable<Person> GetPeopleBornIn(string city)
        {
            return from p in _dataProvider.People
                   where p.BirthPlace.Equals(city)
                   select p;
        }

        public IEnumerable<Person> GetPeopleOrderedByirthDate()
        {
            return from p in _dataProvider.People
                   orderby p.BirthDate
                   select p;
        }

        public IEnumerable<Person> GetPeopleWithGender(string gender)
        {
            return from p in _dataProvider.People
                   where p.Gender.Equals(gender)
                   select p;
        }
    }
}