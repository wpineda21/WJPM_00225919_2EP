using System.ComponentModel;

namespace SegundoExamenParcial
{
    partial class OrdenUSer
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

        #region Component Designer generated code

        private void InitializeComponent()
{
    this.label1 = new System.Windows.Forms.Label();
    this.groupBox1 = new System.Windows.Forms.GroupBox();
    this.label2 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.comboBox1 = new System.Windows.Forms.ComboBox();
    this.comboBox2 = new System.Windows.Forms.ComboBox();
    this.button1 = new System.Windows.Forms.Button();
    this.groupBox1.SuspendLayout();
    this.SuspendLayout();
    // 
    // label1
    // 
    this.label1.Location = new System.Drawing.Point(3, 17);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(8, 8);
    this.label1.TabIndex = 0;
    this.label1.Text = "label1";
    // 
    // groupBox1
    // 
    this.groupBox1.Controls.Add(this.button1);
    this.groupBox1.Controls.Add(this.comboBox2);
    this.groupBox1.Controls.Add(this.comboBox1);
    this.groupBox1.Controls.Add(this.label3);
    this.groupBox1.Controls.Add(this.label2);
    this.groupBox1.Controls.Add(this.label1);
    this.groupBox1.Location = new System.Drawing.Point(18, 26);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new System.Drawing.Size(573, 433);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Ordenar";
    // 
    // label2
    // 
    this.label2.Location = new System.Drawing.Point(33, 95);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(162, 47);
    this.label2.TabIndex = 1;
    this.label2.Text = "Seleccione la Empresa";
    this.label2.Click += new System.EventHandler(this.label2_Click);
    // 
    // label3
    // 
    this.label3.Location = new System.Drawing.Point(33, 199);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(190, 49);
    this.label3.TabIndex = 2;
    this.label3.Text = "Seleccione el Nombre del Producto";
    // 
    // comboBox1
    // 
    this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.comboBox1.FormattingEnabled = true;
    this.comboBox1.Location = new System.Drawing.Point(254, 95);
    this.comboBox1.Name = "comboBox1";
    this.comboBox1.Size = new System.Drawing.Size(211, 28);
    this.comboBox1.TabIndex = 3;
    // 
    // comboBox2
    // 
    this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.comboBox2.FormattingEnabled = true;
    this.comboBox2.Location = new System.Drawing.Point(262, 200);
    this.comboBox2.Name = "comboBox2";
    this.comboBox2.Size = new System.Drawing.Size(202, 28);
    this.comboBox2.TabIndex = 4;
    // 
    // button1
    // 
    this.button1.Location = new System.Drawing.Point(64, 333);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(431, 49);
    this.button1.TabIndex = 5;
    this.button1.Text = "Agregar al Carrito de Compra";
    this.button1.UseVisualStyleBackColor = true;
    // 
    // OrdenUSer
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.groupBox1);
    this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    this.Name = "OrdenUSer";
    this.Size = new System.Drawing.Size(618, 474);
    this.groupBox1.ResumeLayout(false);
    this.ResumeLayout(false);
}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}