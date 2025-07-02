using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_III
{
    public partial class Form1 : Form
    {

        string[,] Alumnos = new string[100, 4];
        int Contador = 0;
       
        
        void AgregarAlumnos() // hell0
        {
            if (ExisteRegistro()) // Hola que tal 
            {
                return; //De tiene la ejecución si el numero de cuenta ya existe
            }


            if (MessageBox.Show("Esta seguro de guardar el registro", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
               
                Alumnos[Contador, 0] = txtNumcuenta.Text;
                Alumnos[Contador, 1] = txtNomCompleto.Text;
                Alumnos[Contador, 2] = DtpNacimiento.Value.Date.ToString();
                Alumnos[Contador, 3] = txtCarrera.Text;
                Contador++;
                RecorrerArreglo();
            }
        }


        void AgregarData()
        {
            DGVDatos.Rows.Clear();
            
            for(int fila = 0; fila < Contador; fila++)
            {
                DGVDatos.Rows.Add(new object[] { Alumnos[fila, 0].ToString(), Alumnos[fila, 1].ToString(), Alumnos[fila, 2].ToString(), Alumnos[fila, 3].ToString() });
            }
        }

        void RecorrerArreglo()
        {
            string Registro = "Registro de alumnos: ";
            for(int fila = 0; fila < Contador; fila++)
            {
                Registro = Registro + "\n Fila: " +  fila;
                for(int Columna = 0; Columna < 4; Columna++)
                {
                    Registro = Registro + "  " +  Alumnos[fila,Columna].ToString();
                }
            }
            LblRegistros.Text = Registro;   
        }

        bool ExisteRegistro()
        {
            string numeroCuenta = txtNumcuenta.Text.Trim();

            // Validar si el número de cuenta ya existe
            for (int fila = 0; fila < Contador; fila++)
            {
                if (Alumnos[fila, 0] == numeroCuenta)
                {

                    MessageBox.Show("El número de cuenta ya existe.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        void EditarAlumno()
        {
            string numeroCuenta = txtNumcuenta.Text.Trim();
            bool encontrado = false;

            
            for (int fila = 0; fila < Contador; fila++)
            {
                if (Alumnos[fila, 0] == numeroCuenta)
                {
                   
                    Alumnos[fila, 1] = txtNomCompleto.Text;
                    Alumnos[fila, 2] = DtpNacimiento.Value.Date.ToString();
                    Alumnos[fila, 3] = txtCarrera.Text;

                    encontrado = true;
                    MessageBox.Show("El registro del alumno ha sido actualizado exitosamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró un alumno con ese número de cuenta .", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RecorrerArreglo(); 
            AgregarData();     
        }


        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
          AgregarAlumnos();
            
           
        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            RecorrerArreglo();
            AgregarData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAlumno();
        }

        public Form1()
        {
            InitializeComponent();
            RecorrerArreglo();

        }
    }
}
