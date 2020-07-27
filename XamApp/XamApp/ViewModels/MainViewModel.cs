using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamApp.Views;
using Xamarin.Forms;

namespace XamApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        #region Commands
        public ICommand MenuCommand { get; set; }
        #endregion

        public MainViewModel()
        {
            MenuCommand = new Command<string>(MenuBotones);
        }

        private void MenuBotones(string pagina)
        {
            switch (pagina)
            {
                case "stack":
                    Navigation.PushAsync(new StackPage());
                    break;
                case "grid":
                    Navigation.PushAsync(new GridPage());
                    break;
                case "form":
                    Navigation.PushAsync(new BurgerFormPage());
                    break;
                case "item":
                    Navigation.PushAsync(new BurgerItemListPage());
                    break;
                case "list":
                    Navigation.PushAsync(new BurgerListPage());
                    break;
                default:
                    break;
            }
        }
    }
}
