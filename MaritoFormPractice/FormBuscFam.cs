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
    public partial class FormBuscFam : Form
    {
        MenuPrincipal menu;
        int opc;

        public FormBuscFam(int opc, MenuPrincipal menu)
        {
            InitializeComponent();
            this.opc = opc;
            this.menu = menu;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (IngCodSoc.Text == "")
            {
                MessageBox.Show("Ingrese el código del socio!");
            }
            else
            {
                if(ListFam.SelectedIndex < 2 && opc != 3)
                {
                    MessageBox.Show("Seleccione el familiar!");
                }
                else
                {
                    int auxcs = Convert.ToInt32(IngCodSoc.Text);
                    int posf = ListFam.SelectedIndex - 2;
                    int i = Program.slogic.ObtenerSocio(auxcs, Program.lsocio);
                    if (Program.slogic.ComprobarSocio(auxcs, Program.lsocio))
                    {
                        switch (opc)
                        {
                            case 1:
                                Program.lsocio[i].Familiar.RemoveAt(posf);
                                MessageBox.Show("Familiar Borrado correctamente!");
                                break;
                            case 2:
                                int codf = Program.lsocio[i].Familiar[posf].CodFamiliar;
                                FormIngFam fis = new FormIngFam(codf);
                                fis.MdiParent = menu;
                                fis.StartPosition = FormStartPosition.CenterScreen;
                                fis.Show();
                                break;
                            case 3:
                                FormVerDatos fvd = new FormVerDatos(2, i);
                                fvd.MdiParent = menu;
                                fvd.StartPosition = FormStartPosition.CenterScreen;
                                fvd.Show();
                                break;
                            default:
                                this.Close();
                                break;
                        }
                        IngCodSoc.ResetText();
                        ListFam.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Código socio desconocido!");
                    }
                }
            }
        }

        public void InsertarInfoFamiliar(int i)
        {
            ListFam.Items.Clear();
            ListFam.Items.Add("Familiares:");
            ListFam.Items.Add("");
            foreach (ClubDeportivo.Socio.Familia fam in Program.lsocio[i].Familiar)
            {
                ListFam.Items.Add(fam.Vinculo + ": " + fam.Nombre);
            }
        }

        private void IngCodSoc_TextChanged(object sender, EventArgs e)
        {
            if (IngCodSoc.Text != "")
            {
                int auxcs = Convert.ToInt32(IngCodSoc.Text);
                int i = Program.slogic.ObtenerSocio(auxcs, Program.lsocio);
                if (i < 0)
                {
                    ListFam.Items.Clear();
                }
                else
                {
                    InsertarInfoFamiliar(i);
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
