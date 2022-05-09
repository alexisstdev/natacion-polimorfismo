using System.Windows.Forms;

// Sala 1
namespace Natacion
{
    class Alumno
    {
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Nivel { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public virtual void MostrarTecnicas()
        {
            MessageBox.Show("Técnicas");
        }
    }

    class Principiante : Alumno
    {
        public string Patalear => "Patalear";
        public string Sumergirse => "Sumergirse";
        public string TecnicaCrol => "Nadar con técnica de Crol";

        public override void MostrarTecnicas()
        {
            MessageBox.Show($"{Patalear}\n{Sumergirse}\n{TecnicaCrol}");
        }
    }

    class Intermedio : Principiante
    {
        public string TecnicaPechoEspalda => "Nadar con técnica de pecho y espalda";

        public override void MostrarTecnicas()
        {
            MessageBox.Show($"{Patalear}\n{Sumergirse}\n{TecnicaCrol}\n{TecnicaPechoEspalda}");
        }
    }

    class Avanzado : Intermedio
    {
        public string TecnicaMariposa => "Nadar con técnica de Mariposa";
        public string Clavado => "Clavado";

        public override void MostrarTecnicas()
        {
            MessageBox.Show($"{Patalear}\n{Sumergirse}\n{TecnicaCrol}\n{TecnicaPechoEspalda}\n{TecnicaMariposa}\n{Clavado}");
        }
    }
}