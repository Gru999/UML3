using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3 { 
    class Pizza : MenuItem {
        public bool DeepPan { get; set; }

        public Pizza(int number, string name, string description, double price, MenuType type, bool deepPan) : base(number, name, description, price, type) {
            DeepPan = deepPan;
        }

        public override string PrintInfo() {
            return $"{base.PrintInfo()} + {DeepPan}";
        }
    }
}