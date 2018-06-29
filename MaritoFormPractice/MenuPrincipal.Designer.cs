namespace MaritoFormPractice
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAgregarSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBorrarSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolModificarSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAgregarFamiliar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBorrarFamiliar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolModificarFamiliar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.deporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerDeporte = new System.Windows.Forms.ToolStripMenuItem();
            this.practicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAgregarPractica = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBorrarPractica = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolModificarPractica = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerPractica = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotaMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerCuota = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socioToolStripMenuItem,
            this.familiaToolStripMenuItem,
            this.deporteToolStripMenuItem,
            this.practicaToolStripMenuItem,
            this.cuotaMensualToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(689, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAgregarSocio,
            this.ToolBorrarSocio,
            this.ToolModificarSocio,
            this.ToolVerSocio});
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.socioToolStripMenuItem.Text = "Socio";
            // 
            // ToolAgregarSocio
            // 
            this.ToolAgregarSocio.Name = "ToolAgregarSocio";
            this.ToolAgregarSocio.Size = new System.Drawing.Size(125, 22);
            this.ToolAgregarSocio.Text = "Agregar";
            this.ToolAgregarSocio.Click += new System.EventHandler(this.ToolAgregarSocio_Click);
            // 
            // ToolBorrarSocio
            // 
            this.ToolBorrarSocio.Name = "ToolBorrarSocio";
            this.ToolBorrarSocio.Size = new System.Drawing.Size(125, 22);
            this.ToolBorrarSocio.Text = "Borrar";
            this.ToolBorrarSocio.Click += new System.EventHandler(this.ToolBorrarSocio_Click);
            // 
            // ToolModificarSocio
            // 
            this.ToolModificarSocio.Name = "ToolModificarSocio";
            this.ToolModificarSocio.Size = new System.Drawing.Size(125, 22);
            this.ToolModificarSocio.Text = "Modificar";
            this.ToolModificarSocio.Click += new System.EventHandler(this.ToolModificarSocio_Click);
            // 
            // ToolVerSocio
            // 
            this.ToolVerSocio.Name = "ToolVerSocio";
            this.ToolVerSocio.Size = new System.Drawing.Size(125, 22);
            this.ToolVerSocio.Text = "Ver Socio";
            this.ToolVerSocio.Click += new System.EventHandler(this.ToolVerSocio_Click);
            // 
            // familiaToolStripMenuItem
            // 
            this.familiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAgregarFamiliar,
            this.ToolBorrarFamiliar,
            this.ToolModificarFamiliar,
            this.ToolVerFamilia});
            this.familiaToolStripMenuItem.Name = "familiaToolStripMenuItem";
            this.familiaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familiaToolStripMenuItem.Text = "Familia";
            // 
            // ToolAgregarFamiliar
            // 
            this.ToolAgregarFamiliar.Name = "ToolAgregarFamiliar";
            this.ToolAgregarFamiliar.Size = new System.Drawing.Size(131, 22);
            this.ToolAgregarFamiliar.Text = "Agregar";
            this.ToolAgregarFamiliar.Click += new System.EventHandler(this.ToolAgregarFamiliar_Click);
            // 
            // ToolBorrarFamiliar
            // 
            this.ToolBorrarFamiliar.Name = "ToolBorrarFamiliar";
            this.ToolBorrarFamiliar.Size = new System.Drawing.Size(131, 22);
            this.ToolBorrarFamiliar.Text = "Borrar";
            this.ToolBorrarFamiliar.Click += new System.EventHandler(this.ToolBorrarFamiliar_Click);
            // 
            // ToolModificarFamiliar
            // 
            this.ToolModificarFamiliar.Name = "ToolModificarFamiliar";
            this.ToolModificarFamiliar.Size = new System.Drawing.Size(131, 22);
            this.ToolModificarFamiliar.Text = "Modificar";
            this.ToolModificarFamiliar.Click += new System.EventHandler(this.ToolModificarFamiliar_Click);
            // 
            // ToolVerFamilia
            // 
            this.ToolVerFamilia.Name = "ToolVerFamilia";
            this.ToolVerFamilia.Size = new System.Drawing.Size(131, 22);
            this.ToolVerFamilia.Text = "Ver Familia";
            this.ToolVerFamilia.Click += new System.EventHandler(this.ToolVerFamilia_Click);
            // 
            // deporteToolStripMenuItem
            // 
            this.deporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerDeporte});
            this.deporteToolStripMenuItem.Name = "deporteToolStripMenuItem";
            this.deporteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deporteToolStripMenuItem.Text = "Deporte";
            // 
            // ToolVerDeporte
            // 
            this.ToolVerDeporte.Name = "ToolVerDeporte";
            this.ToolVerDeporte.Size = new System.Drawing.Size(135, 22);
            this.ToolVerDeporte.Text = "Ver Deporte";
            this.ToolVerDeporte.Click += new System.EventHandler(this.ToolVerDeporte_Click);
            // 
            // practicaToolStripMenuItem
            // 
            this.practicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAgregarPractica,
            this.ToolBorrarPractica,
            this.ToolModificarPractica,
            this.ToolVerPractica});
            this.practicaToolStripMenuItem.Name = "practicaToolStripMenuItem";
            this.practicaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.practicaToolStripMenuItem.Text = "Practica";
            // 
            // ToolAgregarPractica
            // 
            this.ToolAgregarPractica.Name = "ToolAgregarPractica";
            this.ToolAgregarPractica.Size = new System.Drawing.Size(180, 22);
            this.ToolAgregarPractica.Text = "Agregar";
            this.ToolAgregarPractica.Click += new System.EventHandler(this.ToolAgregarPractica_Click);
            // 
            // ToolBorrarPractica
            // 
            this.ToolBorrarPractica.Name = "ToolBorrarPractica";
            this.ToolBorrarPractica.Size = new System.Drawing.Size(180, 22);
            this.ToolBorrarPractica.Text = "Borrar";
            this.ToolBorrarPractica.Click += new System.EventHandler(this.ToolBorrarPractica_Click);
            // 
            // ToolModificarPractica
            // 
            this.ToolModificarPractica.Name = "ToolModificarPractica";
            this.ToolModificarPractica.Size = new System.Drawing.Size(180, 22);
            this.ToolModificarPractica.Text = "Modificar";
            this.ToolModificarPractica.Click += new System.EventHandler(this.ToolModificarPractica_Click);
            // 
            // ToolVerPractica
            // 
            this.ToolVerPractica.Name = "ToolVerPractica";
            this.ToolVerPractica.Size = new System.Drawing.Size(180, 22);
            this.ToolVerPractica.Text = "Ver Practica";
            this.ToolVerPractica.Click += new System.EventHandler(this.ToolVerPractica_Click);
            // 
            // cuotaMensualToolStripMenuItem
            // 
            this.cuotaMensualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerCuota});
            this.cuotaMensualToolStripMenuItem.Name = "cuotaMensualToolStripMenuItem";
            this.cuotaMensualToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.cuotaMensualToolStripMenuItem.Text = "Cuota Mensual";
            // 
            // ToolVerCuota
            // 
            this.ToolVerCuota.Name = "ToolVerCuota";
            this.ToolVerCuota.Size = new System.Drawing.Size(125, 22);
            this.ToolVerCuota.Text = "Ver Cuota";
            this.ToolVerCuota.Click += new System.EventHandler(this.ToolVerCuota_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 505);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(689, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(253, 26);
            this.toolStripStatusLabel1.Text = "PROYECTO EN DESARROLLO";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 536);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotaMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolAgregarSocio;
        private System.Windows.Forms.ToolStripMenuItem ToolBorrarSocio;
        private System.Windows.Forms.ToolStripMenuItem ToolModificarSocio;
        private System.Windows.Forms.ToolStripMenuItem ToolVerSocio;
        private System.Windows.Forms.ToolStripMenuItem ToolAgregarFamiliar;
        private System.Windows.Forms.ToolStripMenuItem ToolBorrarFamiliar;
        private System.Windows.Forms.ToolStripMenuItem ToolModificarFamiliar;
        private System.Windows.Forms.ToolStripMenuItem ToolVerFamilia;
        private System.Windows.Forms.ToolStripMenuItem ToolVerDeporte;
        private System.Windows.Forms.ToolStripMenuItem ToolAgregarPractica;
        private System.Windows.Forms.ToolStripMenuItem ToolBorrarPractica;
        private System.Windows.Forms.ToolStripMenuItem ToolModificarPractica;
        private System.Windows.Forms.ToolStripMenuItem ToolVerPractica;
        private System.Windows.Forms.ToolStripMenuItem ToolVerCuota;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}



