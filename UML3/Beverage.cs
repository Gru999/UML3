using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace UML3 {
    class Beverage : MenuItem {
        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol) {
            //this.Number = number;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Type = type;
            this.IsVegan = isVegan;
            this.IsOrgranic = isOrganic;
            this.Alcohol = alcohol;
        }

        public override string PrintInfo() {
            return $"{base.PrintInfo()} + {Alcohol}";
            //return $"Number: {Number}, Name: {Name}, Description: {Description}, Price: {Price}, Type: {Type}, Vegan: {IsVegan}, Organic: {IsOrgranic}, Alcoholic: {Alcohol}";
        }
    }
}
