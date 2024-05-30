using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoFinalProgra
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        List<Abastecimiento> abastecimientos = new List<Abastecimiento>();
        List<Reporte> reportes = new List<Reporte>();

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acceso denegado al puerto COM. Asegúrate de que no esté siendo utilizado por otra aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            if (data.Contains("OK"))
            {
                MessageBox.Show("Datos recibidos correctamente por el Arduino.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (data.Contains("Precio total:"))
            {
                string[] parts = data.Split(':');
                if (parts.Length == 2)
                {
                    string precioTotalStr = parts[1].Trim();
                    int precioTotal;
                    if (int.TryParse(precioTotalStr, out precioTotal))
                    {
                        MessageBox.Show($"El precio total es: {precioTotal}");
                    }
                }
            }
        }

        public void MostrarAbastecimientos()
        {
            //Mostrar la lista de Abastecimiento en el DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = reportes;
            dataGridView.Refresh();
        }

        private void buttonAbastecer_Click(object sender, EventArgs e)
        {
            // Obtener datos
            abastecimientos.Clear();
            Abastecimiento abastecimiento = new Abastecimiento();
            abastecimiento.Bomba = comboBoxBomba.Text;
            abastecimiento.Cliente = textBoxCliente.Text;
            abastecimiento.FechaHora = DateTime.Now;
            abastecimiento.Monto = textBoxMontoPagar.Text;
            abastecimiento.TipoAbastecimiento = comboBoxTipoAbastecimiento.Text;

            // Guardar datos
            abastecimientos.Add(abastecimiento);

            Reporte reporte = new Reporte();
            reporte.Bomba = abastecimiento.Bomba;
            reporte.Cliente = abastecimiento.Cliente;
            reporte.FechaHora = DateTime.Now;
            reporte.Monto = abastecimiento.Monto;
            reporte.TipoAbastecimiento = abastecimiento.TipoAbastecimiento;

            reportes.Add(reporte);

            MostrarAbastecimientos();
            GrabarAbastecimientos();
            GuardarDatosComoJson();

            textBoxCliente.Clear();
            textBoxMontoPagar.Clear();
        }

        private void GuardarDatosComoJson()
        {
            string json = JsonConvert.SerializeObject(abastecimientos, Formatting.Indented);
            File.WriteAllText("datos.json", json);

            EnviarDatosArduino(json);
        }

        private void EnviarDatosArduino(string datos)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(datos);
            }
            else
            {
                MessageBox.Show("El puerto COM no está abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrabarAbastecimientos()
        {
            FileStream stream = new FileStream("Abastecimientos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var abastecimiento in abastecimientos)
            {
                writer.WriteLine(abastecimiento.Cliente);
                writer.WriteLine(abastecimiento.FechaHora);
                writer.WriteLine(abastecimiento.Bomba);
                writer.WriteLine(abastecimiento.Monto);
                writer.WriteLine(abastecimiento.TipoAbastecimiento);
            }
            writer.Close();
        }

        private void buttonMostrarAbastecimiento_Click(object sender, EventArgs e)
        {
            // Ruta de archivo
            string filePath = "C:\\Users\\chipi\\Source\\Repos\\ProyectoFinalProgra\\bin\\Debug\\abastecimientos.txt";

            if (File.Exists(filePath))
            {
                FileStream flujo = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(flujo);

                // Limpiar el contenido previo del richTextBox
                richTextBox1.Clear();

                // Leer y mostrar el contenido del archivo en el richTextBox
                while (lector.Peek() > -1)
                {
                    richTextBox1.AppendText(lector.ReadLine() + "\n");
                }
                lector.Close();
            }
            else
            {
                MessageBox.Show("El archivo especificado no existe.");
            }
        }
    }
}

