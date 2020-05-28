using System;
using System.Windows.Forms;



namespace SegundoExamenParcial
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {    
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "Username";
            comboBox1.DataSource = UsuarioBD.getLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario) comboBox1.SelectedItem;
            bool actualIgual = comboBox1.SelectedValue.Equals(textBox1.Text);
            bool nuevaIgual = textBox2.Text.Equals(textBox3.Text);
            bool nuevaValida = textBox2.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                   UsuarioBD.actualizarContra(textBox2.Text,user);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Hugo Tu aplicacion  de confianza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Hugo Tu aplicacion  de confianza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Hugo Tu aplicacion  de confianza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}