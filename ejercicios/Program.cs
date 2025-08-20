using System;
using DirectorioEmp.Clases;
using System.Collections.Generic;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear grados
            var grado1 = new Grado(
                numeroGrado: 1,
                nivelEducativo: "Licenciatura",
                institucion: "UNAH",
                nombreTitulo: "Ing. Sistemas",
                fechaInicio: new DateTime(2016, 2, 1),
                fechaFinal: new DateTime(2020, 11, 30),
                tipoGrado: "Universitario",
                fechaExpiracion: new DateTime(9999, 12, 31),
                pais: "Honduras"
            );

            // Crear cargos
            var cargo1 = new Cargo(
                numeroCargo: 1,
                titulo: "Analista de Sistemas",
                fechaInicio: new DateTime(2021, 1, 15),
                fechaFinal: new DateTime(2023, 6, 30),
                empleoActual: false,
                empresa: "TechHN",
                salario: 28000m,
                detalles: "Soporte y desarrollo interno."
            );

            var cargo2 = new Cargo(
                numeroCargo: 2,
                titulo: "Desarrollador .NET",
                fechaInicio: new DateTime(2023, 7, 1),
                fechaFinal: new DateTime(9999, 12, 31),
                empleoActual: true,
                empresa: "Apps Centro",
                salario: 35000m,
                detalles: "Backend y APIs."
            );

            // Crear persona y asociar colecciones
            var persona = new Persona(
                numeroID: "0801-1990-12345",
                nombres: "Ana",
                apellidos: "López",
                fechaNacimiento: new DateTime(1990, 5, 12),
                telefono: "2234-5678",
                celular: "9999-8888",
                pais: "Honduras",
                ciudad: "Tegucigalpa",
                direccion: "Col. Kennedy",
                profesion: "Ingeniera en Sistemas",
                grados: new List<Grado> { grado1 },
                cargos: new List<Cargo> { cargo1, cargo2 }
            );

            // Salida de prueba
            Console.WriteLine(persona);
            Console.WriteLine("Grados:");
            foreach (var g in persona.Grados) Console.WriteLine($"  - {g}");
            Console.WriteLine("Cargos:");
            foreach (var c in persona.Cargos) Console.WriteLine($"  - {c}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}