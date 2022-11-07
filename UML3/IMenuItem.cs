﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3 {
    public interface IMenuItem {
        public enum MenuType { Pizza, Pasta, Topping, SoftDrink, AlcoholicDrink }
            int Number { get; }
            string Name { get; set; }
            string Description { get; set; }
            double Price { get; set; }
            MenuType Type { get; set; }
            bool IsVegan { get; set; } 
            bool IsOrgranic { get; set; }
            string PrintInfo();
    }
}
