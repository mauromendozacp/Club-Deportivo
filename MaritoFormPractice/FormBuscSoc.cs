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
    public partial class FormBuscSoc : Form
    {
        MenuPrincipal menu;
        int opc;
        public FormBuscSoc(int opc, MenuPrincipal auxmp)
        {
            InitializeComponent();
            this.opc = opc;
            this.menu = auxmp;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (IngCodSoc.Text == "")
            {
                MessageBox.Show("Ingrese el código del socio!");
            }
            else
            {
                int auxcs = Convert.ToInt32(IngCodSoc.Text);
                int i = Program.slogic.ObtenerSocio(auxcs, Program.lsocio);
                if (Program.slogic.ComprobarSocio(auxcs, Program.lsocio))
                {
                    switch (opc)
                    {
                        case 1:
                            Program.lsocio.RemoveAt(i);
                            MessageBox.Show("Socio Borrado correctamente!");
                            break;
                        case 2:
                            FormIngSoc fis = new FormIngSoc(auxcs);
                            fis.MdiParent = menu;
                            fis.StartPosition = FormStartPosition.CenterScreen;
                            fis.Show();
                            break;
                        default:
                            this.Close();
                            break;
                    }
                    IngCodSoc.ResetText();
                    ListSoc.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Código socio desconocido!");
                }
            }
        }

        public void InsertarInfoSocio(int i)
        {
            ListSoc.Items.Clear();
            ListSoc.Items.Add("Socio:");
            ListSoc.Items.Add("");
            ListSoc.Items.Add("Nombre: " + Program.lsocio[i].Nombre);
            ListSoc.Items.Add("Telefono: " + Program.lsocio[i].Telefono);
            ListSoc.Items.Add("Dirección: " + Program.lsocio[i].Direccion);
        }

        private void IngCodSoc_TextChanged(object sender, EventArgs e)
        {
            if (IngCodSoc.Text != "")
            {
                int auxcs = Convert.ToInt32(IngCodSoc.Text);
                int i = Program.slogic.ObtenerSocio(auxcs, Program.lsocio);
                if (i < 0)
                {
                    ListSoc.Items.Clear();
                }
                else
                {
                    InsertarInfoSocio(i);
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngCodSoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
