
using UML3;

IMenuCatalog catalog = new MenuCatalog();

Pizza p1 = new Pizza(1, "Margherita", "-Tomat og Ost", 52, MenuType.Pizza, false);
Pizza p2 = new Pizza(2, "Vesuvio", "-Tomat, Ost og Skinke", 59, MenuType.Pizza, false);
Pizza p3 = new Pizza(3, "New York", "-Tomat, Ost, Pepperoni og Løg", 72, MenuType.Pizza, true);

Pasta pa1 = new Pasta(1, "Carbonnara", "-Bacon, Æg, ost og Flødesauce", 70, MenuType.Pasta, true);
Pasta pa2 = new Pasta(2, "Meat Pasta", "-Bacon, Æg, Champignon og Tomatflødesauce", 75, MenuType.Pasta, false);

Beverage b1 = new Beverage(1, "Sodavand", "-Cola, Fanta, Cola Zero, Faxe kondi", 25, MenuType.SoftDrink, false);
Beverage b2 = new Beverage(2, "Dåse øl", "-Pr. stk", 15, MenuType.AlcoholicDrink, true);

////Add method test
//catalog.Add(p1);
//catalog.Add(p2);
//catalog.Add(p3);
//catalog.Add(pa1);
//catalog.Add(pa2);
//catalog.Add(b1);
//catalog.Add(b2);

//Console.WriteLine($"There are {catalog.Count} items on the menu");

//////Search method test
////Console.WriteLine(catalog.Search(3));

////Print Pizza Menu method test
//catalog.PrintPizzaMenu();

////Print Beverage Menu method test
//catalog.PrintBeverageMenu();

////Print Pasta Menu method test
//catalog.PrintPastaMenu();

////Update method test
//catalog.Update(4, p2);

////List methods test
//List<IMenuItem> veganItems = catalog.FindAllVegan(MenuType.Pizza);
//List<IMenuItem> organicItems = catalog.FindAllOrganic(MenuType.Pizza);

//foreach (IMenuItem veganItem in veganItems) {
//    Console.WriteLine(veganItem.PrintInfo());
//}

//foreach (IMenuItem organicItem in organicItems) {
//    Console.WriteLine(organicItem.PrintInfo());
//}

//Most Expensive Item method test
catalog.MostExpensiveMenuItem();