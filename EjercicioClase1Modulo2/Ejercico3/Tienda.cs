using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercico3
{
    public class Tienda
    {
        [JsonPropertyName("productos")]
        public List<Producto> productos { get; set; }
    }
}
