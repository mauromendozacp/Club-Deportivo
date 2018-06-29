using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaritoFormPractice
{
    public partial class FormVerDatos : Form
    {
        int cods;
        public FormVerDatos(int opc)
        {
            InitializeComponent();
            InsertarDatos(opc);
        }
        public FormVerDatos(int opc, int cods)
        {
            InitializeComponent();
            this.cods = cods;
            InsertarDatos(opc);
        }

        public void InsertarDatos(int opc)
        {
            switch (opc)
            {
                case 1:
                    DataView.DataSource = Program.lsocio;
                    break;
                case 2:
                    DataView.DataSource = Program.lsocio[cods].Familiar;
                    break;
                case 3:
                    DataView.DataSource = Program.ldeporte;
                    break;
                case 4:
                    DataView.DataSource = Program.lpractica;
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
