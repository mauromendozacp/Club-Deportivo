using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class Deporte
    {
        private int codDeporte;
        private string descripcion;
        private int sector;
        private decimal precio;

        public Deporte(int codDeporte, string descripcion, int sector, decimal precio)
        {
            this.codDeporte = codDeporte;
            this.descripcion = descripcion;
            this.sector = sector;
            this.precio = precio;
        }

        public int CodDeporte { get => codDeporte; }
        public string Descripcion { get => descripcion; }
        public int Sector { get => sector; }
        public decimal Precio { get => precio; }
    }
}
