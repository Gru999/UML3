using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UML3.IMenuItem;

namespace UML3 {
    abstract class MenuItem : IMenuItem {
        /*
         * Abstract: en klasse der ikke kan bruges til a skabe objekter og for at kunne bruge den skal den arves fra en klasse. 
         */
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrgranic { get; set; }
        public bool DeepPan { get; set; }
        public bool Alcohol { get; set; }
        public bool Cheese { get; set; }

        public virtual string PrintInfo() {
            return $"Number: {Number}, Name: {Name}, Description: {Description}, Price: {Price}, Type: {Type}, Vegan: {IsVegan}, Organic: {IsOrgranic}";
        }

    }
}
