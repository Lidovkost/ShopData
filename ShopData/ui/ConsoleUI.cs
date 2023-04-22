using ShopData.goods;
using ShopData.goods.autoPart;
using ShopData.goods.products.drinks;
using ShopData.goods.products.sweets;
using ShopData.goods.Requests.autoPartRequest;
using ShopData.goods.Requests.product_requests;
using ShopData.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui
{
    public class ConsoleUI : IView
    {
        private Presenter _presenter;
        bool work;

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void SetPresenter(Presenter presenter)
        {
            _presenter = presenter;
        }

        public void Start()
        {
            work = true;
            while (work)
            {
                Menu menu = new Menu(this);
                Console.WriteLine("Введите команду: ");
                menu.PrintMenu();
                menu.Excecute(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public bool AddNewDrink()
        {
            DrinkRequest drinkRequest = new DrinkRequest();
            return _presenter.AddNewDrink(drinkRequest);
        }
        public bool AddNewAutoPart()
        {
            AutoPartRequest partRequest = new AutoPartRequest();
            return _presenter.AddNewAutoPart(partRequest);
        }
        public bool AddNewMilkProduct()
        {
            MilkProductRequest milkRequst = new MilkProductRequest();
            return _presenter.AddNewMilkProduct(milkRequst);
        }
        public bool AddNewSweetProduct()
        {
            SweetProductRequest sweetRequest = new SweetProductRequest();
            return _presenter.AddNewSweetProduct(sweetRequest);
        }
        public void GetAutoPartList()
        {
            List<AutoPart> parts = _presenter.GetAllAutoParts();
            foreach (AutoPart part in parts)
            {
                Console.WriteLine(part.ToString());
            }
        }
        public void GetDrinksList()
        {
            List<Drink> drinks = _presenter.GetAllDrinks();
            foreach (Drink drink in drinks)
            {
                Console.WriteLine(drink.ToString());
            }
        }
        public void GetMilkProductsList()
        {
            List<MilkProduct> milks = _presenter.GetAllMilkProducts();
            foreach (MilkProduct milk in milks)
            {
                Console.WriteLine(milk.ToString());
            }
        }
        public void GetSweetsList()
        {
            List<Sweet> sweets = _presenter.GetAllSweets();
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(sweet.ToString());
            }
        }
        public void GetAutoPartsByBrand()
        {
            Console.WriteLine("Введите название брэнда");
            List<AutoPart> parts = _presenter.GetAutoPartsByBrand(Console.ReadLine());
            foreach (AutoPart part in parts)
            {
                Console.WriteLine(part.ToString());
            }
        }
        public void GetAutoPartsByTypeName()
        {
            Console.WriteLine("Введите тип искомого товара");
            List<AutoPart> parts = _presenter.GetAutoPartsByTypeName(Console.ReadLine());
            foreach (AutoPart part in parts)
            {
                Console.WriteLine(part.ToString());
            }
        }
        public void GetInvalidDrinks() 
        {
            List<Drink> drinks = _presenter.GetInvalidDrinks();
            foreach (Drink drink in drinks)
            {
                Console.WriteLine(drink.ToString());
            }
        }
        public void GetInvalidMilkProducts()
        {
            List<MilkProduct> milks = _presenter.GetInvalidMilkProducts();
            foreach (MilkProduct milk in milks)
            {
                Console.WriteLine(milk.ToString());
            }
        }
        public void GetInvalidSweets()
        {
            List<Sweet> sweets = _presenter.GetInvalidsweets();
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(sweet.ToString());
            }
        }
        public void GetSweetsByPrice()
        {
            Console.WriteLine("Введите потолок цены");
            List<Sweet> sweets = _presenter.GetSweetsByPrice(Convert.ToInt32(Console.ReadLine()));
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(sweet.ToString());
            }
        }
        public void Finish()
        {
            work = false;
        }


    }
}
