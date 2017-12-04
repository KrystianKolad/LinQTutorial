using System.Collections.Generic;
using Linq.Model;

namespace Linq.Samples.Interfaces
{
    public interface ISamples
    {
         IEnumerable<Item> GetItemsByCategory(string category);

         IEnumerable<Item> GetItemsWithPriceMoreThan(decimal price);
         IEnumerable<Item> GetItemsWithPriceLessThan(decimal price);

         IEnumerable<Item> GetItemsWithPriceBetween(decimal lowerPrice, decimal higherPrice);

         IEnumerable<Item> GetItemsWithExpirationDateInLessThan(int days);

         IEnumerable<Animal> GetAnimalsByClass(string @class);

         IEnumerable<Animal> GetAnimalsWithPopulationLessThan(int population);

         IEnumerable<Person> GetPeopleWithGender(string gender);

         IEnumerable<Person> GetPeopleBornIn(string city);

         IEnumerable<Person> GetPeopleOrderedByirthDate();
    }
}