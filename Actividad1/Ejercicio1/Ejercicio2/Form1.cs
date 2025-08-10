namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            FiguraVolumetrica[] figuras = new FiguraVolumetrica[6];

            
            figuras[0] = new Cilindro(3, 3);
            figuras[1] = new Cubo(3);
            figuras[2] = new Ortoedro(7, 7, 21);
            figuras[3] = new Cilindro(9, 13);
            figuras[4] = new Cubo(7);
            figuras[5] = new Cilindro(13, 23);

           
            tbDescripcion.Text += "[ \n";
            foreach (FiguraVolumetrica figura in figuras)
            {
                tbDescripcion.Text += figura.Describir() + ",\n";
            }
            tbDescripcion.Text += "]";
        }
    }
}
