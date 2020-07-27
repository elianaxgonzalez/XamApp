using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamApp.Models;
using XamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurgerListPage : ContentPage
    {

        BurgerListViewModel vm;

        public BurgerListPage()
        {
            InitializeComponent();
            vm = new BurgerListViewModel();
            BindingContext = vm;
            vm.Navigation = this.Navigation;
        }
    }
}