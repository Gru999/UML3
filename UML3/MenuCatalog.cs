using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UML3 {
    public class MenuCatalog : IMenuCatalog {
        //dictinoray or list of type IMenuItem (same as MusicianRepository from Orchestra solution)
        private List<IMenuItem> _menuItem;
        public int Count { get; }
        public void Add(IMenuItem aMenuItem) {
            _menuItem.Add(aMenuItem);
        }
        public IMenuItem Search(int number) {
            foreach (IMenuItem item in _menuItem) {
                if (item.Number == number) {
                    return item;
                }
            }
            return null;
        }

        public void Delete(int number) {
            _menuItem.RemoveAt(number);
        }

        public void PrintPizzaMenu() {
            foreach (IMenuItem item in _menuItem) {
                Console.WriteLine(item);
            }
        }

        //dosen't print just the beverage menu
        public void PrintBeverageMenu() {
            foreach (IMenuItem item in _menuItem) {
                Console.WriteLine(item);
            }
        }

        public void PrintPastaMenu() {
            foreach (IMenuItem item in _menuItem) {
                Console.WriteLine(item);
            }
        }

        public void Update(int number, IMenuItem theMenuItem) { 
            
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
            //double maxPrice = 0;
            //foreach (IMenuItem item in _menuItem) {
            //    if (item.Price > maxPrice) {
            //        maxPrice = item.Price;
            //    } else if (item.Price) { } 
            //}
            return null;
        }
    }
}