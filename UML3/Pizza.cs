using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3 { 
    class Pizza : MenuItem {

        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan  ) {
            //this.Number = number;
            this.Name = name;
            this.Description = description; 
            this.Price = price;
            this.Type = type;
            this.IsVegan = isVegan;
            this.IsOrgranic = isOrganic;
            this.DeepPan = deepPan;
        }

        public override string PrintInfo() {
            return $"{base.PrintInfo()} + {DeepPan}";
            //return $"Number: {Number}, Name: {Name}, Description: {Description}, Price: {Price}, Type: {Type}, Vegan: {IsVegan}, Organic: {IsOrgranic}, DeepPan: {DeepPan}";
        }
    }
}