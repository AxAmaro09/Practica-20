namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int edad))
            {
                string clasificacion;

                if (edad >= 0 && edad <= 12)
                {
                    clasificacion = "Niño";
                }
                else if (edad >= 13 && edad <= 17)
                {
                    clasificacion = "Adolescente";
                }
                else if (edad >= 18 && edad <= 60)
                {
                    clasificacion = "Adulto";
                }
                else
                {
                    clasificacion = "Adulto Mayor";
                }

                MessageBox.Show("La clasificación de edad es: " + clasificacion);
            }
            else
            {
                MessageBox.Show("Ingresa una edad válida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;   
        }
    }
}