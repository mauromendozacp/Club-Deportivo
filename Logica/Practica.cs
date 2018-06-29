using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Practica
    {
        public int DarCodPractica(List<ClubDeportivo.Practica> lpractica)
        {
            int cod = 123;
            if (lpractica.Count == 0)
            {
                return cod;
            }
            else
            {
                for (int i = 0; i < lpractica.Count; i++)
                {
                    if (lpractica[i].CodPractica == cod)
                    {
                        cod++;
                        i = 0;
                    }
                }
                return cod;
            }
        }
    }
}
