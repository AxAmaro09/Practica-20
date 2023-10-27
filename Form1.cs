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
                    clasificacion = "Ni�o";
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

                MessageBox.Show("La clasificaci�n de edad es: " + clasificacion);
            }
            else
            {
                MessageBox.Show("Ingresa una edad v�lida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;   
        }
    }
}