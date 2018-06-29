using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class Socio
    {
        private int codSocio;
        private string nombre;
        private int edad;
        private string telefono;
        private string direccion;
        private List<Familia> familiar;
        
        public struct Familia
        {
            private int codFamiliar;
            private string nombre;
            private int edad;
            private string telefono;
            private string vinculo;

            public int CodFamiliar { get => codFamiliar; set => codFamiliar = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Vinculo { get => vinculo; set => vinculo = value; }
        }
        public int CodSocio { get => codSocio; set => codSocio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Familia> Familiar { get => familiar; set => familiar = value; }
    }
}
