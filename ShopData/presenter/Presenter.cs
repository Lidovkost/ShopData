using ShopData.goods;
using ShopData.goods.autoPart;
using ShopData.goods.products.drinks;
using ShopData.goods.products.sweets;
using ShopData.goods.Requests;
using ShopData.goods.Requests.autoPartRequest;
using ShopData.goods.Requests.product_requests;
using ShopData.repository;
using ShopData.repository.SQLiteRepository;
using ShopData.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.presenter
{
    public class Presenter
    {
        private IView _view;
        public Presenter(IView view)
        {
            _view = view;
            _view.SetPresenter(this);
        }
        public bool AddNewDrink(DrinkRequest drinkRequest)
        {
            try
            {
                DrinkSQLiteRepository repo = new DrinkSQLiteRepository();
                repo.Add(drinkRequest.Create());
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool AddNewAutoPart(AutoPartRequest partRequest)
        {
            try
            {
                AutoPartSQLiteRepository repo = new AutoPartSQLiteRepository();
                repo.Add(partRequest.Create());
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool AddNewMilkProduct(MilkProductRequest milkProductRequest)
        {
            try
            {
                MilkSQLiteRepository repo = new MilkSQLiteRepository();
                repo.Add(milkProductRequest.Create());
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool AddNewSweetProduct(SweetProductRequest sweetProductRequest)
        {
            try
            {
                SweetSQLiteRepository repo = new SweetSQLiteRepository();
                repo.Add(sweetProductRequest.Create());
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public List<AutoPart> GetAllAutoParts()
        {
            AutoPartSQLiteRepository repo = new AutoPartSQLiteRepository();
            return repo.GetAll();
        }
        public List<MilkProduct> GetAllMilkProducts()
        {
            MilkSQLiteRepository repo = new MilkSQLiteRepository();
            return repo.GetAll();
        }
        public List<Drink> GetAllDrinks()
        {
            DrinkSQLiteRepository repo = new DrinkSQLiteRepository();
            return repo.GetAll();
        }
        public List<Sweet> GetAllSweets()
        {
            SweetSQLiteRepository repo = new SweetSQLiteRepository();
            return repo.GetAll();
        }
        public List<AutoPart> GetAutoPartsByBrand(string brand)
        {
            AutoPartSQLiteRepository repo = new AutoPartSQLiteRepository();
            return repo.GetByBrand(brand);
        }
        public List<AutoPart> GetAutoPartsByTypeName(string typeName)
        {
            AutoPartSQLiteRepository repo = new AutoPartSQLiteRepository();
            return repo.GetByTypeName(typeName);
        }
        public List<Drink> GetInvalidDrinks()
        {
            DrinkSQLiteRepository repo = new DrinkSQLiteRepository();
            return repo.GetNoValidProducts();
        }
        public List<MilkProduct> GetInvalidMilkProducts()
        {
            MilkSQLiteRepository repo = new MilkSQLiteRepository();
            return repo.GetNoValidProducts();
        }
        public List<Sweet> GetInvalidsweets()
        {
            SweetSQLiteRepository repo = new SweetSQLiteRepository();
            return repo.GetNoValidProducts();
        }
        public MilkProduct GetMilkProductByQrCode(int Qrcode)
        {
            MilkSQLiteRepository repo = new MilkSQLiteRepository();
            return repo.GetBYQRcode(Qrcode);
        }
        public List<Sweet> GetSweetsByPrice(int price)
        {
            SweetSQLiteRepository repo = new SweetSQLiteRepository();
            return repo.GetByPrice(price);
        }
    }
}
