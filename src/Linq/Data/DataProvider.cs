using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Data.Interfaces;
using Linq.Model;

namespace Linq.Data
{
    public class DataProvider : IDataProvider
    {
        private IEnumerable<Animal> _animals;
        private IEnumerable<Person> _people;
        private IEnumerable<Item> _items;
        private IEnumerable<int> _numbers;

        public DataProvider()
        {
            _animals = new List<Animal>()
            {
                new Animal("Cereopsis goose","Cereopsis novaehollandiae","Aves",10237),
                new Animal("Macaw, scarlet","Ara macao","Aves",15033),
                new Animal("Wombat, southern hairy-nosed","Lasiorhinus latifrons","Mammal",13029),
                new Animal("Woylie","Bettongia penicillata","Mammal",12194),
                new Animal("Long-tailed jaeger","Stercorarius longicausus","Aves",15743),
                new Animal("Wallaroo, common","Macropus robustus","Mammal",18023),
                new Animal("Spur-winged goose","Plectopterus gambensis","Aves",11732),
                new Animal("Whale, southern right","Eubalaena australis","Mammal",0),
                new Animal("Heron, little","Butorides striatus","Aves",15291),
                new Animal("Cougar","Felis concolor","Mammal",17560)
            };
            _people = new List<Person>()
            {
                new Person("Valery","Rawsthorn",DateTime.Parse("8/10/1998"),"Berlin","Female"),
                new Person("Dar","Bultitude	",DateTime.Parse("3/7/2014"),"London","Male"),
                new Person("Lea","Bygrave",DateTime.Parse("2/11/1970"),"Sydney","Female"),
                new Person("Alyce","Deaconson",DateTime.Parse("7/15/1955"),"London","Female"),
                new Person("Tobiah","Macari",DateTime.Parse("6/26/1968"),"Berlin","Male"),
                new Person("Arthur","Kimblen",DateTime.Parse("11/15/1997"),"London","Male"),
                new Person("Chrisse","Hulatt",DateTime.Parse("7/2/2003"),"Sydney","Male"),
                new Person("Piper","Vasichev",DateTime.Parse("3/8/1965"),"Sydney","Female"),
                new Person("Chan","Klehn",DateTime.Parse("1/21/2017"),"Hong Kong","Male"),
                new Person("Amil","Pigot",DateTime.Parse("6/28/1958"),"Berlin","Female")
            };
            _items = new List<Item>()
            {
                new Item("Axe", "Tools", 250, DateTime.UtcNow.AddDays(-15), DateTime.UtcNow.AddDays(12)),
                new Item("Driller", "Tools", 300, DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.AddDays(42)),
                new Item("Ball", "Sport", 60, DateTime.UtcNow.AddDays(-7), DateTime.UtcNow.AddDays(12)),
                new Item("Monitor", "Electronics", 800, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.AddDays(23)),
                new Item("Car", "Vehicle", 20000, DateTime.UtcNow.AddDays(-5), DateTime.UtcNow.AddDays(52)),
                new Item("Bike", "Vehicle", 1500, DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.AddDays(42)),
                new Item("Notebook", "Electronics", 3000, DateTime.UtcNow.AddDays(-1), DateTime.UtcNow.AddDays(3)),
                new Item("Pizza", "Food", 40, DateTime.UtcNow.AddDays(-2), DateTime.UtcNow.AddDays(1)),
                new Item("Burger", "Food", 50, DateTime.UtcNow.AddDays(-1), DateTime.UtcNow.AddDays(2)),
                new Item("Boots", "Sport", 200, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.AddDays(50))
            };
            _numbers = Enumerable.Range(0,100);
        }
        public IEnumerable<Animal> Animals { get {return _animals;}}
    
        public IEnumerable<Person> People { get {return _people;}}

        public IEnumerable<Item> Items { get {return _items;}}

        public IEnumerable<int> Numbers { get {return _numbers;}}
    }
}