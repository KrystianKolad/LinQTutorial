using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Data;
using Linq.Data.Interfaces;

namespace Linq {
    class Program {
        private static IDataProvider _dataProvider;
        static void Main (string[] args)
        {
             _dataProvider = new DataProvider();
            // var aves = _dataProvider.Animals.Where(x=>x.Class.Equals("Aves"));
            // // var mammals = from a in _dataProvider.Animals
            // //               where a.Class.Equals("Mammal")
            // //               select a;

            // // var avesAndMammals = aves.Union(mammals).OrderBy(x=>x.Population).Skip(2).Take(3).ToArray();
            // // var avesAndMammalsQuery = (from a in aves
            // //                           select a)
            // //                           .Union(from m in mammals
            // //                           select m);

            // // var oldPeople = _dataProvider.People.Where(x=>x.BirthDate.Year<1950).FirstOrDefault();
            // // var youngPeople = from p in _dataProvider.People
            // //                   where p.BirthDate.Year>1999
            // //                   select p;

            // // var sum = _dataProvider.Numbers.Where(x=>x%2==0).Sum();
            // // var numbers = from n in _dataProvider.Numbers
            // //               where n % 2 != 0
            // //               orderby n descending
            // //               select n;

            // // var gruppedAves = _dataProvider.Animals.Where(x=>x.Population>12000).OrderBy(x=>x.Population).GroupBy(x=>x.Class);
            // // var gruppedAvesQuery = from a in _dataProvider.Animals
            // //                        where a.Population>12000
            // //                        orderby a.Population
            // //                        group a by a.Class into ga
            // //                        select ga;

            // // var sportItems = _dataProvider.Items.Where(x=>x.Category.Equals("Sport"));
            // // var foodItems = from i in _dataProvider.Items
            // //                 where i.Category.Equals("Food")
            // //                 select i;
            // // var foodAndSportItems = foodItems.Union(sportItems);
            // // var sportAndFoodItems = sportItems.Union(foodItems).Reverse();

            // var query = from number in _dataProvider.Numbers
            //             where number % 2 == 0 
            //             select number;

            // var query1 = from animal in _dataProvider.Animals
            //              where animal.Population>14000
            //              select animal;

            // var query2 = from animal in _dataProvider.Animals
            //             group animal by animal.Class into gruppedAnimal
            //             select gruppedAnimal;

            // var query3 = from item in _dataProvider.Items
            //             orderby item.Price descending
            //             select item;


            var method = _dataProvider.Numbers.Where(x=>x%2!=0).ToArray();

            var method1 = _dataProvider.Animals.Where(x=>x.Population>12000).Where(x=>x.Population<14000).Skip(1);

            var method2 =_dataProvider.People.GroupBy(x=>x.Gender);

            var tools = _dataProvider.Items.Where(x=>x.Category.Equals("Tools"));
            var sport = _dataProvider.Items.Where(x=>x.Category.Equals("Sport"));

            var toolsAndSports= tools.Union(sport);
            var sportsAndTools = sport.Union(tools);

            var people = _dataProvider.People.OrderBy(x=>x.BirthDate).Skip(2).Take(3);

            var method3 = _dataProvider.People.Take(1).Union(_dataProvider.People.Skip(3));


            //var first = _dataProvider.People.Where(x=>x.Name.Equals("123")).First();
            //var FirstOrDefault = _dataProvider.People.Where(x=>x.Name.Equals("123")).FirstOrDefault();
            //var single = _dataProvider.People.Where(x=>x.Name.Equals("123")).Single();
            //var singleOrDefault = _dataProvider.People.Where(x=>x.Name.Equals("123")).SingleOrDefault();
            var reverse = _dataProvider.Numbers.Reverse();

            var items = _dataProvider.Items
                        .OrderByDescending(x=>x.Price)
                        .Skip(3)
                        .SkipLast(1)
                        .Reverse()
                        .ToArray();

            PLinqExample(1000000000);
            PLinqExample(10000000);

            Console.ReadKey();
        }

        private static void PLinqExample (int range) 
        {
            Console.WriteLine("Wynik działania programu dla " + range + " Liczb:");
            IEnumerable<int> data = Enumerable.Range(1, range);
            int condition = range/20;

            var lquery = data.Where(x => x % condition == 0);

            Console.WriteLine ("LinQ result:");
            foreach (var item in lquery) {
                Console.WriteLine (item);
            }

            var pquery = data.AsParallel().Where (x => x % condition== 0);

            Console.WriteLine ("PlinQ result:");
            foreach (var item in pquery) {
                Console.WriteLine (item);
            }
        }
    }
}