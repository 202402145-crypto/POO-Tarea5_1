using System;

namespace DirectorioEmp.Clases
{
    public class Cargo
    {
        // Campos privados
        private int _numeroCargo;
        private string _titulo;
        private DateTime _fechaInicio;
        private DateTime _fechaFinal;
        private bool _empleoActual;
        private string _empresa;
        private decimal _salario;
        private string _detalles;

        // Constructores
        public Cargo() { }

        public Cargo(
            int numeroCargo,
            string titulo,
            DateTime fechaInicio,
            DateTime fechaFinal,
            bool empleoActual,
            string empresa,
            decimal salario,
            string detalles)
        {
            _numeroCargo = numeroCargo;
            _titulo = titulo;
            _fechaInicio = fechaInicio;
            _fechaFinal = fechaFinal;
            _empleoActual = empleoActual;
            _empresa = empresa;
            _salario = salario;
            _detalles = detalles;
        }

        // Métodos get/set
        public int NumeroCargo { get => _numeroCargo; set => _numeroCargo = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public bool EmpleoActual { get => _empleoActual; set => _empleoActual = value; }
        public string Empresa { get => _empresa; set => _empresa = value; }
        public decimal Salario { get => _salario; set => _salario = value; }
        public string Detalles { get => _detalles; set => _detalles = value; }

        public override string ToString()
            => $"{NumeroCargo}: {Titulo} @ {Empresa} {(EmpleoActual ? "(Actual)" : "")}";
    }
}