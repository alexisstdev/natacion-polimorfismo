using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Natacion
{
    public partial class Form1 : Form
    {
        private List<Alumno> misAlumnos = new List<Alumno>();
        private Alumno miAlumno = new Alumno();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //valida que no haya campos vacios en cada uno de los groupbox
            foreach (Control control in gbxAlumno.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }
            switch (cbxNivel.Text)
            {
                case "Principiante":
                    {
                        miAlumno = new Principiante();
                    }
                    break;

                case "Intermedio":
                    {
                        miAlumno = new Intermedio();
                    }
                    break;

                case "Avanzado":
                    {
                        miAlumno = new Avanzado();
                    }
                    break;
            }
            miAlumno.Nombre = txtNombre.Text;
            miAlumno.Direccion = txtDireccion.Text;
            miAlumno.Telefono = txtTelefono.Text;
            miAlumno.Edad = (int)nudEdad.Value;
            miAlumno.Nivel = cbxNivel.Text;

            misAlumnos.Add(miAlumno);
            dtgAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in misAlumnos)
            {
                dtgAlumnos.Rows.Add(miAlumno.Nombre, miAlumno.Direccion, miAlumno.Telefono, miAlumno.Edad, miAlumno.Nivel);
            }
            miAlumno.MostrarTecnicas();

            //limpia los datos de los controles
            foreach (Control control in gbxAlumno.Controls)
            {
                NumericUpDown nudControl = control as NumericUpDown;
                ComboBox cbxControl = control as ComboBox;
                if (control is NumericUpDown) nudControl.Value = 0;
                if (control is ComboBox) cbxControl.SelectedIndex = -1;
                if (control is TextBox) control.Text = "";
            }
        }
    }
}