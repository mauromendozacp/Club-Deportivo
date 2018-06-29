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
    public partial class FormIngFam : Form
    {
        int cod;
        public FormIngFam(int cod)
        {
            InitializeComponent();
            this.cod = cod;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (IngCodSoc.Text == "" || IngNomb.Text == "" || IngEdad.Text == "" || IngTel.Text == "" || IngVinc.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                IngresoFamiliar();
                LimpiarCampos();
            }
        }

        public void IngresoFamiliar()
        {
            int auxcs = Convert.ToInt32(IngCodSoc.Text);
            int i = Program.slogic.ObtenerSocio(auxcs, Program.lsocio);
            if (i < 0)
            {
                MessageBox.Show("Código Socio desconocido!");
            }
            else
            {
                if (cod > 0)
                {
                    foreach (ClubDeportivo.Socio.Familia fam in Program.lsocio[i].Familiar)
                    {
                        if (fam.CodFamiliar == cod)
                        {

                        }
                    }
                    MessageBox.Show("Familiar Modificado correctamente!");
                    this.Close();
                }
                else
                {
                    ClubDeportivo.Socio.Familia auxf = new ClubDeportivo.Socio.Familia();
                    auxf.CodFamiliar = Program.slogic.DarCodFamiliar(Program.lsocio[i].Familiar);
                    auxf.Nombre = IngNomb.Text;
                    auxf.Edad = Convert.ToInt32(IngEdad.Text);
                    auxf.Telefono = IngTel.Text;
                    auxf.Vinculo = IngVinc.Text;
                    Program.lsocio[i].Familiar.Add(auxf);
                    MessageBox.Show("Familiar Agregado correctamente!");
                }
            }
        }

        public void LimpiarCampos()
        {
            IngCodSoc.ResetText();
            IngNomb.ResetText();
            IngEdad.ResetText();
            IngTel.ResetText();
            IngCodSoc.Focus();
        }

        private void IngNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
