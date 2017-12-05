namespace ProyectoMedicacion.Vistas
{
    partial class AlergiasPersonas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiarPersona = new System.Windows.Forms.Button();
            this.buttonBuscarPersona = new System.Windows.Forms.Button();
            this.textBoxNombrePersona = new System.Windows.Forms.TextBox();
            this.textIdPersona = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiarComponente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombreComponente = new System.Windows.Forms.TextBox();
            this.textBoxIdComponente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltrarBusqueda = new System.Windows.Forms.TextBox();
            this.TablaAlergiasPersona = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarComponente = new System.Windows.Forms.Button();
            this.buttonEliminarComponenteAlergico = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlergiasPersona)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimpiarPersona);
            this.groupBox1.Controls.Add(this.buttonBuscarPersona);
            this.groupBox1.Controls.Add(this.textBoxNombrePersona);
            this.groupBox1.Controls.Add(this.textIdPersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            // 
            // buttonLimpiarPersona
            // 
            this.buttonLimpiarPersona.Location = new System.Drawing.Point(203, 67);
            this.buttonLimpiarPersona.Name = "buttonLimpiarPersona";
            this.buttonLimpiarPersona.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarPersona.TabIndex = 9;
            this.buttonLimpiarPersona.Text = "Limpiar";
            this.buttonLimpiarPersona.UseVisualStyleBackColor = true;
            this.buttonLimpiarPersona.Click += new System.EventHandler(this.buttonLimpiarPersona_Click);
            // 
            // buttonBuscarPersona
            // 
            this.buttonBuscarPersona.Location = new System.Drawing.Point(203, 16);
            this.buttonBuscarPersona.Name = "buttonBuscarPersona";
            this.buttonBuscarPersona.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPersona.TabIndex = 8;
            this.buttonBuscarPersona.Text = "Buscar...";
            this.buttonBuscarPersona.UseVisualStyleBackColor = true;
            this.buttonBuscarPersona.Click += new System.EventHandler(this.buttonBuscarPersona_Click);
            // 
            // textBoxNombrePersona
            // 
            this.textBoxNombrePersona.Location = new System.Drawing.Point(56, 45);
            this.textBoxNombrePersona.Name = "textBoxNombrePersona";
            this.textBoxNombrePersona.ReadOnly = true;
            this.textBoxNombrePersona.Size = new System.Drawing.Size(222, 20);
            this.textBoxNombrePersona.TabIndex = 3;
            // 
            // textIdPersona
            // 
            this.textIdPersona.Location = new System.Drawing.Point(56, 19);
            this.textIdPersona.Name = "textIdPersona";
            this.textIdPersona.ReadOnly = true;
            this.textIdPersona.Size = new System.Drawing.Size(67, 20);
            this.textIdPersona.TabIndex = 2;
            this.textIdPersona.TextChanged += new System.EventHandler(this.textIdPersona_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLimpiarComponente);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxNombreComponente);
            this.groupBox2.Controls.Add(this.textBoxIdComponente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(330, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componente";
            // 
            // buttonLimpiarComponente
            // 
            this.buttonLimpiarComponente.Location = new System.Drawing.Point(214, 67);
            this.buttonLimpiarComponente.Name = "buttonLimpiarComponente";
            this.buttonLimpiarComponente.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarComponente.TabIndex = 10;
            this.buttonLimpiarComponente.Text = "Limpiar";
            this.buttonLimpiarComponente.UseVisualStyleBackColor = true;
            this.buttonLimpiarComponente.Click += new System.EventHandler(this.buttonLimpiarComponente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombreComponente
            // 
            this.textBoxNombreComponente.Location = new System.Drawing.Point(128, 44);
            this.textBoxNombreComponente.Name = "textBoxNombreComponente";
            this.textBoxNombreComponente.ReadOnly = true;
            this.textBoxNombreComponente.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreComponente.TabIndex = 3;
            // 
            // textBoxIdComponente
            // 
            this.textBoxIdComponente.Location = new System.Drawing.Point(128, 17);
            this.textBoxIdComponente.Name = "textBoxIdComponente";
            this.textBoxIdComponente.ReadOnly = true;
            this.textBoxIdComponente.Size = new System.Drawing.Size(67, 20);
            this.textBoxIdComponente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del Componente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFiltrarBusqueda);
            this.groupBox3.Controls.Add(this.TablaAlergiasPersona);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 194);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alergias de la Persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtrar Datos";
            // 
            // txtFiltrarBusqueda
            // 
            this.txtFiltrarBusqueda.Location = new System.Drawing.Point(81, 26);
            this.txtFiltrarBusqueda.Name = "txtFiltrarBusqueda";
            this.txtFiltrarBusqueda.Size = new System.Drawing.Size(197, 20);
            this.txtFiltrarBusqueda.TabIndex = 6;
            this.txtFiltrarBusqueda.TextChanged += new System.EventHandler(this.txtFiltrarBusqueda_TextChanged);
            // 
            // TablaAlergiasPersona
            // 
            this.TablaAlergiasPersona.AllowUserToAddRows = false;
            this.TablaAlergiasPersona.AllowUserToDeleteRows = false;
            this.TablaAlergiasPersona.AllowUserToResizeColumns = false;
            this.TablaAlergiasPersona.AllowUserToResizeRows = false;
            this.TablaAlergiasPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAlergiasPersona.Location = new System.Drawing.Point(9, 52);
            this.TablaAlergiasPersona.MultiSelect = false;
            this.TablaAlergiasPersona.Name = "TablaAlergiasPersona";
            this.TablaAlergiasPersona.ReadOnly = true;
            this.TablaAlergiasPersona.ShowCellErrors = false;
            this.TablaAlergiasPersona.ShowCellToolTips = false;
            this.TablaAlergiasPersona.ShowEditingIcon = false;
            this.TablaAlergiasPersona.ShowRowErrors = false;
            this.TablaAlergiasPersona.Size = new System.Drawing.Size(269, 130);
            this.TablaAlergiasPersona.TabIndex = 5;
            this.TablaAlergiasPersona.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAgregarComponente);
            this.groupBox4.Controls.Add(this.buttonEliminarComponenteAlergico);
            this.groupBox4.Location = new System.Drawing.Point(330, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 167);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // buttonAgregarComponente
            // 
            this.buttonAgregarComponente.Location = new System.Drawing.Point(14, 26);
            this.buttonAgregarComponente.Name = "buttonAgregarComponente";
            this.buttonAgregarComponente.Size = new System.Drawing.Size(122, 50);
            this.buttonAgregarComponente.TabIndex = 2;
            this.buttonAgregarComponente.Text = "Agregar Componente Alérgico";
            this.buttonAgregarComponente.UseVisualStyleBackColor = true;
            this.buttonAgregarComponente.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonEliminarComponenteAlergico
            // 
            this.buttonEliminarComponenteAlergico.Location = new System.Drawing.Point(14, 95);
            this.buttonEliminarComponenteAlergico.Name = "buttonEliminarComponenteAlergico";
            this.buttonEliminarComponenteAlergico.Size = new System.Drawing.Size(122, 46);
            this.buttonEliminarComponenteAlergico.TabIndex = 0;
            this.buttonEliminarComponenteAlergico.Text = "Eliminar Componente Alérgico";
            this.buttonEliminarComponenteAlergico.UseVisualStyleBackColor = true;
            this.buttonEliminarComponenteAlergico.Click += new System.EventHandler(this.buttonEliminarComponenteAlergico_Click);
            // 
            // AlergiasPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "AlergiasPersonas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alergias";
            this.Activated += new System.EventHandler(this.AlergiasPersonas_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlergiasPersonas_FormClosed);
            this.Load += new System.EventHandler(this.AlergiasPersonas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlergiasPersona)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombrePersona;
        private System.Windows.Forms.TextBox textIdPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNombreComponente;
        private System.Windows.Forms.TextBox textBoxIdComponente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TablaAlergiasPersona;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonEliminarComponenteAlergico;
        private System.Windows.Forms.Button buttonBuscarPersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltrarBusqueda;
        private System.Windows.Forms.Button buttonAgregarComponente;
        private System.Windows.Forms.Button buttonLimpiarPersona;
        private System.Windows.Forms.Button buttonLimpiarComponente;
    }
}