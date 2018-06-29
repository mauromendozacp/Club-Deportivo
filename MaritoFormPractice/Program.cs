using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaritoFormPractice
{
    static class Program
    {
        static public List<ClubDeportivo.Socio> lsocio = new List<ClubDeportivo.Socio>();
        static public List<ClubDeportivo.Practica> lpractica = new List<ClubDeportivo.Practica>();
        static public ClubDeportivo.Deporte[] ldeporte = new ClubDeportivo.Deporte[5];

        static public Logica.Socio slogic = new Logica.Socio();
        static public Logica.Deporte dlogic = new Logica.Deporte();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
}
