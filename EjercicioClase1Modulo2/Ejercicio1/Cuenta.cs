using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio1
{
    public class Cuenta
    {
        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }
        //no entiendo porque no trae la lista de amigos...
        [JsonPropertyName("amigos_usuario")]
        private List<string> Amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool Notificacion { get; set; }
    }
}
