using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoExamenParcial;

namespace SegundoExamenParcial
{
    public partial class Form1 : Form
    {
        
        private Usuario usuario1;

        public Form1(Usuario usuario)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "Username";
            comboBox2.DataSource = UsuarioBD.getLista();
        }
        
        //almacenar cliente
        private void button2_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();

            User.NombreUsuario = textBox1.Text;
            User.UserName = textBox2.Text;
            User.contrasena = textBox3.Text;
            User.admin = Convert.ToBoolean(textBox4.Text);

            try
            {
                UsuarioBD.agregarUsuario(User);

                MessageBox.Show("Cliente agregado exitosamente", "Hugo Desktop App",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    button1(sender, e);

                // actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "SuperMarket",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}