using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Data;
using Linq.Data.Interfaces;

namespace Linq {
    class Program {
        private IDataProvider _dataProvider;
        public Program()
        {
            _dataProvider = new DataProvider();
        }
        static void Main (string[] args)
        {
            Console.ReadKey();
        }

        private static void PLinqExample (int range) 
        {
            Console.WriteLine("Wynik działania programu dla " + range + " Liczb:");
            IEnumerable<int> data = Enumerable.Range(1, range);
            int condition = range/10;

            var lquery = data.Where (x => x % condition == 0);

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