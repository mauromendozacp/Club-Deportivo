using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Socio
    {
        public int DarCodSocio(List<ClubDeportivo.Socio> lsocio)
        {
            int cod = 111;
            if (lsocio.Count == 0)
            {
                return cod;
            }
            else
            {
                for (int i = 0; i < lsocio.Count; i++)
                {
                    if (lsocio[i].CodSocio == cod)
                    {
                        cod++;
                        i = 0;
                    }
                }
                return cod;
            }
        }
        public int DarCodFamiliar(List<ClubDeportivo.Socio.Familia> lfamilia)
        {
            int cod = 11;
            if (lfamilia.Count == 0)
            {
                return cod;
            }
            else
            {
                for (int i = 0; i < lfamilia.Count; i++)
                {
                    if (lfamilia[i].CodFamiliar == cod)
                    {
                        cod++;
                        i = 0;
                    }
                }
                return cod;
            }
        }

        public Boolean ComprobarSocio(int auxcs, List<ClubDeportivo.Socio> lsocio)
        {
            if (lsocio.Count == 0)
            {
                return false;
            }
            foreach (ClubDeportivo.Socio soc in lsocio)
            {
                if (soc.CodSocio == auxcs)
                {
                    return true;
                }
            }
            return false;
        }
        public int ObtenerSocio(int auxcs, List<ClubDeportivo.Socio> lsocio)
        {
            if (lsocio.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < lsocio.Count; i++)
            {
                if (lsocio[i].CodSocio == auxcs)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
