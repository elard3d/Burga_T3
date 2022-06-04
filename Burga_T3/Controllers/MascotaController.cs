using System;
using System.Collections.Generic;
using Burga_T3.Models;
using Burga_T3.Repository;
using Burga_T3.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Burga_T3.Controllers
{
    
    [Authorize]
    public class MascotaController : Controller
    {
        private readonly ICookieAuthService _cookieAuthService;
        private readonly IUsuarioRepository _usuario;
        private readonly IRegistroRepository _registro;
        
        
        public MascotaController(ICookieAuthService _cookieAuthService,
            IUsuarioRepository _usuario,IRegistroRepository _registro) {
            this._cookieAuthService = _cookieAuthService; 
            this._usuario = _usuario; 
            this._registro = _registro; 
         
        }
        
        

        public IActionResult Index()
        {

            ViewBag.registros = _registro.TodosLosRegistros();
            return View();
        }
        
        
        public IActionResult CrearRegistro()
        {
            ViewBag.sexo = Sexo();
            ViewBag.especie = Especie();
            ViewBag.raza = Raza();
            return View();
        }
        public IActionResult CrearRegistroA(Registro registro)
        {
          
            _registro.CrearRegistro(registro);
     
            return RedirectToAction("Index");
        }
        
        public List<String> Sexo()
        {
            List<String> sexo = new List<string>();
            sexo.Add("Masculino");
            sexo.Add("Femenino");
            return sexo;
        }
        
        public List<String> Especie()
        {
            List<String> especie = new List<string>();
            especie.Add("Mamifero");
            especie.Add("Ave");
            especie.Add("Reptil");
            especie.Add("Pez");
            return especie;
        }
        
        public List<String> Raza()
        {
            List<String> raza = new List<string>();
            raza.Add("dalmata");
            raza.Add("doberman");
            raza.Add("tsu tsu");
            raza.Add("pastor aleman");
            return raza;
        }
    }
}