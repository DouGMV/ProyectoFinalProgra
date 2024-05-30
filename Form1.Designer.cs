namespace ProyectoFinalProgra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAbastecer = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonGenerarEstadisticas = new System.Windows.Forms.Button();
            this.comboBoxBomba = new System.Windows.Forms.ComboBox();
            this.labelBomba = new System.Windows.Forms.Label();
            this.buttonMostrarAbastecimiento = new System.Windows.Forms.Button();
            this.textBoxMontoPagar = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxTipoAbastecimiento = new System.Windows.Forms.ComboBox();
            this.labelMetodoAbastecimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbastecer
            // 
            this.buttonAbastecer.BackColor = System.Drawing.Color.Snow;
            this.buttonAbastecer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbastecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbastecer.Location = new System.Drawing.Point(64, 322);
            this.buttonAbastecer.Name = "buttonAbastecer";
            this.buttonAbastecer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAbastecer.Size = new System.Drawing.Size(187, 85);
            this.buttonAbastecer.TabIndex = 0;
            this.buttonAbastecer.Text = "Abastecer";
            this.buttonAbastecer.UseVisualStyleBackColor = false;
            this.buttonAbastecer.Click += new System.EventHandler(this.buttonAbastecer_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(308, 171);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(195, 22);
            this.textBoxCliente.TabIndex = 1;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.ForeColor = System.Drawing.Color.Green;
            this.labelNombreCliente.Location = new System.Drawing.Point(37, 158);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(247, 37);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.ForeColor = System.Drawing.Color.Green;
            this.labelMonto.Location = new System.Drawing.Point(37, 205);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(209, 37);
            this.labelMonto.TabIndex = 5;
            this.labelMonto.Text = "Monto a pagar:";
            // 
            // buttonGenerarEstadisticas
            // 
            this.buttonGenerarEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.buttonGenerarEstadisticas.Name = "buttonGenerarEstadisticas";
            this.buttonGenerarEstadisticas.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerarEstadisticas.TabIndex = 11;
            // 
            // comboBoxBomba
            // 
            this.comboBoxBomba.FormattingEnabled = true;
            this.comboBoxBomba.Items.AddRange(new object[] {
            "Bomba 1",
            "Bomba 2"});
            this.comboBoxBomba.Location = new System.Drawing.Point(171, 120);
            this.comboBoxBomba.Name = "comboBoxBomba";
            this.comboBoxBomba.Size = new System.Drawing.Size(218, 24);
            this.comboBoxBomba.TabIndex = 7;
            // 
            // labelBomba
            // 
            this.labelBomba.AutoSize = true;
            this.labelBomba.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBomba.ForeColor = System.Drawing.Color.Green;
            this.labelBomba.Location = new System.Drawing.Point(37, 107);
            this.labelBomba.Name = "labelBomba";
            this.labelBomba.Size = new System.Drawing.Size(112, 37);
            this.labelBomba.TabIndex = 8;
            this.labelBomba.Text = "Bomba:";
            // 
            // buttonMostrarAbastecimiento
            // 
            this.buttonMostrarAbastecimiento.BackColor = System.Drawing.Color.Snow;
            this.buttonMostrarAbastecimiento.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarAbastecimiento.Location = new System.Drawing.Point(280, 322);
            this.buttonMostrarAbastecimiento.Name = "buttonMostrarAbastecimiento";
            this.buttonMostrarAbastecimiento.Size = new System.Drawing.Size(223, 85);
            this.buttonMostrarAbastecimiento.TabIndex = 9;
            this.buttonMostrarAbastecimiento.Text = "Abastecimientos Previos";
            this.buttonMostrarAbastecimiento.UseVisualStyleBackColor = false;
            this.buttonMostrarAbastecimiento.Click += new System.EventHandler(this.buttonMostrarAbastecimiento_Click);
            // 
            // textBoxMontoPagar
            // 
            this.textBoxMontoPagar.Location = new System.Drawing.Point(280, 218);
            this.textBoxMontoPagar.Name = "textBoxMontoPagar";
            this.textBoxMontoPagar.Size = new System.Drawing.Size(195, 22);
            this.textBoxMontoPagar.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(537, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(613, 243);
            this.dataGridView.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gold;
            this.richTextBox1.Location = new System.Drawing.Point(537, 265);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 268);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBoxTipoAbastecimiento
            // 
            this.comboBoxTipoAbastecimiento.FormattingEnabled = true;
            this.comboBoxTipoAbastecimiento.Items.AddRange(new object[] {
            "Prepago limitado",
            "Tanque lleno"});
            this.comboBoxTipoAbastecimiento.Location = new System.Drawing.Point(357, 265);
            this.comboBoxTipoAbastecimiento.Name = "comboBoxTipoAbastecimiento";
            this.comboBoxTipoAbastecimiento.Size = new System.Drawing.Size(146, 24);
            this.comboBoxTipoAbastecimiento.TabIndex = 14;
            // 
            // labelMetodoAbastecimiento
            // 
            this.labelMetodoAbastecimiento.AutoSize = true;
            this.labelMetodoAbastecimiento.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoAbastecimiento.ForeColor = System.Drawing.Color.Green;
            this.labelMetodoAbastecimiento.Location = new System.Drawing.Point(37, 252);
            this.labelMetodoAbastecimiento.Name = "labelMetodoAbastecimiento";
            this.labelMetodoAbastecimiento.Size = new System.Drawing.Size(294, 37);
            this.labelMetodoAbastecimiento.TabIndex = 15;
            this.labelMetodoAbastecimiento.Text = "Tipo de abastecimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proyecto Final Programación 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProgra.Properties.Resources.Logo_meso;
            this.pictureBox1.Location = new System.Drawing.Point(537, 539);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1175, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMetodoAbastecimiento);
            this.Controls.Add(this.comboBoxTipoAbastecimiento);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxMontoPagar);
            this.Controls.Add(this.buttonMostrarAbastecimiento);
            this.Controls.Add(this.labelBomba);
            this.Controls.Add(this.comboBoxBomba);
            this.Controls.Add(this.buttonGenerarEstadisticas);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.buttonAbastecer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbastecer;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonGenerarEstadisticas;
        private System.Windows.Forms.ComboBox comboBoxBomba;
        private System.Windows.Forms.Label labelBomba;
        private System.Windows.Forms.Button buttonMostrarAbastecimiento;
        private System.Windows.Forms.TextBox textBoxMontoPagar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoAbastecimiento;
        private System.Windows.Forms.Label labelMetodoAbastecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

