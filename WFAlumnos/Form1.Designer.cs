namespace WFAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1Conexion = new System.Windows.Forms.Button();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxparcial1 = new System.Windows.Forms.TextBox();
            this.textBoxparcial2 = new System.Windows.Forms.TextBox();
            this.textBoxparcial3 = new System.Windows.Forms.TextBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Conexion
            // 
            this.button1Conexion.BackColor = System.Drawing.Color.Ivory;
            this.button1Conexion.Location = new System.Drawing.Point(406, 401);
            this.button1Conexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Conexion.Name = "button1Conexion";
            this.button1Conexion.Size = new System.Drawing.Size(152, 34);
            this.button1Conexion.TabIndex = 0;
            this.button1Conexion.Text = "Prueba Conexion";
            this.button1Conexion.UseVisualStyleBackColor = false;
            this.button1Conexion.Click += new System.EventHandler(this.button1Conexion_Click);
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(763, 0);
            this.dataGridViewAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.RowHeadersWidth = 51;
            this.dataGridViewAlumno.RowTemplate.Height = 29;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(463, 530);
            this.dataGridViewAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clase";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCarnet.Location = new System.Drawing.Point(140, 47);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(277, 23);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNombre.Location = new System.Drawing.Point(140, 81);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(277, 23);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCorreo.Location = new System.Drawing.Point(140, 117);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(277, 23);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(140, 157);
            this.comboBoxSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(277, 23);
            this.comboBoxSeccion.TabIndex = 11;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3 LA VENGANZA",
            "ELECTRONICA",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(140, 195);
            this.comboBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(277, 23);
            this.comboBoxClase.TabIndex = 12;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.Color.Ivory;
            this.buttonConsulta.Location = new System.Drawing.Point(551, 151);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(143, 24);
            this.buttonConsulta.TabIndex = 13;
            this.buttonConsulta.Text = "Consuiltar";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Ivory;
            this.buttonLimpiar.Location = new System.Drawing.Point(195, 401);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(152, 34);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar Formulario";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.Ivory;
            this.buttonInsertar.Location = new System.Drawing.Point(551, 48);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(143, 22);
            this.buttonInsertar.TabIndex = 15;
            this.buttonInsertar.Text = "Crear Alumno";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Ivory;
            this.buttonActualizar.Location = new System.Drawing.Point(551, 84);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(143, 22);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.Ivory;
            this.buttonImportar.Location = new System.Drawing.Point(551, 194);
            this.buttonImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(143, 22);
            this.buttonImportar.TabIndex = 17;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Ivory;
            this.buttonExportar.Location = new System.Drawing.Point(551, 230);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(143, 22);
            this.buttonExportar.TabIndex = 18;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Parcial 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(54, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Parcial 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Parcial 3";
            // 
            // textBoxparcial1
            // 
            this.textBoxparcial1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxparcial1.Location = new System.Drawing.Point(140, 231);
            this.textBoxparcial1.Name = "textBoxparcial1";
            this.textBoxparcial1.Size = new System.Drawing.Size(277, 23);
            this.textBoxparcial1.TabIndex = 22;
            // 
            // textBoxparcial2
            // 
            this.textBoxparcial2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxparcial2.Location = new System.Drawing.Point(140, 266);
            this.textBoxparcial2.Name = "textBoxparcial2";
            this.textBoxparcial2.Size = new System.Drawing.Size(277, 23);
            this.textBoxparcial2.TabIndex = 23;
            // 
            // textBoxparcial3
            // 
            this.textBoxparcial3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxparcial3.Location = new System.Drawing.Point(140, 307);
            this.textBoxparcial3.Name = "textBoxparcial3";
            this.textBoxparcial3.Size = new System.Drawing.Size(277, 23);
            this.textBoxparcial3.TabIndex = 24;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.Ivory;
            this.buttoneliminar.Location = new System.Drawing.Point(551, 116);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(143, 23);
            this.buttoneliminar.TabIndex = 25;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1226, 530);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.textBoxparcial3);
            this.Controls.Add(this.textBoxparcial2);
            this.Controls.Add(this.textBoxparcial1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.button1Conexion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Conexion;
        private DataGridView dataGridViewAlumno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxSeccion;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private Button buttonLimpiar;
        private Button buttonInsertar;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxparcial1;
        private TextBox textBoxparcial2;
        private TextBox textBoxparcial3;
        private Button buttoneliminar;
    }
}