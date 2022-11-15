using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UML3.IMenuItem;
namespace UML3 {
    abstract class MenuItem : IMenuItem {
        //Abstract: en klasse der ikke kan bruges til a skabe objekter.
        //For at kunne bruge den skal den arves fra en klasse. 
        private int _number;
        public int Number { get { return _number; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, string name, string description, double price, MenuType type) {
            _number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = true;
            IsOrganic = true;
        }

        public virtual string PrintInfo() {
            return $"Number: {Number}, " +
                   $"Name: {Name}, " +
                   $"Description: {Description}, " +
                   $"Price: {Price}, " +
                   $"Type: {Type}, " +
                   $"Vegan: {IsVegan}, " +
                   $"Organic: {IsOrganic}";
        }
    }
}
