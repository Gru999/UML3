using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace UML3 {
    class Beverage : MenuItem {
        public bool Alcohol { get; set; }
        public Beverage(int number, string name, string description, double price, MenuType type, bool alcohol) : base(number, name, description, price, type) {
           Alcohol = alcohol;
        }

        public override string PrintInfo() {
            return $"{base.PrintInfo()} + {Alcohol}";
        }
    }
}
