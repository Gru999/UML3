using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UML3 {
    public class MenuCatalog : IMenuCatalog {
        //dictinoray or list of type IMenuItem (same as MusicianRepository from Orchestra solution)
        List<IMenuItem> _menuItem;
        public int Count { get { return _menuItem.Count; } }

        public MenuCatalog() {
            _menuItem = new List<IMenuItem>();
        }

        public void Add(IMenuItem aMenuItem) {
            foreach (IMenuItem item in _menuItem) {
                if (aMenuItem.Number == item.Number) {
                    throw new Exception("A similar Object already exist");
                }
            }
            _menuItem.Add(aMenuItem);
        }

        //implement the same as in mostExpensive
        public IMenuItem Search(int number) {
            foreach (IMenuItem item in _menuItem) {
                if (item.Number == number) {
                    Console.WriteLine(item.PrintInfo());
                }
                if (item.Number != number && number < item.Number) {
                    throw new Exception("The entered number is out of scope");
                }
            }
            return null;
        }

        //Collection was modified - spørg Poul om fejl 
        public void Delete(int number) {
            foreach (IMenuItem item in _menuItem) {
                if (item.Number == number) {
                    _menuItem.Remove(item);
                    Console.WriteLine("The item have been removed");
                }
                if (item.Number != number && number < item.Number) {
                    throw new Exception("The item you wish to delete does not exist in the current context");
                }   
            }
        }


        public void PrintPizzaMenu() {
            foreach (MenuItem item in _menuItem) {
                if (item.Type == MenuType.Pizza) {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void PrintBeverageMenu() {
            foreach (MenuItem item in _menuItem) {
                if (item.Type == MenuType.SoftDrink) {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void PrintPastaMenu() {
            foreach (MenuItem item in _menuItem) {
                if (item.Type == MenuType.Pasta) {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void Update(int number, IMenuItem theMenuItem) {
            int menuIndex = _menuItem.IndexOf(Search(number));
            _menuItem[menuIndex] = theMenuItem;
        }

        public List<IMenuItem> FindAllVegan(MenuType type) {
            List<IMenuItem> veganItems = new List<IMenuItem>(); 
            foreach (IMenuItem item in _menuItem) {
                if (item.IsVegan) { 
                    veganItems.Add(item);
                    return veganItems;
                }
            }
            return null;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type) {
            List<IMenuItem> organicItems = new List<IMenuItem>();
            foreach (IMenuItem item in _menuItem) {
                if (item.IsOrganic) {
                    organicItems.Add(item);
                    return organicItems;
                }
            }
            return null;
        }

        public IMenuItem MostExpensiveMenuItem() {
            //foreach (MenuItem item in _menuItem) {
            //    if (item.Price == _menuItem) {
            //        Console.WriteLine(item);
            //    }
            //}
            //return null;
            var highPrice = _menuItem.Max(a => a.Price);
            Console.WriteLine(highPrice);
            return null;
        }
    }
}