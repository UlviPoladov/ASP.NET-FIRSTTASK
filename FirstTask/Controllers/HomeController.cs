using FirstTask.Entities;
using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Controllers
{
    public class HomeController : Controller
    {
        private List<Drink> GetDrinks()
        {
            return new List<Drink> {
            new Drink { Id=1, Name="Coca Cola", Description="Qazdi su brat" , Ltr=2 , Price=5},
            new Drink { Id=1, Name="Fanta", Description="Qazdi su brat" , Ltr=2 , Price=5},
            new Drink { Id=1, Name="Ice Tea", Description="soyuq cay" , Ltr=2 , Price=3},
            new Drink { Id=1, Name="Su", Description="su " , Ltr=5 , Price=2},
            new Drink { Id=1, Name="RedBull", Description="qanadlaandirir" , Ltr=1 , Price=9},

            };
        }

        private List<FastFood> GetFastFoods()
        {
            return new List<FastFood> {
            new FastFood { Id=1, Name="Hamburger", Description="blabal" , Time=50 , Price=5},
            new FastFood { Id=1, Name="nugget", Description="blabal" , Time=20 , Price=5},
            new FastFood { Id=1, Name="fri", Description="blabal" , Time=10 , Price=3},
            new FastFood { Id=1, Name="aglimagelmedi", Description="blabal " , Time=505 , Price=2},
            new FastFood { Id=1, Name="birsey", Description="blabal" , Time=34 , Price=9},

            };
        }

        private List<HotMeal> GetHotMeals()
        {
            return new List<HotMeal> {
            new HotMeal { Id=1, Name="babca ", Description="somethn" , Degre=150 , Price=5},
            new HotMeal { Id=1, Name="babnta", Description="somethn" , Degre=15 , Price=5},
            new HotMeal { Id=1, Name="babeea", Description="soyuq" , Degre=45 , Price=3},
            new HotMeal { Id=1, Name="bab", Description="su " , Degre=89 , Price=2},
            new HotMeal { Id=1, Name="babdull", Description="isti" , Degre=23 , Price=9},
            };
        }
        public IActionResult Index()
        {
            var vm = new ViewModel
            {
                Drinkv = GetDrinks(),
                FastFoodv = GetFastFoods(),
                HotMealv = GetHotMeals()
            };

            return View(vm);
        }

        public IActionResult Drinks()
        {
            var drinks = GetDrinks();
            return View(drinks);
        }

        public IActionResult FastFoods()
        {
            var fastFoods = GetFastFoods();
            return View(fastFoods);
        }

        public IActionResult HotMeals()
        {
            var hotMeals = GetHotMeals();
            return View(hotMeals);
        }


    }
}
