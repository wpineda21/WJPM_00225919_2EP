using System;
using System.Windows.Forms;

namespace SegundoExamenParcial
{
    public partial class UsuarioNormal : Form
    {
        private UserControl current = null;

        public UsuarioNormal(Usuario usuario)
        {
            InitializeComponent();
            current = direccionUser1;
        }

        private void button1Direccion_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = direccionUser1;
            tableLayoutPanel1.Controls.Add(current, 0, 1 );
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrdenUSer();
            tableLayoutPanel1.Controls.Add(current, 0, 1 );
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }

        private void button3Empresa_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EmpresasUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1 );
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }
    }
}