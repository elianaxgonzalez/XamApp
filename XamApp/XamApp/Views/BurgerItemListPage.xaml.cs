using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurgerItemListPage : ContentPage
    {
        BurgerItemListViewModel vm;

        public BurgerItemListPage()
        {
            InitializeComponent();
            vm = new BurgerItemListViewModel();
            BindingContext = vm;
            vm.Navigation = this.Navigation;
        }
    }
}