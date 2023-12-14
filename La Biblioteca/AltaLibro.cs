using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vittar.Pablo.RPP;
namespace La_Biblioteca
{
    public partial class AltaLibro : Form
    {
        private Libro libro;
        private string tipoSeleccionado; 
   
        public AltaLibro()
        {
            InitializeComponent();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            cmbTipoLibro.DataSource = new List<string>() { "Todos", "Adolescentes", "Adultos" };
            cmbDificultad.DataSource = Enum.GetValues(typeof(Entidades.ETipoDeLibro));

        }
        public string Libro
        {
            get { return libro.Detalle; }
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool esEdicionEspecial = edicionBtn.Checked;
            bool esColorida = colorBtn.Checked;
            switch (tipoSeleccionado)
            {
                case " Ciencia_ficcion":
                    libro = new LibroDeHistorietas(nombre, esColorida);
                    break;
                case "historietas":
                    libro = new LibroDeCienciaFiccion(nombre);
                    break;
                case "Misterio":
                    libro = new LibroDeMisterio(nombre, esEdicionEspecial);
                    break;
            }

            this.Close();
        }
    }

}
