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
    public partial class BurgerFormPage : ContentPage
    {
        BurgerFormViewModel vm;
        public BurgerFormPage()
        {
            InitializeComponent();
            vm = new BurgerFormViewModel();
            BindingContext = vm;
            vm.Navigation = this.Navigation;
        }
    }
}