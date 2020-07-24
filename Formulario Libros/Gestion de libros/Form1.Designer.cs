namespace Gestion_de_libros
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ingreso = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textPaginas = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListaLibros = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Ingreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ingreso);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1145, 848);
            this.tabControl1.TabIndex = 0;
            // 
            // Ingreso
            // 
            this.Ingreso.Controls.Add(this.groupBox1);
            this.Ingreso.Location = new System.Drawing.Point(8, 39);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Padding = new System.Windows.Forms.Padding(3);
            this.Ingreso.Size = new System.Drawing.Size(1129, 801);
            this.Ingreso.TabIndex = 0;
            this.Ingreso.Text = "Ingreso";
            this.Ingreso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.butCancelar);
            this.groupBox1.Controls.Add(this.comboGenero);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.textPaginas);
            this.groupBox1.Controls.Add(this.textAutor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Autor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 792);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Libro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(239, 681);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(119, 41);
            this.butCancelar.TabIndex = 12;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Ciencia Ficción",
            "Comedia",
            "Suspenso"});
            this.comboGenero.Location = new System.Drawing.Point(459, 269);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(287, 33);
            this.comboGenero.TabIndex = 11;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(459, 491);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Sí";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(459, 592);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(87, 31);
            this.textPrecio.TabIndex = 9;
            this.textPrecio.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textPaginas
            // 
            this.textPaginas.Location = new System.Drawing.Point(459, 371);
            this.textPaginas.Name = "textPaginas";
            this.textPaginas.Size = new System.Drawing.Size(87, 31);
            this.textPaginas.TabIndex = 8;
            this.textPaginas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(459, 172);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(287, 31);
            this.textAutor.TabIndex = 7;
            this.textAutor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Importado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Páginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Género";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(275, 175);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(63, 25);
            this.Autor.TabIndex = 2;
            this.Autor.Text = "Autor";
            this.Autor.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(459, 77);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(287, 31);
            this.textNombre.TabIndex = 0;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListaLibros);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 801);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListaLibros
            // 
            this.ListaLibros.FormattingEnabled = true;
            this.ListaLibros.ItemHeight = 25;
            this.ListaLibros.Location = new System.Drawing.Point(118, 69);
            this.ListaLibros.Name = "ListaLibros";
            this.ListaLibros.Size = new System.Drawing.Size(887, 629);
            this.ListaLibros.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 869);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestión de Libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ingreso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ingreso;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPaginas;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.ListBox ListaLibros;
    }
}

