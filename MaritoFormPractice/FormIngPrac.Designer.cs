namespace MaritoFormPractice
{
    partial class FormIngPrac
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
            this.PanelIngSoc = new System.Windows.Forms.TableLayoutPanel();
            this.IngCantPers = new System.Windows.Forms.TextBox();
            this.DescEdad = new System.Windows.Forms.Label();
            this.DescCodSoc = new System.Windows.Forms.Label();
            this.DescDep = new System.Windows.Forms.Label();
            this.IngCodSoc = new System.Windows.Forms.TextBox();
            this.IngDep = new System.Windows.Forms.ComboBox();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.PanelIngSoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelIngSoc
            // 
            this.PanelIngSoc.ColumnCount = 2;
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelIngSoc.Controls.Add(this.IngCantPers, 1, 2);
            this.PanelIngSoc.Controls.Add(this.DescEdad, 0, 2);
            this.PanelIngSoc.Controls.Add(this.DescCodSoc, 0, 0);
            this.PanelIngSoc.Controls.Add(this.DescDep, 0, 1);
            this.PanelIngSoc.Controls.Add(this.IngCodSoc, 1, 0);
            this.PanelIngSoc.Controls.Add(this.IngDep, 1, 1);
            this.PanelIngSoc.Controls.Add(this.BotonVolver, 0, 3);
            this.PanelIngSoc.Controls.Add(this.BotonAceptar, 1, 3);
            this.PanelIngSoc.Location = new System.Drawing.Point(12, 12);
            this.PanelIngSoc.Name = "PanelIngSoc";
            this.PanelIngSoc.RowCount = 4;
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelIngSoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelIngSoc.Size = new System.Drawing.Size(355, 357);
            this.PanelIngSoc.TabIndex = 2;
            // 
            // IngCantPers
            // 
            this.IngCantPers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCantPers.Location = new System.Drawing.Point(195, 209);
            this.IngCantPers.Name = "IngCantPers";
            this.IngCantPers.Size = new System.Drawing.Size(141, 27);
            this.IngCantPers.TabIndex = 2;
            this.IngCantPers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngNum_KeyPress);
            // 
            // DescEdad
            // 
            this.DescEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescEdad.AutoSize = true;
            this.DescEdad.Location = new System.Drawing.Point(9, 213);
            this.DescEdad.Name = "DescEdad";
            this.DescEdad.Size = new System.Drawing.Size(159, 19);
            this.DescEdad.TabIndex = 8;
            this.DescEdad.Text = "Cantidad de Personas:";
            // 
            // DescCodSoc
            // 
            this.DescCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodSoc.AutoSize = true;
            this.DescCodSoc.Location = new System.Drawing.Point(38, 35);
            this.DescCodSoc.Name = "DescCodSoc";
            this.DescCodSoc.Size = new System.Drawing.Size(101, 19);
            this.DescCodSoc.TabIndex = 2;
            this.DescCodSoc.Text = "Código Socio:";
            // 
            // DescDep
            // 
            this.DescDep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescDep.AutoSize = true;
            this.DescDep.Location = new System.Drawing.Point(54, 124);
            this.DescDep.Name = "DescDep";
            this.DescDep.Size = new System.Drawing.Size(69, 19);
            this.DescDep.TabIndex = 0;
            this.DescDep.Text = "Deporte:";
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.Location = new System.Drawing.Point(194, 31);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(144, 27);
            this.IngCodSoc.TabIndex = 0;
            this.IngCodSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngNum_KeyPress);
            // 
            // IngDep
            // 
            this.IngDep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngDep.FormattingEnabled = true;
            this.IngDep.Location = new System.Drawing.Point(192, 120);
            this.IngDep.Name = "IngDep";
            this.IngDep.Size = new System.Drawing.Size(147, 27);
            this.IngDep.TabIndex = 9;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVolver.Location = new System.Drawing.Point(33, 292);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(110, 40);
            this.BotonVolver.TabIndex = 6;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonAceptar.Location = new System.Drawing.Point(211, 292);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(110, 40);
            this.BotonAceptar.TabIndex = 5;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // FormIngPrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 381);
            this.Controls.Add(this.PanelIngSoc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIngPrac";
            this.Text = "Ingreso Práctica";
            this.PanelIngSoc.ResumeLayout(false);
            this.PanelIngSoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelIngSoc;
        private System.Windows.Forms.TextBox IngCantPers;
        private System.Windows.Forms.Label DescEdad;
        private System.Windows.Forms.Label DescCodSoc;
        private System.Windows.Forms.Label DescDep;
        private System.Windows.Forms.TextBox IngCodSoc;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.ComboBox IngDep;
    }
}