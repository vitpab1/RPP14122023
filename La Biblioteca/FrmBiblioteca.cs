using Vittar.Pablo.RPP;

namespace La_Biblioteca
{
    public partial class FrmBiblioteca : Form
    {
        private Libro libro; 
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AltaLibro popupForm = new AltaLibro();

            popupForm.ShowDialog();
        }
    }
}