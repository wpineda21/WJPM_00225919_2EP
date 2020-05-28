using System;
using System.Windows.Forms;

namespace SegundoExamenParcial
{
    public partial class DireccionUser : UserControl
    {
        Usuario user = new Usuario();
        public DireccionUser()
        {
            InitializeComponent();
            
        }

        private void DireccionUser_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Username";
            comboBox1.DataSource = UsuarioBD.getLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Direccion User2 = new Direccion();
            User2.iduser = 0;
            User2.address = textBox1.Text;
            try
            {
                AddresBD.AgregarDireccion(User2.iduser,User2.address);

                MessageBox.Show("direccion agregada exitosamente", "Hugo Desktop App",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    button1(sender, e);

                // actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo Desktop APP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Direccionlabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}