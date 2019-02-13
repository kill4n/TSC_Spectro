using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace SpectroPhotometer_2019_TSC
{
    public partial class Form1 : Form
    {
        #region Variable declarations
        /// <summary>
        /// Variable for enable read
        /// </summary>
        private bool readEnabled;
        /// <summary>
        /// Variable to write the text file
        /// </summary>
        StreamWriter sw;
        /// <summary>
        /// List to hold the values to create the mean
        /// </summary>
        List<double> mean = new List<double>();
        #endregion

        public Form1()
        {
            InitializeComponent();                                  // Start Function, don't touch XD.
            refreshPorts();                                         // Call function to refresh serial ports availables.
            serialPort1.DataReceived += SerialPort1_DataReceived;   // Connect to a function activated when serial data recieved.
        }

        /// <summary>
        /// Funcion para recibir y procesar los datos.
        /// </summary>
        /// <param name="sender">Object that calls the function</param>
        /// <param name="e">Arguments of function</param>
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Start Try - Catch block.
            try
            {
                string linea = serialPort1.ReadLine();  // Read data from serial port until characters "\r\n".
                int dato;   //Temporal variable to hold integer read value.
                if (int.TryParse(linea, out dato) & readEnabled)    // Read data on 'linea' and store it un data, also validate readEnable variable.
                {
                    UpdateChart(dato);  // Call UpdateChar function
                }
            }
            catch (Exception ex) //Catch any exception, to prevent the program to exit with an error.
            {

            }
        }

        /// <summary>
        /// Method to thread safe Update text on textbox.
        /// </summary>
        /// <param name="dato">Value to update text</param>
        private void UpdateText(double dato)
        {
            if (textBox1.InvokeRequired)    // Validate if textbox1 needs invocation.
            {
                //Invocate textBox and call again the UpdateText function.
                textBox1.Invoke(new Action(() =>
                {
                    UpdateText(dato);
                }
                ));
            }
            else
            {
                textBox1.Text = dato.ToString(); // Update TextBox value.
            }
        }

        /// <summary>
        /// Method to safetly update chart
        /// </summary>
        /// <param name="dato"></param>
        private void UpdateChart(int dato)
        {
            if (chart1.InvokeRequired) // Validate if chart1 needs invocation.
            {
                //Invocate chart and call again the UpdateChart function.
                chart1.Invoke(new Action(() =>
                {
                    UpdateChart(dato);
                }
                ));
            }
            else
            {
                mean.Add(dato);                                 // Add new value to mean List.
                if (mean.Count > 10)                            // Check is mean list has more than 10 elements.
                    mean.RemoveAt(0);                           // Remove extra value to always have max 10 values on list.
                double mMean = 0;                               // Double variable to hold the mean.
                for (int i = 0; i < mean.Count; i++)            // Loop over all the values of the mean list.
                    mMean += mean[i];                           // Sum up all the values son list.

                mMean = mMean / mean.Count;                     // Divide mMean over the number of elements of List to obtain the mean.
                UpdateText(mMean);                              // Call UpdateText Method.
                chart1.Series[0].Points.AddY(mMean);            // Add new value to the chart.
                if (chart1.Series[0].Points.Count > 100)        // Check if chart has more than 100 points.
                    chart1.Series[0].Points.RemoveAt(0);        // Remove first value to ensure always have max 100 values on chart.

                chart1.ChartAreas[0].RecalculateAxesScale();    // Call Method to update the chart axis scale.
            }

        }

        /// <summary>
        /// Method to refresh available ports
        /// </summary>
        private void refreshPorts()
        {
            string[] puertos = SerialPort.GetPortNames();       // Get all port names and store in puertos variable.
            cbxPorts.Items.Clear();                             // Clear ports comboBox.
            for (int i = 0; i < puertos.Length; i++)            // Loop over all availables ports.
            {
                cbxPorts.Items.Add(puertos[i]);                 // Add one port to the ports comboBox
                cbxPorts.SelectedIndex = 0;                     // Select the first item as default in the comboBox.
            }

            lblStatus.Text = "Ports Found = " + puertos.Length; // Update status label
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshPorts();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                serialPort1.PortName = cbxPorts.SelectedItem.ToString();

                serialPort1.Open();

                serialPort1.ReadExisting();

                lblStatus.Text = "Connection succesfull at port " + serialPort1.PortName;

                btnConnect.Text = "Disconnect";

                btnSndLed.Enabled = true;
                btnSndFilter.Enabled = true;
                btnSndFreqScale.Enabled = true;
                btnSave.Enabled = false;
                btnStart.Enabled = true;
            }
            else
            {
                timer1.Stop();

                if (serialPort1.IsOpen)
                    serialPort1.Close();

                lblStatus.Text = "Disconnection succesfull at port " + serialPort1.PortName;

                btnConnect.Text = "Connect";
                btnStart.Text = "Start";

                btnStart.Enabled = false;
                btnSndLed.Enabled = false;
                btnSndFilter.Enabled = false;
                btnSndFreqScale.Enabled = false;
                btnSave.Enabled = true;

            }
        }

        private void btnSndLed_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (checkRed.Checked)
                    serialPort1.Write("R");
                else
                    serialPort1.Write("r");

                if (checkGreen.Checked)
                    serialPort1.Write("G");
                else
                    serialPort1.Write("g");

                if (checkBlue.Checked)
                    serialPort1.Write("B");
                else
                    serialPort1.Write("b");
            }
        }

        private void btnSndFilter_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (rbRed.Checked)
                    serialPort1.Write("X"); //Filtro Rojo
                if (rbBlue.Checked)
                    serialPort1.Write("Y"); //Filtro Azul
                if (rbGreen.Checked)
                    serialPort1.Write("Z"); //Filtro Verde
                if (rbClear.Checked)
                    serialPort1.Write("W"); //Filtro Clear
            }
        }

        private void btnSndFreqScale_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (rbOFF.Checked)
                    serialPort1.Write("0"); // Scale Off
                if (rb002.Checked)
                    serialPort1.Write("1"); // Scale 2%
                if (rb020.Checked)
                    serialPort1.Write("2"); // Scale 20%
                if (rb100.Checked)
                    serialPort1.Write("3"); // Scale 100%
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & readEnabled)
            {
                serialPort1.Write("@");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            mean.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                timer1.Start();
                readEnabled = true;
                btnStart.Text = "Stop";
                btnSave.Enabled = false;
            }
            else
            {
                timer1.Stop();
                readEnabled = true;
                btnStart.Text = "Start";
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 0)
            {
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        sw = new StreamWriter(saveFileDialog1.FileName);

                        sw.WriteLine(DateTime.Now.ToLongDateString());
                        sw.WriteLine(DateTime.Now.ToLongTimeString());


                        sw.WriteLine("Color Emited");
                        if (checkRed.Checked)
                            sw.WriteLine("Red");
                        else
                        {
                            if (checkGreen.Checked)
                                sw.WriteLine("Green");
                            else
                            {
                                if (checkBlue.Checked)
                                    sw.WriteLine("Green");
                                else
                                    sw.WriteLine("None");
                            }
                        }
                        sw.WriteLine("Filter Used");
                        if (rbRed.Checked)
                            sw.WriteLine("Red");   //Filtro Rojo
                        if (rbBlue.Checked)
                            sw.WriteLine("Blue"); //Filtro Azul
                        if (rbGreen.Checked)
                            sw.WriteLine("Green"); //Filtro Verde
                        if (rbClear.Checked)
                            sw.WriteLine("White"); //Filtro Clear

                        sw.WriteLine("Scale Frequency");
                        if (rbOFF.Checked)
                            sw.WriteLine("OFF"); // Scale Off
                        if (rb002.Checked)
                            sw.WriteLine("2%"); // Scale 2%
                        if (rb020.Checked)
                            sw.WriteLine("20%"); // Scale 20%
                        if (rb100.Checked)
                            sw.WriteLine("100%"); // Scale 100%

                        for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                            sw.WriteLine(chart1.Series[0].Points[i].YValues[0]);

                        sw.Flush();
                        sw.Close();

                    }
                }
            }
        }

        private void btnExportImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "";
                sfd.Filter = "Tiff Image|*.tiff|Png Image|*.png|Jpg Image|*.jpeg";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        switch (sfd.FilterIndex)
                        {
                            case 0://Tiff
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Tiff);
                                break;
                            case 1://png
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Png);
                                break;
                            case 2://jpg
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                                break;
                            default:
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Png);
                                break;
                        }
                    }
                }
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "";
                sfd.Filter = "Tiff Image|*.tiff|Png Image|*.png|Jpg Image|*.jpeg";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        switch (sfd.FilterIndex)
                        {
                            case 0://Tiff
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Tiff);
                                break;
                            case 1://png
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Png);
                                break;
                            case 2://jpg
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                                break;
                            default:
                                chart1.SaveImage(sfd.FileName, ChartImageFormat.Png);
                                break;
                        }
                        //Save file
                        string dir = sfd.FileName.Split('.').First() + ".txt";
                        sw = new StreamWriter(dir);

                        sw.WriteLine(DateTime.Now.ToLongDateString());
                        sw.WriteLine(DateTime.Now.ToLongTimeString());


                        sw.WriteLine("Color Emited");
                        if (checkRed.Checked)
                            sw.WriteLine("Red");
                        else
                        {
                            if (checkGreen.Checked)
                                sw.WriteLine("Green");
                            else
                            {
                                if (checkBlue.Checked)
                                    sw.WriteLine("Green");
                                else
                                    sw.WriteLine("None");
                            }
                        }
                        sw.WriteLine("Filter Used");
                        if (rbRed.Checked)
                            sw.WriteLine("Red");   //Filtro Rojo
                        if (rbBlue.Checked)
                            sw.WriteLine("Blue"); //Filtro Azul
                        if (rbGreen.Checked)
                            sw.WriteLine("Green"); //Filtro Verde
                        if (rbClear.Checked)
                            sw.WriteLine("White"); //Filtro Clear

                        sw.WriteLine("Scale Frequency");
                        if (rbOFF.Checked)
                            sw.WriteLine("OFF"); // Scale Off
                        if (rb002.Checked)
                            sw.WriteLine("2%"); // Scale 2%
                        if (rb020.Checked)
                            sw.WriteLine("20%"); // Scale 20%
                        if (rb100.Checked)
                            sw.WriteLine("100%"); // Scale 100%

                        for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                            sw.WriteLine(chart1.Series[0].Points[i].YValues[0]);

                        sw.Flush();
                        sw.Close();


                    }
                }
            }
        }
    }
}
