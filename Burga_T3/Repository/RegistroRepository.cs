using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Burga_T3.ConexionDB;
using Burga_T3.Models;
using Burga_T3.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Burga_T3.Repository
{
 
    public interface IRegistroRepository
    {
        public List<Registro> TodosLosRegistros();

        public void CrearRegistro(Registro registro);
       

    }
    public class RegistroRepository : IRegistroRepository
    {
        private T3Context _context;

        
        public RegistroRepository(T3Context context)
        {
            _context = context;
         
        }


        public List<Registro> TodosLosRegistros()
        {
            return _context.Registros.ToList();
        }

        public void CrearRegistro(Registro registro)
        {
            Registro nuevo = new Registro();
            nuevo.Especie = registro.Especie;
            nuevo.fechaRegistro = DateTime.Now;
            nuevo.Raza = registro.Raza;
            nuevo.Sexo = registro.Sexo;
            nuevo.Tamano = registro.Tamano;
            nuevo.DatosParticulares = registro.DatosParticulares;
            nuevo.DireccionDueno = registro.DireccionDueno;
            nuevo.FechaNacimiento = registro.FechaNacimiento;
            nuevo.NombreDueno = registro.NombreDueno;
            nuevo.NombreMascota = registro.NombreMascota;
            nuevo.Telefono = registro.Telefono;
            nuevo.Mail = registro.Mail;
            _context.Registros.Add(nuevo);
            _context.SaveChanges();


        }
  
    }
}

