namespace Tarea2_Richard_Viquez.Views
{
    partial class MostrarConductores
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
            this.gradient1 = new Tarea2_Richard_Viquez.Utilities.Gradient();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIMER_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEGUNDO_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Final = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
            this.gradient1.Inicial = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.gradient1.Location = new System.Drawing.Point(1, 3);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(657, 501);
            this.gradient1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDENTIFICACION,
            this.NOMBRE,
            this.PRIMER_APELLIDO,
            this.SEGUNDO_APELLIDO,
            this.RUTA});
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 459);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE CONDUCTORES";
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.HeaderText = "IDENTIFICACION";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // PRIMER_APELLIDO
            // 
            this.PRIMER_APELLIDO.HeaderText = "PRIMER APELLIDO";
            this.PRIMER_APELLIDO.Name = "PRIMER_APELLIDO";
            // 
            // SEGUNDO_APELLIDO
            // 
            this.SEGUNDO_APELLIDO.HeaderText = "SEGUNDO APELLIDO";
            this.SEGUNDO_APELLIDO.Name = "SEGUNDO_APELLIDO";
            // 
            // RUTA
            // 
            this.RUTA.HeaderText = "RUTA";
            this.RUTA.Name = "RUTA";
            // 
            // MostrarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(658, 505);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarConductores";
            this.Text = "MostrarConductores";
            this.Load += new System.EventHandler(this.MostrarConductores_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Utilities.Gradient gradient1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIMER_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGUNDO_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTA;
    }
}