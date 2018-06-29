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
    public partial class FormIngSoc : Form
    {
        int cod;
        public FormIngSoc(int cod)
        {
            InitializeComponent();
            this.cod = cod;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (IngNomb.Text == "" || IngEdad.Text == "" || IngTel.Text == "" || IngDir.Text == "")
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                IngresoSocio();
                LimpiarCampos();
            }
        }

        public void IngresoSocio()
        {
            if (cod > 0)
            {
                foreach (ClubDeportivo.Socio soc in Program.lsocio)
                {
                    if (soc.CodSocio == cod)
                    {
                        soc.Nombre = IngNomb.Text;
                        soc.Edad = Convert.ToInt32(IngEdad.Text);
                        soc.Telefono = IngTel.Text;
                        soc.Direccion = IngDir.Text;
                        break;
                    }
                }
                MessageBox.Show("Socio Modificado correctamente!");
                this.Close();
            }
            else
            {
                ClubDeportivo.Socio auxs = new ClubDeportivo.Socio();
                auxs.CodSocio = Program.slogic.DarCodSocio(Program.lsocio);
                auxs.Nombre = IngNomb.Text;
                auxs.Edad = Convert.ToInt32(IngEdad.Text);
                auxs.Telefono = IngTel.Text;
                auxs.Direccion = IngDir.Text;
                auxs.Familiar = new List<ClubDeportivo.Socio.Familia>();

                Program.lsocio.Add(auxs);
                MessageBox.Show("Socio Agregado correctamente!");
            }
        }
        public void LimpiarCampos()
        {
            IngNomb.ResetText();
            IngEdad.ResetText();
            IngTel.ResetText();
            IngDir.ResetText();
            IngNomb.Focus();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngEdad_KeyPress(object sender, KeyPressEventArgs e)
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
