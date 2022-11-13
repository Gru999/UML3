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
                    return item.Number;
                }
            }
        }

        public void Delete(int number) {
            _menuItem.RemoveAt(number);
        }

        public void PrintPizzaMenu() {
            foreach (IMenuItem item in _menuItem)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintBeverageMenu() {
            foreach (IMenuItem item in _menuItem)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintPastaMenu() {
            foreach (IMenuItem item in _menuItem)
            {
                Console.WriteLine(item);
            }
        }
        
        public void Update(int number, IMenuItem theMenuItem);

        public List<IMenuItem> FindAllVegan(MenuType type) { 
            
        }

        public List<IMenuItem> FindAllOrganic(MenuType type) {
            if (type == MenuType.Pizza || type == MenuType.Pasta)
            {
                foreach (IMenuItem item in _menuItem)
                {
                    if (item.IsOrganic)
                    {
                        Console.WriteLine(item);                        
                    }
                }
            }

        }

        public IMenuItem MostExpensiveMenuItem();
    }
}