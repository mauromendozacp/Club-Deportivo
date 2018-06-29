using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class Practica
    {
        private int codPractica;
        private int codSocio;
        private int codDeporte;
        private int cantPersona;
        private decimal precio;

        public int CodSocio { get => codSocio; set => codSocio = value; }
        public int CodDeporte { get => codDeporte; set => codDeporte = value; }
        public int CantPersona { get => cantPersona; set => cantPersona = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int CodPractica { get => codPractica; set => codPractica = value; }
    }
}
