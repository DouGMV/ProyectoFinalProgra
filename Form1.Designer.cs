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
            this.labelCierreCaja = new System.Windows.Forms.Label();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrepago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBombaMasUtilizada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBombaMenosUtilizada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTanque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbastecer
            // 
            this.buttonAbastecer.BackColor = System.Drawing.Color.Snow;
            this.buttonAbastecer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbastecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbastecer.Location = new System.Drawing.Point(336, 256);
            this.buttonAbastecer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbastecer.Name = "buttonAbastecer";
            this.buttonAbastecer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAbastecer.Size = new System.Drawing.Size(110, 48);
            this.buttonAbastecer.TabIndex = 0;
            this.buttonAbastecer.Text = "Abastecer";
            this.buttonAbastecer.UseVisualStyleBackColor = false;
            this.buttonAbastecer.Click += new System.EventHandler(this.buttonAbastecer_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(313, 138);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(147, 20);
            this.textBoxCliente.TabIndex = 1;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.ForeColor = System.Drawing.Color.Green;
            this.labelNombreCliente.Location = new System.Drawing.Point(28, 128);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(199, 29);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.ForeColor = System.Drawing.Color.Green;
            this.labelMonto.Location = new System.Drawing.Point(28, 167);
            this.labelMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(169, 29);
            this.labelMonto.TabIndex = 5;
            this.labelMonto.Text = "Monto a pagar:";
            // 
            // comboBoxBomba
            // 
            this.comboBoxBomba.FormattingEnabled = true;
            this.comboBoxBomba.Items.AddRange(new object[] {
            "Bomba 1",
            "Bomba 2"});
            this.comboBoxBomba.Location = new System.Drawing.Point(313, 96);
            this.comboBoxBomba.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBomba.Name = "comboBoxBomba";
            this.comboBoxBomba.Size = new System.Drawing.Size(147, 21);
            this.comboBoxBomba.TabIndex = 7;
            // 
            // labelBomba
            // 
            this.labelBomba.AutoSize = true;
            this.labelBomba.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBomba.ForeColor = System.Drawing.Color.Green;
            this.labelBomba.Location = new System.Drawing.Point(28, 87);
            this.labelBomba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBomba.Name = "labelBomba";
            this.labelBomba.Size = new System.Drawing.Size(90, 29);
            this.labelBomba.TabIndex = 8;
            this.labelBomba.Text = "Bomba:";
            // 
            // buttonMostrarAbastecimiento
            // 
            this.buttonMostrarAbastecimiento.BackColor = System.Drawing.Color.Snow;
            this.buttonMostrarAbastecimiento.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarAbastecimiento.Location = new System.Drawing.Point(313, 332);
            this.buttonMostrarAbastecimiento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMostrarAbastecimiento.Name = "buttonMostrarAbastecimiento";
            this.buttonMostrarAbastecimiento.Size = new System.Drawing.Size(163, 59);
            this.buttonMostrarAbastecimiento.TabIndex = 9;
            this.buttonMostrarAbastecimiento.Text = "Abastecimientos Previos";
            this.buttonMostrarAbastecimiento.UseVisualStyleBackColor = false;
            this.buttonMostrarAbastecimiento.Click += new System.EventHandler(this.buttonMostrarAbastecimiento_Click);
            // 
            // textBoxMontoPagar
            // 
            this.textBoxMontoPagar.Location = new System.Drawing.Point(313, 177);
            this.textBoxMontoPagar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMontoPagar.Name = "textBoxMontoPagar";
            this.textBoxMontoPagar.Size = new System.Drawing.Size(147, 20);
            this.textBoxMontoPagar.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(561, 11);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(608, 197);
            this.dataGridView.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(561, 215);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(608, 218);
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
            this.comboBoxTipoAbastecimiento.Location = new System.Drawing.Point(313, 214);
            this.comboBoxTipoAbastecimiento.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoAbastecimiento.Name = "comboBoxTipoAbastecimiento";
            this.comboBoxTipoAbastecimiento.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTipoAbastecimiento.TabIndex = 14;
            // 
            // labelMetodoAbastecimiento
            // 
            this.labelMetodoAbastecimiento.AutoSize = true;
            this.labelMetodoAbastecimiento.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoAbastecimiento.ForeColor = System.Drawing.Color.Green;
            this.labelMetodoAbastecimiento.Location = new System.Drawing.Point(28, 206);
            this.labelMetodoAbastecimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMetodoAbastecimiento.Name = "labelMetodoAbastecimiento";
            this.labelMetodoAbastecimiento.Size = new System.Drawing.Size(240, 29);
            this.labelMetodoAbastecimiento.TabIndex = 15;
            this.labelMetodoAbastecimiento.Text = "Tipo de abastecimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proyecto Final Programación 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProgra.Properties.Resources.Logo_meso;
            this.pictureBox1.Location = new System.Drawing.Point(561, 455);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelCierreCaja
            // 
            this.labelCierreCaja.AutoSize = true;
            this.labelCierreCaja.Location = new System.Drawing.Point(233, 419);
            this.labelCierreCaja.Name = "labelCierreCaja";
            this.labelCierreCaja.Size = new System.Drawing.Size(35, 13);
            this.labelCierreCaja.TabIndex = 18;
            this.labelCierreCaja.Text = "label2";
            this.labelCierreCaja.Visible = false;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.BackColor = System.Drawing.Color.Snow;
            this.buttonEstadisticas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEstadisticas.Location = new System.Drawing.Point(31, 332);
            this.buttonEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEstadisticas.Size = new System.Drawing.Size(125, 54);
            this.buttonEstadisticas.TabIndex = 19;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = false;
            this.buttonEstadisticas.Click += new System.EventHandler(this.buttonEstadisticas_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cierre de caja diario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Abastecimiento por prepago limitado:";
            // 
            // labelPrepago
            // 
            this.labelPrepago.AutoSize = true;
            this.labelPrepago.Location = new System.Drawing.Point(233, 455);
            this.labelPrepago.Name = "labelPrepago";
            this.labelPrepago.Size = new System.Drawing.Size(35, 13);
            this.labelPrepago.TabIndex = 22;
            this.labelPrepago.Text = "label4";
            this.labelPrepago.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bomba más utilizada:";
            // 
            // labelBombaMasUtilizada
            // 
            this.labelBombaMasUtilizada.AutoSize = true;
            this.labelBombaMasUtilizada.Location = new System.Drawing.Point(233, 530);
            this.labelBombaMasUtilizada.Name = "labelBombaMasUtilizada";
            this.labelBombaMasUtilizada.Size = new System.Drawing.Size(35, 13);
            this.labelBombaMasUtilizada.TabIndex = 24;
            this.labelBombaMasUtilizada.Text = "label6";
            this.labelBombaMasUtilizada.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bomba menos utilizada:";
            // 
            // labelBombaMenosUtilizada
            // 
            this.labelBombaMenosUtilizada.AutoSize = true;
            this.labelBombaMenosUtilizada.Location = new System.Drawing.Point(233, 565);
            this.labelBombaMenosUtilizada.Name = "labelBombaMenosUtilizada";
            this.labelBombaMenosUtilizada.Size = new System.Drawing.Size(35, 13);
            this.labelBombaMenosUtilizada.TabIndex = 26;
            this.labelBombaMenosUtilizada.Text = "label8";
            this.labelBombaMenosUtilizada.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Abastecimiento por Tanque lleno:";
            // 
            // labelTanque
            // 
            this.labelTanque.AutoSize = true;
            this.labelTanque.Location = new System.Drawing.Point(233, 494);
            this.labelTanque.Name = "labelTanque";
            this.labelTanque.Size = new System.Drawing.Size(35, 13);
            this.labelTanque.TabIndex = 28;
            this.labelTanque.Text = "label7";
            this.labelTanque.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1180, 616);
            this.Controls.Add(this.labelTanque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBombaMenosUtilizada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBombaMasUtilizada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPrepago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEstadisticas);
            this.Controls.Add(this.labelCierreCaja);
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
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.buttonAbastecer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Proyecto Final";
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
        private System.Windows.Forms.Label labelCierreCaja;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrepago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBombaMasUtilizada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBombaMenosUtilizada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTanque;
    }
}

