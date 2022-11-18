using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace UML3 {
    public class MenuCatalog : IMenuCatalog {
        //dictinoray or list of type IMenuItem (same as MusicianRepository from Orchestra solution)
        //make them return instead of print
        //mostexpensive can be shorter
        //list needs exception fix
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

        public IMenuItem Search(int number) {
            IMenuItem i = null;
            foreach (IMenuItem item in _menuItem) {
                if (item.Number == number) {
                    i = item;
                }
                if (0 > number || number > _menuItem.Count) {
                    throw new Exception("The entered number is out of scope");
                }
            }
            return i;
        }

        public void Delete(int number) {
            foreach (IMenuItem item in _menuItem) {
                if (item.Number == number) {
                    _menuItem.Remove(item);
                } 
                if (0 > number || number > _menuItem.Count) {
                    throw new Exception("The item you wish to delete does not exist in the current context");
                }   
            }
        }

        //No input, therefor no exception
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
            if (menuIndex < 0 || menuIndex > _menuItem.Count) {
                throw new Exception("The number is out of scope");
            }
        }
                
        public List<IMenuItem> FindAllVegan(MenuType type) {
            List<IMenuItem> veganItems = new List<IMenuItem>(); 
            foreach (IMenuItem item in _menuItem) {
                if (item.IsVegan && type == item.Type) { 
                    veganItems.Add(item);  
                }
            }
            if (!(type is Enum)) {
                throw new Exception("No such Menu Type exists");
            }
            return veganItems;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type) {
            List<IMenuItem> organicItems = new List<IMenuItem>();
            foreach (IMenuItem item in _menuItem) {
                if (item.IsOrganic && type == item.Type) {
                    organicItems.Add(item);
                }
                if (!(type is Enum)) {
                        throw new Exception("No such Menu Type exists");
                }
            }
            return organicItems;
        }
        
        public IMenuItem MostExpensiveMenuItem() {
            IMenuItem j = null;
            foreach (IMenuItem item in _menuItem) {
                if (item.Price == _menuItem.Max(i => i.Price)) {
                    j = item;
                }
            }
            return j;
        }
    }
}