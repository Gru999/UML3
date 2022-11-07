using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    public interface IMenuCatalog {
        int Count { get; }
        void Add(IMenuItem aMenuItem);
        IMenuItem Search(int number);
        void Delete(int number);
        void PrintPizzaMenu();
        void PrintBeverageMenu();
        void PrintPastaMenu();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(IMenuItem.MenuType type);
        List<IMenuItem> FindAllOrganic(IMenuItem.MenuType type);
        IMenuItem MostExpensiveMenuItem();
    }
}
