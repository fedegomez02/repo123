using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebPasajero.Data;
using WebPasajero.Models;
using System.Linq;
namespace WebPasajero.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly PasajeroContext _context;

        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            Pasajero pasajero = new Pasajero();
            return View("Create", pasajero);
        }

        // POST: /Person/Create
        [HttpPost]
        public IActionResult Create(Pasajero person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
      
        public IActionResult ListaPorCiudad(string Ciudad)
        {
            List<Pasajero> lista = (from p in _context.People
                                    where p.Ciudad == Ciudad
                                  select p).ToList();
            return View("Index", lista);
        }



    }
}
