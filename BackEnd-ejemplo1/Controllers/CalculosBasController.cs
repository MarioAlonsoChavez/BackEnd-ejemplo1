﻿using BackEnd_ejemplo1.Models;
using BackEnd_ejemplo1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class CalculosBasController : Controller
    {
        // GET: CalculosBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string Num1, string Num2)
        {
            int res =Convert.ToInt16(Num1) + Convert.ToInt16(Num2);

            ViewBag.Res = Convert.ToString(res);

            return View(res);
        }
        public ActionResult Operas()
        {
            OperasBas op = new OperasBas();
            return View(op);
        }
        [HttpPost]

        public ActionResult Operas(OperasBas op)
        {
            op.Suma();
            //ViewBag.Res=op.Res;
            return View(op);
        }

        public ActionResult MostrarPeliculas()
        {
            var peliculaService = new PeliculaService();
            var model = peliculaService.ObtenerPelicula();

            return View(model);
        } 
    }
}