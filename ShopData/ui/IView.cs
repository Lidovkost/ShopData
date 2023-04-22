using ShopData.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui
{
    public interface IView
    {
        void Start();
        void SetPresenter(Presenter presenter);
        void Print(string text);
    }
}
