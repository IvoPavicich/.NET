﻿using IntroduccionMVC.Data;
using IntroduccionMVC.Data.Entities;
using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace IntroduccionMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Vista Nuevo
        public IActionResult New()
        {
            return View();
        }

        //Vista Editar 
        public IActionResult Edit(int id)
        {
            if (_dbContext.Vehiculos.Any(x=>x.Id==id)) 
            {
                VehicleModel modelo = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion,


                }).First(x => x.Id == id);
                
                return View(modelo);
            }
            return RedirectToAction("Error","Home");
        }

        //Vista Eliminar
        public IActionResult Remove(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id))
            {
                VehicleModel modelo = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion,


                }).First(x => x.Id == id);

                return View(modelo);
            }
            return RedirectToAction("Error", "Home");
        }
        //Vista Detalle
        public IActionResult Detail(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id))
            {
                VehicleModel modelo = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion,


                }).First(x => x.Id == id);

                return View(modelo);
            }
            return RedirectToAction("Error", "Home");
        }

        //POST 
        [HttpPost]public async Task<IActionResult> Create(VehicleModel vehiculo) 
        {

            if (!ModelState.IsValid) 
            {
                return View("New", vehiculo);
            }
            try
            {
                Vehiculo v = new()
                {
                    Dominio=vehiculo.Dominio,
                    NumeroChasis = vehiculo.NumeroChasis,
                    Propietario = vehiculo.Propietario,
                    AnioFabricacion = vehiculo.AnioFabricacion,

                };
                _dbContext.Add(v);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));

            }
        }

        //POST
        [HttpPost]public async Task<IActionResult> Update(VehicleModel vehiculoModel)
        {
            try
            {
                if (_dbContext.Vehiculos.Any(x=>x.Id== vehiculoModel.Id))
                {
                    Vehiculo vehicleUpdate = _dbContext.Vehiculos.Select(v => new Vehiculo
                    {
                        Id = v.Id,
                        Dominio = vehiculoModel.Dominio,
                        NumeroChasis = vehiculoModel.NumeroChasis,
                        Propietario = vehiculoModel.Propietario,
                        AnioFabricacion = vehiculoModel.AnioFabricacion,


                    }).First(x=> x.Id == vehiculoModel.Id);
                    _dbContext.Update(vehicleUpdate);
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction("Error","Home");
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (_dbContext.Vehiculos.Any(x => x.Id == id))
                {
                    Vehiculo vehiculoDelete = _dbContext.Vehiculos.First(x => x.Id == id);
                    _dbContext.Remove(vehiculoDelete);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction("Error", "Home");
            }
            catch (Exception)
            {

                throw;
            }
        }



        //Vista Lista
        public IActionResult Index()
        {
            var vehiculos = _dbContext.Vehiculos.ToList();

            //var model = new VehicleListViewModel
            //{
            //    Vehiculos = new List<VehicleListModel>()
            //};

            //foreach(var vehiculo in vehiculos)
            //{
            //    model.Vehiculos.Add(new VehicleListModel
            //    {
            //        Id = vehiculo.Id,
            //        Dominio = vehiculo.Dominio,
            //        AnioFabricacion = vehiculo.AnioFabricacion
            //    });
            //}

            var vehiclesList = vehiculos
                .Select(v => new VehicleListModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    AnioFabricacion = v.AnioFabricacion
                })
                .ToList();

            ViewData["miTitulo"] = "My Vehicles";
           // ViewData["Vehicles"] = vehiclesList;

            ViewBag.Vehicles = vehiclesList;

            return View("List");
        }
    }
}
