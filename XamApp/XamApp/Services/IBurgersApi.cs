using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamApp.Models;

namespace XamApp.Services
{
    interface IBurgersApi
    {
        [Get("/Hamburguesas")]
        Task<List<Burger>> GetBurgers();
    }
}
