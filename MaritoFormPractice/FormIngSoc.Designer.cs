namespace MaritoFormPractice
{
    partial class FormIngSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngSoc));
            this.PanelIngSoc = new System.Windows.Forms.TableLayoutPanel();
            this.DescNomb = new System.Windows.Forms.Label();
            this.IngNomb = new System.Windows.Forms.TextBox();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.DescDir = new System.Windows.Forms.Label();
            this.IngDir = new System.Windows.Forms.TextBox();
            this.IngTel = new System.Windows.Forms.TextBox();
            this.DescTel = new System.Windows.Forms.Label();
            this.DescEdad = new System.Windows.Forms.Label();
            this.IngEdad = new System.Windows.Forms.TextBox();
            this.PanelIngSoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelIngSoc
            // 
            this.PanelIngSoc.ColumnCount = 2;
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.Controls.Add(this.DescNomb, 0, 0);
            this.PanelIngSoc.Controls.Add(this.IngNomb, 1, 0);
            this.PanelIngSoc.Controls.Add(this.BotonVolver, 0, 4);
            this.PanelIngSoc.Controls.Add(this.BotonAceptar, 1, 4);
            this.PanelIngSoc.Controls.Add(this.DescDir, 0, 3);
            this.PanelIngSoc.Controls.Add(this.IngDir, 1, 3);
            this.PanelIngSoc.Controls.Add(this.IngTel, 1, 2);
            this.PanelIngSoc.Controls.Add(this.DescTel, 0, 2);
            this.PanelIngSoc.Controls.Add(this.DescEdad, 0, 1);
            this.PanelIngSoc.Controls.Add(this.IngEdad, 1, 1);
            this.PanelIngSoc.Location = new System.Drawing.Point(12, 12);
            this.PanelIngSoc.Name = "PanelIngSoc";
            this.PanelIngSoc.RowCount = 5;
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelIngSoc.Size = new System.Drawing.Size(355, 357);
            this.PanelIngSoc.TabIndex = 0;
            // 
            // DescNomb
            // 
            this.DescNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescNomb.AutoSize = true;
            this.DescNomb.Location = new System.Drawing.Point(54, 26);
            this.DescNomb.Name = "DescNomb";
            this.DescNomb.Size = new System.Drawing.Size(69, 19);
            this.DescNomb.TabIndex = 0;
            this.DescNomb.Text = "Nombre:";
            // 
            // IngNomb
            // 
            this.IngNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngNomb.Location = new System.Drawing.Point(195, 22);
            this.IngNomb.Name = "IngNomb";
            this.IngNomb.Size = new System.Drawing.Size(141, 27);
            this.IngNomb.TabIndex = 0;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVolver.Location = new System.Drawing.Point(33, 300);
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
            this.BotonAceptar.Location = new System.Drawing.Point(211, 300);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(110, 40);
            this.BotonAceptar.TabIndex = 4;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // DescDir
            // 
            this.DescDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescDir.AutoSize = true;
            this.DescDir.Location = new System.Drawing.Point(50, 239);
            this.DescDir.Name = "DescDir";
            this.DescDir.Size = new System.Drawing.Size(77, 19);
            this.DescDir.TabIndex = 2;
            this.DescDir.Text = "Dirección:";
            // 
            // IngDir
            // 
            this.IngDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngDir.Location = new System.Drawing.Point(195, 235);
            this.IngDir.Name = "IngDir";
            this.IngDir.Size = new System.Drawing.Size(141, 27);
            this.IngDir.TabIndex = 3;
            // 
            // IngTel
            // 
            this.IngTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngTel.Location = new System.Drawing.Point(195, 164);
            this.IngTel.Name = "IngTel";
            this.IngTel.Size = new System.Drawing.Size(141, 27);
            this.IngTel.TabIndex = 2;
            // 
            // DescTel
            // 
            this.DescTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescTel.AutoSize = true;
            this.DescTel.Location = new System.Drawing.Point(52, 168);
            this.DescTel.Name = "DescTel";
            this.DescTel.Size = new System.Drawing.Size(72, 19);
            this.DescTel.TabIndex = 1;
            this.DescTel.Text = "Telefono:";
            // 
            // DescEdad
            // 
            this.DescEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescEdad.AutoSize = true;
            this.DescEdad.Location = new System.Drawing.Point(67, 97);
            this.DescEdad.Name = "DescEdad";
            this.DescEdad.Size = new System.Drawing.Size(43, 19);
            this.DescEdad.TabIndex = 8;
            this.DescEdad.Text = "Edad";
            // 
            // IngEdad
            // 
            this.IngEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngEdad.Location = new System.Drawing.Point(196, 93);
            this.IngEdad.Name = "IngEdad";
            this.IngEdad.Size = new System.Drawing.Size(139, 27);
            this.IngEdad.TabIndex = 1;
            this.IngEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngEdad_KeyPress);
            // 
            // FormIngSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 381);
            this.ControlBox = false;
            this.Controls.Add(this.PanelIngSoc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIngSoc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ingreso Socio";
            this.PanelIngSoc.ResumeLayout(false);
            this.PanelIngSoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelIngSoc;
        private System.Windows.Forms.Label DescNomb;
        private System.Windows.Forms.Label DescTel;
        private System.Windows.Forms.Label DescDir;
        private System.Windows.Forms.TextBox IngNomb;
        private System.Windows.Forms.TextBox IngTel;
        private System.Windows.Forms.TextBox IngDir;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label DescEdad;
        private System.Windows.Forms.TextBox IngEdad;
    }
}