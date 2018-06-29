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
    public partial class FormIngPrac : Form
    {
        int cod;
        public FormIngPrac(int cod)
        {
            InitializeComponent();
            InsertarDeporte();
            this.cod = cod;
        }
        public void InsertarDeporte()
        {
            foreach (ClubDeportivo.Deporte dep in Program.ldeporte)
            {
                IngDep.Items.Add(dep.Descripcion);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (IngCodSoc.Text == "" || IngDep.SelectedIndex < 0 || IngCantPers.Text == "")
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                IngresoPractica();
                LimpiarCampos();
            }
        }
        public void IngresoPractica()
        {
            int auxcs = Convert.ToInt32(IngCodSoc.Text);
            if(Program.slogic.ComprobarSocio(auxcs, Program.lsocio))
            {
                string auxdd = IngDep.Text;
                int i = Program.dlogic.ObtenerDeporte(auxdd, Program.ldeporte);
                if (i >= 0)
                {
                    if(cod > 0)
                    {
                        
                    }
                    else
                    {
                        ClubDeportivo.Practica prac = new ClubDeportivo.Practica();
                        prac.CodSocio = auxcs;
                        prac.CodDeporte = Program.ldeporte[i].CodDeporte;
                        prac.CantPersona = Convert.ToInt32(IngCantPers.Text);
                        prac.Precio = (Program.ldeporte[i].Precio * Convert.ToInt32(IngCantPers.Text));

                        Program.lpractica.Add(prac);
                        MessageBox.Show("Practica agregada correctamente!");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Código socio desconocido!");
            }
        }
        public void LimpiarCampos()
        {
            IngCodSoc.ResetText();
            IngCantPers.ResetText();
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
    }
}
