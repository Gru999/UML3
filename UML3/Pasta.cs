using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UML3 {
    class Pasta : MenuItem {
        public bool Cheese { get; set; }
        public Pasta(int number, string name, string description, double price, MenuType type, bool cheese) : base(number, name, description, price, type) {
            Cheese = cheese;
        }
        
        public override string PrintInfo() {
            return $"{base.PrintInfo()} Cheese: {Cheese}\n";
        }
    }
}
