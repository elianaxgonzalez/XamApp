using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using XamApp.Services;

namespace XamApp.ViewModels
{
    public class BurgerListViewModel : BaseViewModel
    {

        public BurgerListViewModel()
        {
            GetResponse();
        }

        async void GetResponse()
        {
            var apiResponse = RestService.For<IBurgersApi>("https://netcorexam.azurewebsites.net/api/v1/NetCoreXamApi");
            var response = await apiResponse.GetBurgers();
        }
    }
}
