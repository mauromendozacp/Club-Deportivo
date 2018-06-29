namespace MaritoFormPractice
{
    partial class FormIngFam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngFam));
            this.PanelIngSoc = new System.Windows.Forms.TableLayoutPanel();
            this.IngEdad = new System.Windows.Forms.TextBox();
            this.DescTel = new System.Windows.Forms.Label();
            this.DescEdad = new System.Windows.Forms.Label();
            this.DescCodSoc = new System.Windows.Forms.Label();
            this.DescNomb = new System.Windows.Forms.Label();
            this.IngTel = new System.Windows.Forms.TextBox();
            this.IngCodSoc = new System.Windows.Forms.TextBox();
            this.IngNomb = new System.Windows.Forms.TextBox();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.DescVinc = new System.Windows.Forms.Label();
            this.IngVinc = new System.Windows.Forms.ComboBox();
            this.PanelIngSoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelIngSoc
            // 
            this.PanelIngSoc.ColumnCount = 2;
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.Controls.Add(this.IngEdad, 1, 2);
            this.PanelIngSoc.Controls.Add(this.DescTel, 0, 3);
            this.PanelIngSoc.Controls.Add(this.DescEdad, 0, 2);
            this.PanelIngSoc.Controls.Add(this.DescCodSoc, 0, 0);
            this.PanelIngSoc.Controls.Add(this.DescNomb, 0, 1);
            this.PanelIngSoc.Controls.Add(this.IngTel, 1, 3);
            this.PanelIngSoc.Controls.Add(this.IngCodSoc, 1, 0);
            this.PanelIngSoc.Controls.Add(this.IngNomb, 1, 1);
            this.PanelIngSoc.Controls.Add(this.BotonVolver, 0, 5);
            this.PanelIngSoc.Controls.Add(this.BotonAceptar, 1, 5);
            this.PanelIngSoc.Controls.Add(this.DescVinc, 0, 4);
            this.PanelIngSoc.Controls.Add(this.IngVinc, 1, 4);
            this.PanelIngSoc.Location = new System.Drawing.Point(12, 12);
            this.PanelIngSoc.Name = "PanelIngSoc";
            this.PanelIngSoc.RowCount = 6;
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.Size = new System.Drawing.Size(355, 357);
            this.PanelIngSoc.TabIndex = 1;
            // 
            // IngEdad
            // 
            this.IngEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngEdad.Location = new System.Drawing.Point(195, 134);
            this.IngEdad.Name = "IngEdad";
            this.IngEdad.Size = new System.Drawing.Size(141, 27);
            this.IngEdad.TabIndex = 2;
            this.IngEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngNum_KeyPress);
            // 
            // DescTel
            // 
            this.DescTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescTel.AutoSize = true;
            this.DescTel.Location = new System.Drawing.Point(52, 197);
            this.DescTel.Name = "DescTel";
            this.DescTel.Size = new System.Drawing.Size(72, 19);
            this.DescTel.TabIndex = 1;
            this.DescTel.Text = "Telefono:";
            // 
            // DescEdad
            // 
            this.DescEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescEdad.AutoSize = true;
            this.DescEdad.Location = new System.Drawing.Point(65, 138);
            this.DescEdad.Name = "DescEdad";
            this.DescEdad.Size = new System.Drawing.Size(47, 19);
            this.DescEdad.TabIndex = 8;
            this.DescEdad.Text = "Edad:";
            // 
            // DescCodSoc
            // 
            this.DescCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodSoc.AutoSize = true;
            this.DescCodSoc.Location = new System.Drawing.Point(38, 20);
            this.DescCodSoc.Name = "DescCodSoc";
            this.DescCodSoc.Size = new System.Drawing.Size(101, 19);
            this.DescCodSoc.TabIndex = 2;
            this.DescCodSoc.Text = "Código Socio:";
            // 
            // DescNomb
            // 
            this.DescNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescNomb.AutoSize = true;
            this.DescNomb.Location = new System.Drawing.Point(54, 79);
            this.DescNomb.Name = "DescNomb";
            this.DescNomb.Size = new System.Drawing.Size(69, 19);
            this.DescNomb.TabIndex = 0;
            this.DescNomb.Text = "Nombre:";
            // 
            // IngTel
            // 
            this.IngTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngTel.Location = new System.Drawing.Point(195, 193);
            this.IngTel.Name = "IngTel";
            this.IngTel.Size = new System.Drawing.Size(141, 27);
            this.IngTel.TabIndex = 3;
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.Location = new System.Drawing.Point(194, 16);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(144, 27);
            this.IngCodSoc.TabIndex = 0;
            this.IngCodSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngNum_KeyPress);
            // 
            // IngNomb
            // 
            this.IngNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngNomb.Location = new System.Drawing.Point(195, 75);
            this.IngNomb.Name = "IngNomb";
            this.IngNomb.Size = new System.Drawing.Size(141, 27);
            this.IngNomb.TabIndex = 1;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVolver.Location = new System.Drawing.Point(33, 306);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(110, 40);
            this.BotonVolver.TabIndex = 6;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonAceptar.Location = new System.Drawing.Point(211, 306);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(110, 40);
            this.BotonAceptar.TabIndex = 5;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // DescVinc
            // 
            this.DescVinc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescVinc.AutoSize = true;
            this.DescVinc.Location = new System.Drawing.Point(56, 256);
            this.DescVinc.Name = "DescVinc";
            this.DescVinc.Size = new System.Drawing.Size(64, 19);
            this.DescVinc.TabIndex = 10;
            this.DescVinc.Text = "Vínculo:";
            // 
            // IngVinc
            // 
            this.IngVinc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngVinc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngVinc.FormattingEnabled = true;
            this.IngVinc.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Abuela",
            "Abuelo",
            "Hermano",
            "Hermana",
            "Tío",
            "Tía",
            "Primo",
            "Prima"});
            this.IngVinc.Location = new System.Drawing.Point(205, 255);
            this.IngVinc.Name = "IngVinc";
            this.IngVinc.Size = new System.Drawing.Size(121, 27);
            this.IngVinc.TabIndex = 4;
            // 
            // FormIngFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 381);
            this.ControlBox = false;
            this.Controls.Add(this.PanelIngSoc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIngFam";
            this.Text = "Ingreso Familiar";
            this.PanelIngSoc.ResumeLayout(false);
            this.PanelIngSoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelIngSoc;
        private System.Windows.Forms.Label DescNomb;
        private System.Windows.Forms.Label DescTel;
        private System.Windows.Forms.Label DescCodSoc;
        private System.Windows.Forms.TextBox IngNomb;
        private System.Windows.Forms.TextBox IngTel;
        private System.Windows.Forms.TextBox IngEdad;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label DescEdad;
        private System.Windows.Forms.TextBox IngCodSoc;
        private System.Windows.Forms.Label DescVinc;
        private System.Windows.Forms.ComboBox IngVinc;
    }
}