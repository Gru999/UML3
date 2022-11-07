using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3 {
    public class MenuCatalog : IMenuCatalog {
        //dictinoray or list of type IMenuItem (same as MusicianRepository from Orchestra solution)
        public int Count { get; }
        public void Add(IMenuItem aMenuItem);
        public IMenuItem Search(int number);
        public void Delete(int number);
        public void PrintPizzaMenu();
        public void PrintBeverageMenu();
        public void PrintPastaMenu();
        public void Update(int number, IMenuItem theMenuItem);
        public List<IMenuItem> FindAllVegan(IMenuItem.MenuType type);
        public List<IMenuItem> FindAllOrganic(IMenuItem.MenuType type);
        public IMenuItem MostExpensiveMenuItem();
    }
}