using System;
using System.Collections.Generic;

namespace DirectorioEmp.Clases
{
    public class Persona
    {
        // Campos privados
        private string _numeroID;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private string _telefono;
        private string _celular;
        private string _pais;
        private string _ciudad;
        private string _direccion;
        private string _profesion;

        // Colecciones requeridas
        private List<Grado> _grados;
        private List<Cargo> _cargos;

        // Constructores
        public Persona()
        {
            _grados = new List<Grado>();
            _cargos = new List<Cargo>();
        }

        public Persona(
            string numeroID,
            string nombres,
            string apellidos,
            DateTime fechaNacimiento,
            string telefono,
            string celular,
            string pais,
            string ciudad,
            string direccion,
            string profesion,
            List<Grado> grados = null,
            List<Cargo> cargos = null)
            : this()
        {
            _numeroID = numeroID;
            _nombres = nombres;
            _apellidos = apellidos;
            _fechaNacimiento = fechaNacimiento;
            _telefono = telefono;
            _celular = celular;
            _pais = pais;
            _ciudad = ciudad;
            _direccion = direccion;
            _profesion = profesion;

            if (grados != null) _grados = grados;
            if (cargos != null) _cargos = cargos;
        }

        // Métodos get/set
        public string NumeroID { get => _numeroID; set => _numeroID = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Profesion { get => _profesion; set => _profesion = value; }

        public List<Grado> Grados { get => _grados; }
        public List<Cargo> Cargos { get => _cargos; }

        // Métodos de conveniencia
        public void AgregarGrado(Grado g) => _grados.Add(g);
        public void AgregarCargo(Cargo c) => _cargos.Add(c);

        public override string ToString()
            => $"{Nombres} {Apellidos} - {Profesion} ({Pais}, {Ciudad})";
    }
}