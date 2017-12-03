namespace Linq.Model {
    public class Animal {
        public Animal (string name, string species, string @class, int population) {
            this.Name = name;
            this.Species = species;
            this.Class = @class;
            this.Population = population;
        }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Class { get; set; }
        public int Population{ get; set;}
    }
}