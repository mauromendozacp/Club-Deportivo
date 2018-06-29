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
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InsertarDeporte();
        }
        public void InsertarFormulario(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        public void InsertarDeporte()
        {
            Program.ldeporte[0] = new ClubDeportivo.Deporte(123, "Futbol", 1, 150);
            Program.ldeporte[1] = new ClubDeportivo.Deporte(456, "Voley", 2, 125);
            Program.ldeporte[2] = new ClubDeportivo.Deporte(789, "Basket", 3, 120);
            Program.ldeporte[3] = new ClubDeportivo.Deporte(159, "Tenis", 4, 110);
            Program.ldeporte[4] = new ClubDeportivo.Deporte(357, "Ciclismo", 5, 180);
        }

        //Tools

        private void ToolAgregarSocio_Click(object sender, EventArgs e)
        {
            FormIngSoc fis = new FormIngSoc(0);
            fis.MdiParent = this;
            fis.StartPosition = FormStartPosition.CenterScreen;
            fis.Show();
        }

        private void ToolBorrarSocio_Click(object sender, EventArgs e)
        {
            FormBuscSoc fbs = new FormBuscSoc(1, this);
            fbs.MdiParent = this;
            fbs.StartPosition = FormStartPosition.CenterScreen;
            fbs.Show();
        }

        private void ToolModificarSocio_Click(object sender, EventArgs e)
        {
            FormBuscSoc fbs = new FormBuscSoc(2, this);
            InsertarFormulario(fbs);
        }
        

        private void ToolVerSocio_Click(object sender, EventArgs e)
        {
            FormVerDatos fvd = new FormVerDatos(1);
            InsertarFormulario(fvd);
        }

        private void ToolAgregarFamiliar_Click(object sender, EventArgs e)
        {
            FormIngFam fif = new FormIngFam(0);
            InsertarFormulario(fif);
        }

        private void ToolBorrarFamiliar_Click(object sender, EventArgs e)
        {
            FormBuscFam fbf = new FormBuscFam(1, this);
            InsertarFormulario(fbf);
        }

        private void ToolModificarFamiliar_Click(object sender, EventArgs e)
        {
            FormBuscFam fbf = new FormBuscFam(2, this);
            InsertarFormulario(fbf);
        }

        private void ToolVerFamilia_Click(object sender, EventArgs e)
        {
            FormBuscFam fbf = new FormBuscFam(3, this);
            InsertarFormulario(fbf);
        }

        private void ToolVerDeporte_Click(object sender, EventArgs e)
        {
            FormVerDatos fvd = new FormVerDatos(3);
            InsertarFormulario(fvd);
        }

        private void ToolAgregarPractica_Click(object sender, EventArgs e)
        {

        }

        private void ToolBorrarPractica_Click(object sender, EventArgs e)
        {

        }

        private void ToolModificarPractica_Click(object sender, EventArgs e)
        {

        }

        private void ToolVerPractica_Click(object sender, EventArgs e)
        {
            FormVerDatos fvd = new FormVerDatos(4);
            InsertarFormulario(fvd);
        }

        private void ToolVerCuota_Click(object sender, EventArgs e)
        {

        }
    }
}
