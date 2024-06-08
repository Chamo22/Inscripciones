﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inscripcioness.Models;

namespace Inscripcioness.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly InscripcionesContext _context;

        public InscripcionesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: Inscripciones
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var inscripcionesContext = _context.Inscripciones.Include(i => i.Alumno).Include(i => i.Carrera);
=======
            var inscripcionesContext = _context.Inscripciones.Include(i => i.Alumno);
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
            return View(await inscripcionesContext.ToListAsync());
        }

        // GET: Inscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripciones
                .Include(i => i.Alumno)
<<<<<<< HEAD
                .Include(i => i.Carrera)
=======
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // GET: Inscripciones/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["AlumnoID"] = new SelectList(_context.alumnos, "Id", "ApellidoNombre");
            ViewData["CarreraId"] = new SelectList(_context.carreras, "Id", "Nombre");
=======
            ViewData["AlumnoID"] = new SelectList(_context.alumnos, "Id", "Id");
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
            return View();
        }

        // POST: Inscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,AlumnoID,CarreraId")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscripcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoID"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoID);
<<<<<<< HEAD
            ViewData["CarreraId"] = new SelectList(_context.carreras, "Id", "Id", inscripcion.CarreraId);
=======
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
            return View(inscripcion);
        }

        // GET: Inscripciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripciones.FindAsync(id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            ViewData["AlumnoID"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoID);
<<<<<<< HEAD
            ViewData["CarreraId"] = new SelectList(_context.carreras, "Id", "Id", inscripcion.CarreraId);
=======
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
            return View(inscripcion);
        }

        // POST: Inscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,AlumnoID,CarreraId")] Inscripcion inscripcion)
        {
            if (id != inscripcion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscripcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscripcionExists(inscripcion.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoID"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoID);
<<<<<<< HEAD
            ViewData["CarreraId"] = new SelectList(_context.carreras, "Id", "Id", inscripcion.CarreraId);
=======
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
            return View(inscripcion);
        }

        // GET: Inscripciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripciones
                .Include(i => i.Alumno)
<<<<<<< HEAD
                .Include(i => i.Carrera)
=======
>>>>>>> 0fcae931572882bbe34a601d55c11c335e90a28d
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // POST: Inscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inscripcion = await _context.Inscripciones.FindAsync(id);
            if (inscripcion != null)
            {
                _context.Inscripciones.Remove(inscripcion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InscripcionExists(int id)
        {
            return _context.Inscripciones.Any(e => e.Id == id);
        }
    }
}
