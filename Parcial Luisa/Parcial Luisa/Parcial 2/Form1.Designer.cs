
namespace Parcial_2
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
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.lblLinkSelectData = new System.Windows.Forms.LinkLabel();
            this.buttonPromedioporParcial = new System.Windows.Forms.Button();
            this.buttonPromedioporSeccion = new System.Windows.Forms.Button();
            this.buttonPromedioGeneralSeccion = new System.Windows.Forms.Button();
            this.buttonClasificarAlumnos = new System.Windows.Forms.Button();
            this.buttonNotaMayor = new System.Windows.Forms.Button();
            this.buttonNotaMayorGeneral = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.pnlSalida = new System.Windows.Forms.Panel();
            this.cbxPromGenSecc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPromParSeccSecc = new System.Windows.Forms.ComboBox();
            this.cbxPromParSeccPar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPromParc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxClasAlumno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxNotaMayorSeccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(11, 93);
            this.textBoxArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArchivo.Multiline = true;
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArchivo.Size = new System.Drawing.Size(416, 515);
            this.textBoxArchivo.TabIndex = 1;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCargarArchivo.Location = new System.Drawing.Point(321, 64);
            this.buttonCargarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(106, 25);
            this.buttonCargarArchivo.TabIndex = 8;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // lblLinkSelectData
            // 
            this.lblLinkSelectData.AutoSize = true;
            this.lblLinkSelectData.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSelectData.Location = new System.Drawing.Point(7, 64);
            this.lblLinkSelectData.Name = "lblLinkSelectData";
            this.lblLinkSelectData.Size = new System.Drawing.Size(288, 20);
            this.lblLinkSelectData.TabIndex = 9;
            this.lblLinkSelectData.TabStop = true;
            this.lblLinkSelectData.Text = "Seleccione archivo para cargar datos...";
            this.lblLinkSelectData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSelectData_LinkClicked);
            // 
            // buttonPromedioporParcial
            // 
            this.buttonPromedioporParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPromedioporParcial.Location = new System.Drawing.Point(111, 105);
            this.buttonPromedioporParcial.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromedioporParcial.Name = "buttonPromedioporParcial";
            this.buttonPromedioporParcial.Size = new System.Drawing.Size(61, 21);
            this.buttonPromedioporParcial.TabIndex = 2;
            this.buttonPromedioporParcial.Text = "Ver";
            this.buttonPromedioporParcial.UseVisualStyleBackColor = true;
            this.buttonPromedioporParcial.Click += new System.EventHandler(this.buttonPromedioporParcial_Click);
            // 
            // buttonPromedioporSeccion
            // 
            this.buttonPromedioporSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPromedioporSeccion.Location = new System.Drawing.Point(109, 204);
            this.buttonPromedioporSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromedioporSeccion.Name = "buttonPromedioporSeccion";
            this.buttonPromedioporSeccion.Size = new System.Drawing.Size(63, 25);
            this.buttonPromedioporSeccion.TabIndex = 3;
            this.buttonPromedioporSeccion.Text = "Ver";
            this.buttonPromedioporSeccion.UseVisualStyleBackColor = true;
            this.buttonPromedioporSeccion.Click += new System.EventHandler(this.buttonPromedioporSeccion_Click);
            // 
            // buttonPromedioGeneralSeccion
            // 
            this.buttonPromedioGeneralSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPromedioGeneralSeccion.Location = new System.Drawing.Point(111, 312);
            this.buttonPromedioGeneralSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromedioGeneralSeccion.Name = "buttonPromedioGeneralSeccion";
            this.buttonPromedioGeneralSeccion.Size = new System.Drawing.Size(61, 21);
            this.buttonPromedioGeneralSeccion.TabIndex = 4;
            this.buttonPromedioGeneralSeccion.Text = "Ver";
            this.buttonPromedioGeneralSeccion.UseVisualStyleBackColor = true;
            this.buttonPromedioGeneralSeccion.Click += new System.EventHandler(this.buttonPromedioGeneralSeccion_Click);
            // 
            // buttonClasificarAlumnos
            // 
            this.buttonClasificarAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClasificarAlumnos.Location = new System.Drawing.Point(109, 390);
            this.buttonClasificarAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificarAlumnos.Name = "buttonClasificarAlumnos";
            this.buttonClasificarAlumnos.Size = new System.Drawing.Size(63, 21);
            this.buttonClasificarAlumnos.TabIndex = 5;
            this.buttonClasificarAlumnos.Text = "Ver";
            this.buttonClasificarAlumnos.UseVisualStyleBackColor = true;
            this.buttonClasificarAlumnos.Click += new System.EventHandler(this.buttonClasificarAlumnos_Click);
            // 
            // buttonNotaMayor
            // 
            this.buttonNotaMayor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNotaMayor.Location = new System.Drawing.Point(111, 469);
            this.buttonNotaMayor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNotaMayor.Name = "buttonNotaMayor";
            this.buttonNotaMayor.Size = new System.Drawing.Size(61, 21);
            this.buttonNotaMayor.TabIndex = 6;
            this.buttonNotaMayor.Text = "Ver";
            this.buttonNotaMayor.UseVisualStyleBackColor = true;
            this.buttonNotaMayor.Click += new System.EventHandler(this.buttonNotaMayor_Click);
            // 
            // buttonNotaMayorGeneral
            // 
            this.buttonNotaMayorGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNotaMayorGeneral.Location = new System.Drawing.Point(29, 537);
            this.buttonNotaMayorGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNotaMayorGeneral.Name = "buttonNotaMayorGeneral";
            this.buttonNotaMayorGeneral.Size = new System.Drawing.Size(143, 25);
            this.buttonNotaMayorGeneral.TabIndex = 7;
            this.buttonNotaMayorGeneral.Text = "Ver";
            this.buttonNotaMayorGeneral.UseVisualStyleBackColor = true;
            this.buttonNotaMayorGeneral.Click += new System.EventHandler(this.buttonNotaMayorGeneral_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 19;
            this.listBoxResultado.Location = new System.Drawing.Point(279, 62);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(464, 498);
            this.listBoxResultado.TabIndex = 0;
            // 
            // pnlSalida
            // 
            this.pnlSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalida.Controls.Add(this.label14);
            this.pnlSalida.Controls.Add(this.label12);
            this.pnlSalida.Controls.Add(this.cbxNotaMayorSeccion);
            this.pnlSalida.Controls.Add(this.label10);
            this.pnlSalida.Controls.Add(this.label11);
            this.pnlSalida.Controls.Add(this.cbxClasAlumno);
            this.pnlSalida.Controls.Add(this.label9);
            this.pnlSalida.Controls.Add(this.label6);
            this.pnlSalida.Controls.Add(this.cbxPromGenSecc);
            this.pnlSalida.Controls.Add(this.label7);
            this.pnlSalida.Controls.Add(this.label8);
            this.pnlSalida.Controls.Add(this.cbxPromParSeccSecc);
            this.pnlSalida.Controls.Add(this.cbxPromParSeccPar);
            this.pnlSalida.Controls.Add(this.label5);
            this.pnlSalida.Controls.Add(this.label4);
            this.pnlSalida.Controls.Add(this.cbxPromParc);
            this.pnlSalida.Controls.Add(this.label3);
            this.pnlSalida.Controls.Add(this.label2);
            this.pnlSalida.Controls.Add(this.label1);
            this.pnlSalida.Controls.Add(this.listBoxResultado);
            this.pnlSalida.Controls.Add(this.buttonClasificarAlumnos);
            this.pnlSalida.Controls.Add(this.buttonPromedioGeneralSeccion);
            this.pnlSalida.Controls.Add(this.buttonNotaMayorGeneral);
            this.pnlSalida.Controls.Add(this.buttonPromedioporParcial);
            this.pnlSalida.Controls.Add(this.buttonPromedioporSeccion);
            this.pnlSalida.Controls.Add(this.buttonNotaMayor);
            this.pnlSalida.Location = new System.Drawing.Point(463, 29);
            this.pnlSalida.Name = "pnlSalida";
            this.pnlSalida.Size = new System.Drawing.Size(747, 579);
            this.pnlSalida.TabIndex = 10;
            // 
            // cbxPromGenSecc
            // 
            this.cbxPromGenSecc.FormattingEnabled = true;
            this.cbxPromGenSecc.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxPromGenSecc.Location = new System.Drawing.Point(29, 312);
            this.cbxPromGenSecc.Name = "cbxPromGenSecc";
            this.cbxPromGenSecc.Size = new System.Drawing.Size(77, 21);
            this.cbxPromGenSecc.TabIndex = 22;
            this.cbxPromGenSecc.Text = "Sección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "--> Promedio general por sección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sección:";
            // 
            // cbxPromParSeccSecc
            // 
            this.cbxPromParSeccSecc.FormattingEnabled = true;
            this.cbxPromParSeccSecc.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxPromParSeccSecc.Location = new System.Drawing.Point(27, 230);
            this.cbxPromParSeccSecc.Name = "cbxPromParSeccSecc";
            this.cbxPromParSeccSecc.Size = new System.Drawing.Size(77, 21);
            this.cbxPromParSeccSecc.TabIndex = 17;
            this.cbxPromParSeccSecc.Text = "Sección";
            // 
            // cbxPromParSeccPar
            // 
            this.cbxPromParSeccPar.FormattingEnabled = true;
            this.cbxPromParSeccPar.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxPromParSeccPar.Location = new System.Drawing.Point(27, 187);
            this.cbxPromParSeccPar.Name = "cbxPromParSeccPar";
            this.cbxPromParSeccPar.Size = new System.Drawing.Size(77, 21);
            this.cbxPromParSeccPar.TabIndex = 16;
            this.cbxPromParSeccPar.Text = "Parcial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Parcial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "--> Promedio por parcial y sección";
            // 
            // cbxPromParc
            // 
            this.cbxPromParc.FormattingEnabled = true;
            this.cbxPromParc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxPromParc.Location = new System.Drawing.Point(29, 105);
            this.cbxPromParc.Name = "cbxPromParc";
            this.cbxPromParc.Size = new System.Drawing.Size(77, 21);
            this.cbxPromParc.TabIndex = 13;
            this.cbxPromParc.Text = "Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "--> Promedio por parcial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "--> Clasificar mejor alumno";
            // 
            // cbxClasAlumno
            // 
            this.cbxClasAlumno.FormattingEnabled = true;
            this.cbxClasAlumno.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxClasAlumno.Location = new System.Drawing.Point(29, 390);
            this.cbxClasAlumno.Name = "cbxClasAlumno";
            this.cbxClasAlumno.Size = new System.Drawing.Size(77, 21);
            this.cbxClasAlumno.TabIndex = 25;
            this.cbxClasAlumno.Text = "Sección";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sección:";
            // 
            // cbxNotaMayorSeccion
            // 
            this.cbxNotaMayorSeccion.FormattingEnabled = true;
            this.cbxNotaMayorSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxNotaMayorSeccion.Location = new System.Drawing.Point(29, 469);
            this.cbxNotaMayorSeccion.Name = "cbxNotaMayorSeccion";
            this.cbxNotaMayorSeccion.Size = new System.Drawing.Size(77, 21);
            this.cbxNotaMayorSeccion.TabIndex = 28;
            this.cbxNotaMayorSeccion.Text = "Sección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "--> Alumno con nota mayor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "--> Nota mayor general";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(163, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "ENTRADAS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(250, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 28);
            this.label14.TabIndex = 12;
            this.label14.Text = "SALIDAS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 655);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(332, 21);
            this.label15.TabIndex = 12;
            this.label15.Text = "Luisa Daniela Schlenker Enriquez";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 642);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Elaborado por:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 688);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLinkSelectData);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.pnlSalida);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSalida.ResumeLayout(false);
            this.pnlSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.LinkLabel lblLinkSelectData;
        private System.Windows.Forms.Button buttonPromedioporParcial;
        private System.Windows.Forms.Button buttonPromedioporSeccion;
        private System.Windows.Forms.Button buttonPromedioGeneralSeccion;
        private System.Windows.Forms.Button buttonClasificarAlumnos;
        private System.Windows.Forms.Button buttonNotaMayor;
        private System.Windows.Forms.Button buttonNotaMayorGeneral;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Panel pnlSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPromParc;
        private System.Windows.Forms.ComboBox cbxPromParSeccSecc;
        private System.Windows.Forms.ComboBox cbxPromParSeccPar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPromGenSecc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxClasAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxNotaMayorSeccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

