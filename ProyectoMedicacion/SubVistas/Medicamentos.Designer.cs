namespace ProyectoMedicacion.SubVistas
{
    partial class Medicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.TablaMedicamentos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TablaComponentes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textNomMedi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablaSintomas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textContenedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMedicamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaComponentes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSintomas)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaMedicamentos
            // 
            this.TablaMedicamentos.AllowUserToAddRows = false;
            this.TablaMedicamentos.AllowUserToDeleteRows = false;
            this.TablaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMedicamentos.Location = new System.Drawing.Point(70, 252);
            this.TablaMedicamentos.Name = "TablaMedicamentos";
            this.TablaMedicamentos.ReadOnly = true;
            this.TablaMedicamentos.Size = new System.Drawing.Size(458, 203);
            this.TablaMedicamentos.TabIndex = 0;
            this.TablaMedicamentos.Click += new System.EventHandler(this.TablaMedicamentos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TablaComponentes);
            this.groupBox2.Location = new System.Drawing.Point(246, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componentes";
            // 
            // TablaComponentes
            // 
            this.TablaComponentes.AllowUserToAddRows = false;
            this.TablaComponentes.AllowUserToDeleteRows = false;
            this.TablaComponentes.BackgroundColor = System.Drawing.Color.White;
            this.TablaComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaComponentes.Location = new System.Drawing.Point(3, 16);
            this.TablaComponentes.Name = "TablaComponentes";
            this.TablaComponentes.ReadOnly = true;
            this.TablaComponentes.Size = new System.Drawing.Size(152, 118);
            this.TablaComponentes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textContenedor);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textNomMedi);
            this.groupBox3.Controls.Add(this.textBoxID);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(27, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(86, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(39, 20);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNomMedi
            // 
            this.textNomMedi.Location = new System.Drawing.Point(86, 65);
            this.textNomMedi.Name = "textNomMedi";
            this.textNomMedi.ReadOnly = true;
            this.textNomMedi.Size = new System.Drawing.Size(150, 20);
            this.textNomMedi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TablaSintomas);
            this.groupBox1.Location = new System.Drawing.Point(407, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usos";
            // 
            // TablaSintomas
            // 
            this.TablaSintomas.AllowUserToAddRows = false;
            this.TablaSintomas.AllowUserToDeleteRows = false;
            this.TablaSintomas.BackgroundColor = System.Drawing.Color.White;
            this.TablaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaSintomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaSintomas.Location = new System.Drawing.Point(3, 16);
            this.TablaSintomas.Name = "TablaSintomas";
            this.TablaSintomas.ReadOnly = true;
            this.TablaSintomas.Size = new System.Drawing.Size(151, 118);
            this.TablaSintomas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Búsqueda";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(183, 226);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(308, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contenedor";
            // 
            // textContenedor
            // 
            this.textContenedor.Location = new System.Drawing.Point(86, 97);
            this.textContenedor.Name = "textContenedor";
            this.textContenedor.ReadOnly = true;
            this.textContenedor.Size = new System.Drawing.Size(101, 20);
            this.textContenedor.TabIndex = 9;
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.TablaMedicamentos);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Medicamentos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Medicamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Medicamentos_FormClosing);
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaMedicamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaComponentes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaSintomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaMedicamentos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TablaComponentes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textNomMedi;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TablaSintomas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textContenedor;
    }
}