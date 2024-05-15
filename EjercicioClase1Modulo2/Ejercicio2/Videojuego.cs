using EjercicioClase1Modulo2.Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static EjercicioClase1Modulo2.Ejercicio2.Estadistica;

namespace EjercicioClase1Modulo2.Ejercicio2
{
    public class Videojuego
    {
        [JsonPropertyName("estadistica")]
        public List<Estadistica> estadisticas { get; set; }
    }
}
