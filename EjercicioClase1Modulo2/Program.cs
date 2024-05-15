//using EjercicioClase1Modulo2.Ejercicio_1;
//using EjercicioClase1Modulo2.Ejercicio_2;
using EjercicioClase1Modulo2.Ejercicio1;
using EjercicioClase1Modulo2.Ejercico3;
using EjercicioClase1Modulo2.Ejercicio2;
using System.Text.Json;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos
            // crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            //ejercicio_1
            var resultado1 = JsonSerializer.Deserialize<Cuenta>(dataEjercicio1);
            var serializado1 = JsonSerializer.Serialize(resultado1);
            Console.WriteLine(serializado1);

            //ejercicio_2
            var resultado2 = JsonSerializer.Deserialize<Videojuego>(dataEjercicio2);
            var serializado2 = JsonSerializer.Serialize(resultado2);
            Console.WriteLine(serializado2);

            //ejercicio_3
            var resultado3 = JsonSerializer.Deserialize<Tienda>(dataEjercicio3);
            var serializado3 = JsonSerializer.Serialize(resultado3);
            Console.WriteLine(serializado3);
        }
    }
}