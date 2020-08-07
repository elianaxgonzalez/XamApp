using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using XamApp.Models;
using Xamarin.Forms;

namespace XamApp.ViewModels
{
    public class BurgerListViewModel : BaseViewModel
    {
        public ICommand BackButtonCommand { get; set; }

        private ObservableCollection<Burger> _burgers = new ObservableCollection<Burger>();

        public ObservableCollection<Burger> Burgers
        {
            get { return _burgers; }
            set { _burgers = value;
                OnPropertyChanged();
            }
        }

        public BurgerListViewModel()
        {
            BackButtonCommand = new Command( () => Navigation.PopAsync());
            GetResponse();
        }

        async void GetResponse()
        {
            try
            {
                //var apiResponse = RestService.For<IBurgersApi>("https://netcorexam.azurewebsites.net/api/v1/NetCoreXamApi");
                //var response = await apiResponse.GetBurgers();

                Burgers = new ObservableCollection<Burger>
                {
                    new Burger
                    {
                        NombreHamburguesa = "Burger Pizza Hub",
                        Categoria = "Burger - Pizza - Breakfast",
                        Calificacion = (decimal)4.8,
                        Rating = 121,
                        Favorito = true,
                        Imagen = "LightBurger"
                    },
                     new Burger
                    {
                        NombreHamburguesa = "Rock Burger",
                        Categoria = "Burger - Pizza",
                        Calificacion = (decimal)4.6,
                        Rating = 98,
                        Favorito = false,
                        Imagen = "RockBurger"
                    },
                      new Burger
                    {
                        NombreHamburguesa = "Prado Burger",
                        Categoria = "Burger - Breakfast",
                        Calificacion = (decimal)4.9,
                        Rating = 176,
                        Favorito = false,
                        Imagen = "PradoBurger"
                    },
                      new Burger
                    {
                        NombreHamburguesa = "Combo Burger",
                        Categoria = "Burger - Breakfast",
                        Calificacion = (decimal)4.7,
                        Rating = 96,
                        Favorito = true,
                        Imagen = "ComboBurger"
                    },
                      new Burger
                    {
                        NombreHamburguesa = "Basic Burger",
                        Categoria = "Burger - Pizza",
                        Calificacion = (decimal)4.2,
                        Rating = 89,
                        Favorito = false,
                        Imagen = "BasicBurger"
                    }


                };

            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
    }
}
