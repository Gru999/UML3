
using UML3;

Pizza p1 = new Pizza(1, "Margherita", "-Tomat og Ost", 52, MenuType.Pizza, true, true, false);
Pizza p2 = new Pizza(2, "Vesuvio", "-Tomat, Ost og Skinke", 59, MenuType.Pizza, false, true, false);
Pizza p3 = new Pizza(3, "New York", "-Tomat, Ost, Pepperoni og Løg", 72, MenuType.Pizza, true, false, true);

Pasta pa1 = new Pasta(1, "Carbonnara", "-Bacon, Æg, ost og Flødesauce", 70, MenuType.Pasta, false, true, true);
Pasta pa2 = new Pasta(2, "Meat Pasta", "-Bacon, Æg, Champignon og Tomatflødesauce", 75, MenuType.Pasta, true, false, false);

Beverage b1 = new Beverage(1, "Sodavand", "-Cola, Fanta, Cola Zero, Faxe kondi", 25, MenuType.SoftDrink, true, false, false);
Beverage b2 = new Beverage(2, "Dåse øl", "-Pr. stk", 15, MenuType.AlcoholicDrink, false, true, true);

Console.WriteLine(p1);
Console.WriteLine(pa1);
Console.WriteLine(b1);


