using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Deporte
    {
        public int ObtenerDeporte(string desc, ClubDeportivo.Deporte[] ldep)
        {
            for (int i = 0; i < ldep.Length; i++)
            {
                if (ldep[i].Descripcion == desc)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
