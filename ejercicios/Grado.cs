using System;

namespace DirectorioEmp.Clases
{
    public class Grado
    {
        // Campos privados
        private int _numeroGrado;
        private string _nivelEducativo;
        private string _institucion;
        private string _nombreTitulo;
        private DateTime _fechaInicio;
        private DateTime _fechaFinal;
        private string _tipoGrado;
        private DateTime _fechaExpiracion;
        private string _pais;

        // Constructores
        public Grado() { }

        public Grado(
            int numeroGrado,
            string nivelEducativo,
            string institucion,
            string nombreTitulo,
            DateTime fechaInicio,
            DateTime fechaFinal,
            string tipoGrado,
            DateTime fechaExpiracion,
            string pais)
        {
            _numeroGrado = numeroGrado;
            _nivelEducativo = nivelEducativo;
            _institucion = institucion;
            _nombreTitulo = nombreTitulo;
            _fechaInicio = fechaInicio;
            _fechaFinal = fechaFinal;
            _tipoGrado = tipoGrado;
            _fechaExpiracion = fechaExpiracion;
            _pais = pais;
        }

        // Métodos get/set (propiedades con backing field)
        public int NumeroGrado { get => _numeroGrado; set => _numeroGrado = value; }
        public string NivelEducativo { get => _nivelEducativo; set => _nivelEducativo = value; }
        public string Institucion { get => _institucion; set => _institucion = value; }
        public string NombreTitulo { get => _nombreTitulo; set => _nombreTitulo = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public string TipoGrado { get => _tipoGrado; set => _tipoGrado = value; }
        public DateTime FechaExpiracion { get => _fechaExpiracion; set => _fechaExpiracion = value; }
        public string Pais { get => _pais; set => _pais = value; }

        public override string ToString()
            => $"{NumeroGrado}: {NivelEducativo} - {NombreTitulo} ({Institucion})";
    }
}