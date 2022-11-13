using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UML3 {
    class Pasta : MenuItem {
        public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool cheese) {
            //this.Number = number;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Type = type;
            this.IsVegan = isVegan;
            this.IsOrganic = isOrganic;
            this.Cheese = cheese;
        }
        
        public override string PrintInfo() {
            return $"{base.PrintInfo()} + {Cheese}";
            //return $"Number: {Number}, Name: {Name}, Description: {Description}, Price: {Price}, Type: {Type}, Vegan: {IsVegan}, Organic: {IsOrgranic}, Cheese: {Cheese}";
        }
    }
}
