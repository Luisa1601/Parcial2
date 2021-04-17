using Parcial_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
            pnlSalida.Visible = false;
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            selectFile();
        }

        private void buttonPromedioporParcial_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;


            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');
               
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                NumeroLinea++;
            }

            if(alerta(cbxPromParc.SelectedIndex, 0))
            {
                return;
            }
            int parcial = cbxPromParc.SelectedIndex+2;

            int prom = promedio.promedio_por_parcial(ArregloDosDimensiones, parcial);
            
            listBoxResultado.Items.Add($"El promedio del parcial: {parcial - 1} es: {prom}");
        }

        private void buttonPromedioporSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

  

            foreach (string linea in ArregloNotas)
            {
               
                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            if(alerta(cbxPromParSeccPar.SelectedIndex, cbxPromParSeccSecc.SelectedIndex))
            {
                return;
            }

            int parcial = cbxPromParSeccPar.SelectedIndex + 2;
            int indiceSeccion = cbxPromParSeccSecc.SelectedIndex;
            string seccion = cbxPromParSeccSecc.Items[indiceSeccion].ToString();

            int prom = promedio.promedio_por_seccion(ArregloDosDimensiones, parcial, seccion);

            listBoxResultado.Items.Add($"El promedio  de la sección {seccion} y parcial {parcial-1} es: {prom}");


        }

        private void limpiarCaja()
        {
            listBoxResultado.Items.Clear();
        }

        private void buttonPromedioGeneralSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            if(alerta(cbxPromGenSecc.SelectedIndex, 0))
            {
                return;
            }

            int indiceSeccion = cbxPromGenSecc.SelectedIndex;
            string seccion = cbxPromGenSecc.Items[indiceSeccion].ToString();

            int promGen = promedio.promedio_general_seccion(ArregloDosDimensiones, seccion);

            listBoxResultado.Items.Add($"El promedio general de la sección {seccion} es: {promGen}");
        }

        private void buttonClasificarAlumnos_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            if(alerta(cbxClasAlumno.SelectedIndex, 0))
            {
                return;
            }

            int indiceSeccion = cbxClasAlumno.SelectedIndex;
            string seccion = cbxClasAlumno.Items[indiceSeccion].ToString();

          
            string[,] alumnoClasificado = promedio.Clasificar_Alumnos(ArregloDosDimensiones, seccion);
            string nombre = alumnoClasificado[0, 0];
            string nota = alumnoClasificado[0, 1];

            listBoxResultado.Items.Add($" --- ALUMNOS CON MEJORES NOTAS ---");
            listBoxResultado.Items.Add($"SECCIÓN {seccion}:");
            listBoxResultado.Items.Add($"Nombre: {nombre}");
            listBoxResultado.Items.Add($"Sumatoria de los parciales: {nota}");
        }

        private void buttonNotaMayor_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            if(alerta(cbxNotaMayorSeccion.SelectedIndex, 0))
            {
                return;
            }

            int indiceSeccion = cbxNotaMayorSeccion.SelectedIndex;
            string seccion = cbxNotaMayorSeccion.Items[indiceSeccion].ToString();

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones, seccion);

            listBoxResultado.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR SECCIÓN {seccion} ---");
            listBoxResultado.Items.Add($"Nombre: {mayor}");
        }

        private void buttonNotaMayorGeneral_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones);

            listBoxResultado.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR ---");
            listBoxResultado.Items.Add($"Nombre: {mayor}");
        }

        private void lblLinkSelectData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectFile();
        }

        private void selectFile()
        {
            limpiarCaja();
            ClsArchivo arch = new ClsArchivo();
            OpenFileDialog msj = new OpenFileDialog();
            msj.Title = "Porfa, Selecciona tu archivo plano";
            msj.InitialDirectory = @"C:\Users\Usuario\Documents\Archivo Plano";
            msj.Filter = "Archivo Plano (*.csv)|*.csv";

            if (msj.ShowDialog() == DialogResult.OK)
            {
                var archivo = msj.FileName;
                string resultado = arch.LeerTodoArchivo(archivo);
                ArregloNotas = arch.LeerArchivo(archivo);
                textBoxArchivo.Text = resultado;
                pnlSalida.Visible = true;
            }
        }

        private bool alerta(int indice, int opcional)
        {
            if (indice < 0 || opcional < 0)
            {
                MessageBox.Show("Debe seleccionar una opción");
                return true;
            }
            else return false;
        }
    }
}

   


     
        
    
