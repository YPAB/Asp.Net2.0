using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdeFutbol.Entidades;

namespace MVC.Controllers
{
    public class PartidoController : Controller
    {
        // GET: Partido
        public ActionResult Index()
        {
            return View();
        }

        // GET: Partido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Partido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partido/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Partido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Partido/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Partido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Partido/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ResultadoPartido()
        {
            // creamos la clase Partidos del tipo List que nos va almacernar todos los partidos(lista de objetos)
            List<Partido> Partidos = new List<Partido>(); 


            //Instanciamos los distintos Equipos
            Equipo Equipo1 = new Equipo
            {
                EquipoId = 1,
                Nombre = "Argentina"
            };

            Equipo Equipo2 = new Equipo
            {
                EquipoId = 2,
                Nombre = "Nigeria"
            };

            Equipo Equipo3 = new Equipo
            {
                EquipoId = 3,
                Nombre = "Mexico"
            };

            Equipo Equipo4 = new Equipo
            {
                EquipoId = 4,
                Nombre = "Alemania"
            };

            Equipo Equipo5 = new Equipo
            {
                EquipoId = 5,
                Nombre = "Portugal"
            };

            Equipo Equipo6 = new Equipo
            {
                EquipoId = 6,
                Nombre = "España"
            };
            Equipo Equipo7 = new Equipo
            {
                EquipoId = 7,
                Nombre = "Brasil"
            };

            Equipo Equipo8 = new Equipo
            {
                EquipoId = 8,
                Nombre = "Serbia "
            };
            Equipo Equipo9 = new Equipo
            {
                EquipoId = 9,
                Nombre = "Uruguay"
            };

            Equipo Equipo10 = new Equipo
            {
                EquipoId = 10,
                Nombre = "Rusia"
            };

            Equipo Equipo11 = new Equipo
            {
                EquipoId = 11,
                Nombre = "Inglaterra"
            };

            Equipo Equipo12 = new Equipo
            {
                EquipoId = 12,
                Nombre = "Panama"
            };
            Equipo Equipo13 = new Equipo
            {
                EquipoId = 13,
                Nombre = "Japon"
            };

            Equipo Equipo14 = new Equipo
            {
                EquipoId = 14,
                Nombre = "Senegal"
            };

            //instanciamos los distintos partidos

            Partido partido = new Partido
            {
                EquipoLocal = Equipo1,
                EquipoVisitante = Equipo2,
                GolesLocal = 2,
                GolesVisitante = 1
            };

            Partido partido1 = new Partido
            {
                EquipoLocal = Equipo3,
                EquipoVisitante = Equipo4,
                GolesLocal = 1,
                GolesVisitante = 0
            };

            Partido partido2 = new Partido
            {
                EquipoLocal = Equipo5,
                EquipoVisitante = Equipo6,
                GolesLocal = 3,
                GolesVisitante = 3
            };
            Partido partido3 = new Partido
            {
                EquipoLocal = Equipo7,
                EquipoVisitante = Equipo8,
                GolesLocal = 2,
                GolesVisitante = 0
            };
            Partido partido4 = new Partido
            {
                EquipoLocal = Equipo9,
                EquipoVisitante = Equipo10,
                GolesLocal = 2,
                GolesVisitante = 0
            };
            Partido partido5 = new Partido
            {
                EquipoLocal = Equipo11,
                EquipoVisitante = Equipo12,
                GolesLocal = 6,
                GolesVisitante = 1
            };
            Partido partido6 = new Partido
            {
                EquipoLocal = Equipo13,
                EquipoVisitante = Equipo14,
                GolesLocal = 2,
                GolesVisitante = 2
            };


            ViewBag.MostrarResultado = false;

            // recibe como parametro los distintos partidos y los va almacenando en la lista de Partidos
            Partidos.Add(partido);
            Partidos.Add(partido1);
            Partidos.Add(partido2);
            Partidos.Add(partido3);
            Partidos.Add(partido4);
            Partidos.Add(partido5);
            Partidos.Add(partido6);

            return View(Partidos);
           

        }



        }
    }
