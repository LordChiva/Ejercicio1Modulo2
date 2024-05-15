using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercico3
{
    public class Producto
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("existencias")]
        public int Existencia { get; set; }

        [JsonPropertyName("descuento_disponible")]
        public bool Descuento { get; set; }

        [JsonPropertyName("etiquetas")]
        public List<string> etiquetas { get; set; }

        [JsonPropertyName("detalles")]
        public List<Detalles> detalles { get; set; }

        public class Detalles
        {
            [JsonPropertyName("peso")]
            public int Peso { get; set; }

            [JsonPropertyName("dimensiones")]
            public List<Dimension> dimensiones { get; set; }

            public class Dimension
            {
                [JsonPropertyName("alto")]
                public int Alto { get; set; }

                [JsonPropertyName("ancho")]
                public int Ancho { get; set; }

                [JsonPropertyName("profundidad")]
                public int Profundidad { get; set; }
            }
        }
    }
}
