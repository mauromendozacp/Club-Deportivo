namespace MaritoFormPractice
{
    partial class FormBuscSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscSoc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescCodSoc = new System.Windows.Forms.Label();
            this.IngCodSoc = new System.Windows.Forms.TextBox();
            this.ListSoc = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DescCodSoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IngCodSoc, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DescCodSoc
            // 
            this.DescCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodSoc.AutoSize = true;
            this.DescCodSoc.Location = new System.Drawing.Point(38, 24);
            this.DescCodSoc.Name = "DescCodSoc";
            this.DescCodSoc.Size = new System.Drawing.Size(101, 19);
            this.DescCodSoc.TabIndex = 0;
            this.DescCodSoc.Text = "Código Socio:";
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.Location = new System.Drawing.Point(216, 20);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(100, 27);
            this.IngCodSoc.TabIndex = 1;
            this.IngCodSoc.TextChanged += new System.EventHandler(this.IngCodSoc_TextChanged);
            this.IngCodSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngCodSoc_KeyPress);
            // 
            // ListSoc
            // 
            this.ListSoc.Enabled = false;
            this.ListSoc.FormattingEnabled = true;
            this.ListSoc.ItemHeight = 19;
            this.ListSoc.Location = new System.Drawing.Point(57, 85);
            this.ListSoc.Name = "ListSoc";
            this.ListSoc.Size = new System.Drawing.Size(265, 213);
            this.ListSoc.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BotonVolver, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BotonAceptar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 304);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 67);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVolver.Location = new System.Drawing.Point(33, 13);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(110, 40);
            this.BotonVolver.TabIndex = 0;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonAceptar.Location = new System.Drawing.Point(211, 13);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(110, 40);
            this.BotonAceptar.TabIndex = 1;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // FormBuscSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 381);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ListSoc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBuscSoc";
            this.Text = "Buscar Socio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DescCodSoc;
        private System.Windows.Forms.TextBox IngCodSoc;
        private System.Windows.Forms.ListBox ListSoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonAceptar;
    }
}