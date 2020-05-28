using System.ComponentModel;

namespace SegundoExamenParcial
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCambiarContra = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.comboxUsuario = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(401, 344);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(253, 27);
            this.textBoxContraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(131, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(156, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "     Hugo Lo Que Necesitas, a Domicilio";
            // 
            // buttonCambiarContra
            // 
            this.buttonCambiarContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonCambiarContra.Location = new System.Drawing.Point(323, 431);
            this.buttonCambiarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCambiarContra.Name = "buttonCambiarContra";
            this.buttonCambiarContra.Size = new System.Drawing.Size(162, 68);
            this.buttonCambiarContra.TabIndex = 5;
            this.buttonCambiarContra.Text = "Actualizar Contraseña";
            this.buttonCambiarContra.UseVisualStyleBackColor = true;
            this.buttonCambiarContra.Click += new System.EventHandler(this.buttonCambiarContra_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonIngresar.Location = new System.Drawing.Point(507, 431);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(147, 68);
            this.buttonIngresar.TabIndex = 6;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // comboxUsuario
            // 
            this.comboxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxUsuario.FormattingEnabled = true;
            this.comboxUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboxUsuario.Location = new System.Drawing.Point(401, 271);
            this.comboxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxUsuario.Name = "comboxUsuario";
            this.comboxUsuario.Size = new System.Drawing.Size(253, 28);
            this.comboxUsuario.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboxUsuario);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonCambiarContra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContraseña);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonCambiarContra;
        private System.Windows.Forms.ComboBox comboxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}