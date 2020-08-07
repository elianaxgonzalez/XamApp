using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using XamApp.Models;
using XamApp.Services;

namespace XamApp.ViewModels
{
    public class BurgerListViewModel : BaseViewModel
    {
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
                        NombreHamburguesa = "Rock Burger",
                        Categoria = "Burger - Pizza",
                        Calificacion = (decimal)4.5,
                        Rating = 121,
                        Favorito = true,
                        Imagen = "bacon-burger"
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
