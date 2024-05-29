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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbastecer
            // 
            this.buttonAbastecer.Location = new System.Drawing.Point(266, 268);
            this.buttonAbastecer.Name = "buttonAbastecer";
            this.buttonAbastecer.Size = new System.Drawing.Size(105, 30);
            this.buttonAbastecer.TabIndex = 0;
            this.buttonAbastecer.Text = "Abastecer";
            this.buttonAbastecer.UseVisualStyleBackColor = true;
            this.buttonAbastecer.Click += new System.EventHandler(this.buttonAbastecer_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(238, 127);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(146, 22);
            this.textBoxCliente.TabIndex = 1;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(80, 127);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(123, 16);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(80, 172);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(97, 16);
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
            this.comboBoxBomba.Location = new System.Drawing.Point(238, 80);
            this.comboBoxBomba.Name = "comboBoxBomba";
            this.comboBoxBomba.Size = new System.Drawing.Size(146, 24);
            this.comboBoxBomba.TabIndex = 7;
            // 
            // labelBomba
            // 
            this.labelBomba.AutoSize = true;
            this.labelBomba.Location = new System.Drawing.Point(80, 80);
            this.labelBomba.Name = "labelBomba";
            this.labelBomba.Size = new System.Drawing.Size(54, 16);
            this.labelBomba.TabIndex = 8;
            this.labelBomba.Text = "Bomba:";
            // 
            // buttonMostrarAbastecimiento
            // 
            this.buttonMostrarAbastecimiento.Location = new System.Drawing.Point(256, 334);
            this.buttonMostrarAbastecimiento.Name = "buttonMostrarAbastecimiento";
            this.buttonMostrarAbastecimiento.Size = new System.Drawing.Size(125, 50);
            this.buttonMostrarAbastecimiento.TabIndex = 9;
            this.buttonMostrarAbastecimiento.Text = "Abastecimientos Previos";
            this.buttonMostrarAbastecimiento.UseVisualStyleBackColor = true;
            this.buttonMostrarAbastecimiento.Click += new System.EventHandler(this.buttonMostrarAbastecimiento_Click);
            // 
            // textBoxMontoPagar
            // 
            this.textBoxMontoPagar.Location = new System.Drawing.Point(238, 172);
            this.textBoxMontoPagar.Name = "textBoxMontoPagar";
            this.textBoxMontoPagar.Size = new System.Drawing.Size(146, 22);
            this.textBoxMontoPagar.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(433, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(240, 197);
            this.dataGridView.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(433, 272);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 150);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // comboBoxTipoAbastecimiento
            // 
            this.comboBoxTipoAbastecimiento.FormattingEnabled = true;
            this.comboBoxTipoAbastecimiento.Items.AddRange(new object[] {
            "Prepago limitado",
            "Tanque lleno"});
            this.comboBoxTipoAbastecimiento.Location = new System.Drawing.Point(238, 217);
            this.comboBoxTipoAbastecimiento.Name = "comboBoxTipoAbastecimiento";
            this.comboBoxTipoAbastecimiento.Size = new System.Drawing.Size(146, 24);
            this.comboBoxTipoAbastecimiento.TabIndex = 14;
            // 
            // labelMetodoAbastecimiento
            // 
            this.labelMetodoAbastecimiento.AutoSize = true;
            this.labelMetodoAbastecimiento.Location = new System.Drawing.Point(80, 220);
            this.labelMetodoAbastecimiento.Name = "labelMetodoAbastecimiento";
            this.labelMetodoAbastecimiento.Size = new System.Drawing.Size(152, 16);
            this.labelMetodoAbastecimiento.TabIndex = 15;
            this.labelMetodoAbastecimiento.Text = "Tipo de abastecimiento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}

