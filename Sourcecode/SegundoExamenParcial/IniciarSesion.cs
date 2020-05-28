using System;
using System.Windows.Forms;


namespace SegundoExamenParcial
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            comboxUsuario.ValueMember = "contrasena";
            comboxUsuario.DisplayMember = "Username";
            comboxUsuario.DataSource = UsuarioBD.getLista();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (comboxUsuario.SelectedValue.Equals(textBoxContraseña.Text))
            {
                Usuario usuario = (Usuario) comboxUsuario.SelectedItem;

                if (usuario.admin)
                {
                    //RegistroDAO.iniciarSesion(u.usuario);

                    MessageBox.Show("¡Bienvenido al Modo Administrador!",
                        "Hugo Desktop APP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 ventana = new Form1(usuario);
                    ventana.Show();
                    this.Hide();
                }
                else if (usuario.admin == false)
                {
                    UsuarioNormal ventana = new UsuarioNormal(usuario);
                    ventana.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido Usuario Gracias por Confiar en Hugo ",
                        "Hugo Desktop APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Contraseña incorrecta!", "Hugo Desktop APP",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void buttonCambiarContra_Click(object sender, EventArgs e)
        {
            CambiarContraseña unaVentana = new CambiarContraseña();
            unaVentana.ShowDialog();
            
        }
    }
}