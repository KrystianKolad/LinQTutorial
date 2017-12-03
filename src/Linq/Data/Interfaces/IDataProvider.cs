using System.Collections.Generic;
using Linq.Model;

namespace Linq.Data.Interfaces
{
    public interface IDataProvider
    {
        IEnumerable<Animal> Animals {get;}

        IEnumerable<Person> People {get;}

        IEnumerable<Item> Items {get;}

        IEnumerable<int> Numbers {get;}
    }
}