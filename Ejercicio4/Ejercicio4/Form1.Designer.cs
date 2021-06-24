namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbnombre = new System.Windows.Forms.ComboBox();
            this.cbedad = new System.Windows.Forms.ComboBox();
            this.btnascendente = new System.Windows.Forms.Button();
            this.btndescendente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstnombres = new System.Windows.Forms.ListBox();
            this.lstedades = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbnombre
            // 
            this.cbnombre.FormattingEnabled = true;
            this.cbnombre.Location = new System.Drawing.Point(24, 216);
            this.cbnombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(170, 29);
            this.cbnombre.TabIndex = 4;
            // 
            // cbedad
            // 
            this.cbedad.FormattingEnabled = true;
            this.cbedad.Location = new System.Drawing.Point(200, 216);
            this.cbedad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbedad.Name = "cbedad";
            this.cbedad.Size = new System.Drawing.Size(170, 29);
            this.cbedad.TabIndex = 5;
            // 
            // btnascendente
            // 
            this.btnascendente.Location = new System.Drawing.Point(12, 31);
            this.btnascendente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnascendente.Name = "btnascendente";
            this.btnascendente.Size = new System.Drawing.Size(130, 37);
            this.btnascendente.TabIndex = 10;
            this.btnascendente.Text = "Ascendente";
            this.btnascendente.UseVisualStyleBackColor = true;
            this.btnascendente.Click += new System.EventHandler(this.btnascendente_Click);
            // 
            // btndescendente
            // 
            this.btndescendente.Location = new System.Drawing.Point(12, 78);
            this.btndescendente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btndescendente.Name = "btndescendente";
            this.btndescendente.Size = new System.Drawing.Size(130, 37);
            this.btndescendente.TabIndex = 11;
            this.btndescendente.Text = "Descendente";
            this.btndescendente.UseVisualStyleBackColor = true;
            this.btndescendente.Click += new System.EventHandler(this.btndescendente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndescendente);
            this.groupBox1.Controls.Add(this.btnascendente);
            this.groupBox1.Location = new System.Drawing.Point(402, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(149, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(434, 163);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(93, 35);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edad :";
            // 
            // lstnombres
            // 
            this.lstnombres.FormattingEnabled = true;
            this.lstnombres.ItemHeight = 21;
            this.lstnombres.Location = new System.Drawing.Point(24, 57);
            this.lstnombres.Name = "lstnombres";
            this.lstnombres.Size = new System.Drawing.Size(170, 151);
            this.lstnombres.TabIndex = 18;
            // 
            // lstedades
            // 
            this.lstedades.FormattingEnabled = true;
            this.lstedades.ItemHeight = 21;
            this.lstedades.Location = new System.Drawing.Point(200, 57);
            this.lstedades.Name = "lstedades";
            this.lstedades.Size = new System.Drawing.Size(170, 151);
            this.lstedades.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 262);
            this.Controls.Add(this.lstedades);
            this.Controls.Add(this.lstnombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbedad);
            this.Controls.Add(this.cbnombre);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnombre;
        private System.Windows.Forms.ComboBox cbedad;
        private System.Windows.Forms.Button btnascendente;
        private System.Windows.Forms.Button btndescendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstnombres;
        private System.Windows.Forms.ListBox lstedades;
    }
}

