using System.ComponentModel;

namespace SegundoExamenParcial
{
    partial class UsuarioNormal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2Ordenar = new System.Windows.Forms.Button();
            this.button1Direccion = new System.Windows.Forms.Button();
            this.button3Empresa = new System.Windows.Forms.Button();
            this.direccionUser1 = new SegundoExamenParcial.DireccionUser();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12755F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.Controls.Add(this.button2Ordenar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1Direccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3Empresa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.direccionUser1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.27313F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            this.button2Ordenar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2Ordenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2Ordenar.Location = new System.Drawing.Point(270, 2);
            this.button2Ordenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2Ordenar.Name = "button2Ordenar";
            this.button2Ordenar.Size = new System.Drawing.Size(252, 94);
            this.button2Ordenar.TabIndex = 1;
            this.button2Ordenar.Text = "Ordenar ";
            this.button2Ordenar.UseVisualStyleBackColor = true;
            this.button2Ordenar.Click += new System.EventHandler(this.button2_Click);
            this.button1Direccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1Direccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1Direccion.Location = new System.Drawing.Point(3, 2);
            this.button1Direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Direccion.Name = "button1Direccion";
            this.button1Direccion.Size = new System.Drawing.Size(261, 94);
            this.button1Direccion.TabIndex = 4;
            this.button1Direccion.Text = "Agregar Direccion de compra";
            this.button1Direccion.UseVisualStyleBackColor = true;
            this.button1Direccion.Click += new System.EventHandler(this.button1Direccion_Click);
            this.button3Empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3Empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3Empresa.Location = new System.Drawing.Point(528, 2);
            this.button3Empresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3Empresa.Name = "button3Empresa";
            this.button3Empresa.Size = new System.Drawing.Size(269, 94);
            this.button3Empresa.TabIndex = 5;
            this.button3Empresa.Text = "Explorar Empresas";
            this.button3Empresa.UseVisualStyleBackColor = true;
            this.button3Empresa.Click += new System.EventHandler(this.button3Empresa_Click);
            this.direccionUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.direccionUser1, 3);
            this.direccionUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.direccionUser1.Location = new System.Drawing.Point(3, 102);
            this.direccionUser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.direccionUser1.Name = "direccionUser1";
            this.direccionUser1.Size = new System.Drawing.Size(794, 373);
            this.direccionUser1.TabIndex = 6;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a Hugo  Dekstop APP que desea Hacer?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsuarioNormal";
            this.Text = "UsuarioNormal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private SegundoExamenParcial.DireccionUser direccionUser1;
        private System.Windows.Forms.Button button3Empresa;
        private System.Windows.Forms.Button button1Direccion;
        private System.Windows.Forms.Button button2Ordenar;
    }
}