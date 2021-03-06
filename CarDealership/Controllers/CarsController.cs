﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/newcar")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/newCar")]
        public IActionResult Create(string makeModel, int price, int miles)
        {
            Car newCar = new Car(makeModel, price, miles);
            return RedirectToAction("Index");
        }

    }
}
