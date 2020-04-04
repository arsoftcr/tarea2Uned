namespace Tarea2_Richard_Viquez.Views
{
    partial class MostrarCamiones
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
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACIDADKILOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACIDADVOLUMEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gradient1.Size = new System.Drawing.Size(653, 498);
            this.gradient1.TabIndex = 2;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLACA,
            this.ANIO,
            this.MARCA,
            this.CAPACIDADKILOS,
            this.CAPACIDADVOLUMEN});
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 456);
            this.dataGridView1.TabIndex = 2;
            // 
            // PLACA
            // 
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            // 
            // ANIO
            // 
            this.ANIO.HeaderText = "AÑO";
            this.ANIO.Name = "ANIO";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // CAPACIDADKILOS
            // 
            this.CAPACIDADKILOS.HeaderText = "CAPACIDAD KILOS";
            this.CAPACIDADKILOS.Name = "CAPACIDADKILOS";
            // 
            // CAPACIDADVOLUMEN
            // 
            this.CAPACIDADVOLUMEN.HeaderText = "CAPACIDAD VOLUMEN";
            this.CAPACIDADVOLUMEN.Name = "CAPACIDADVOLUMEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE CAMIONES";
            // 
            // MostrarCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(658, 505);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarCamiones";
            this.Text = "MostrarConductores";
            this.Load += new System.EventHandler(this.MostrarCamiones_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Utilities.Gradient gradient1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPACIDADKILOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPACIDADVOLUMEN;
    }
}