namespace SpectroPhotometer_2019_TSC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBlue = new System.Windows.Forms.CheckBox();
            this.checkGreen = new System.Windows.Forms.CheckBox();
            this.checkRed = new System.Windows.Forms.CheckBox();
            this.btnSndLed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.btnSndFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb100 = new System.Windows.Forms.RadioButton();
            this.rb002 = new System.Windows.Forms.RadioButton();
            this.rb020 = new System.Windows.Forms.RadioButton();
            this.rbOFF = new System.Windows.Forms.RadioButton();
            this.btnSndFreqScale = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPorts
            // 
            this.cbxPorts.BackColor = System.Drawing.Color.GhostWhite;
            this.cbxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(92, 18);
            this.cbxPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(260, 28);
            this.cbxPorts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ports";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Location = new System.Drawing.Point(200, 58);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(154, 35);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(18, 60);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkBlue
            // 
            this.checkBlue.AutoSize = true;
            this.checkBlue.ForeColor = System.Drawing.Color.Blue;
            this.checkBlue.Location = new System.Drawing.Point(252, 105);
            this.checkBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBlue.Name = "checkBlue";
            this.checkBlue.Size = new System.Drawing.Size(91, 24);
            this.checkBlue.TabIndex = 6;
            this.checkBlue.Text = "Blue Led";
            this.checkBlue.UseVisualStyleBackColor = true;
            // 
            // checkGreen
            // 
            this.checkGreen.AutoSize = true;
            this.checkGreen.ForeColor = System.Drawing.Color.Green;
            this.checkGreen.Location = new System.Drawing.Point(129, 103);
            this.checkGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Size = new System.Drawing.Size(104, 24);
            this.checkGreen.TabIndex = 5;
            this.checkGreen.Text = "Green Led";
            this.checkGreen.UseVisualStyleBackColor = true;
            // 
            // checkRed
            // 
            this.checkRed.AutoSize = true;
            this.checkRed.ForeColor = System.Drawing.Color.Red;
            this.checkRed.Location = new System.Drawing.Point(18, 105);
            this.checkRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRed.Name = "checkRed";
            this.checkRed.Size = new System.Drawing.Size(89, 24);
            this.checkRed.TabIndex = 4;
            this.checkRed.Text = "Red Led";
            this.checkRed.UseVisualStyleBackColor = true;
            // 
            // btnSndLed
            // 
            this.btnSndLed.BackColor = System.Drawing.SystemColors.Control;
            this.btnSndLed.Enabled = false;
            this.btnSndLed.Location = new System.Drawing.Point(18, 142);
            this.btnSndLed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSndLed.Name = "btnSndLed";
            this.btnSndLed.Size = new System.Drawing.Size(336, 35);
            this.btnSndLed.TabIndex = 7;
            this.btnSndLed.Text = "Change LED color\r\n";
            this.btnSndLed.UseVisualStyleBackColor = false;
            this.btnSndLed.Click += new System.EventHandler(this.btnSndLed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClear);
            this.groupBox1.Controls.Add(this.rbBlue);
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Controls.Add(this.btnSndFilter);
            this.groupBox1.Location = new System.Drawing.Point(18, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(336, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(254, 29);
            this.rbClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(64, 24);
            this.rbClear.TabIndex = 3;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbBlue.Location = new System.Drawing.Point(86, 29);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(59, 24);
            this.rbBlue.TabIndex = 1;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.ForeColor = System.Drawing.Color.Green;
            this.rbGreen.Location = new System.Drawing.Point(164, 29);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(72, 24);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(9, 29);
            this.rbRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(57, 24);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // btnSndFilter
            // 
            this.btnSndFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnSndFilter.Enabled = false;
            this.btnSndFilter.Location = new System.Drawing.Point(9, 65);
            this.btnSndFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSndFilter.Name = "btnSndFilter";
            this.btnSndFilter.Size = new System.Drawing.Size(318, 35);
            this.btnSndFilter.TabIndex = 4;
            this.btnSndFilter.Text = "Change Filter";
            this.btnSndFilter.UseVisualStyleBackColor = false;
            this.btnSndFilter.Click += new System.EventHandler(this.btnSndFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb100);
            this.groupBox2.Controls.Add(this.rb002);
            this.groupBox2.Controls.Add(this.rb020);
            this.groupBox2.Controls.Add(this.rbOFF);
            this.groupBox2.Controls.Add(this.btnSndFreqScale);
            this.groupBox2.Location = new System.Drawing.Point(18, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(336, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outpuf Frequency Scaling";
            // 
            // rb100
            // 
            this.rb100.AutoSize = true;
            this.rb100.Location = new System.Drawing.Point(254, 29);
            this.rb100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb100.Name = "rb100";
            this.rb100.Size = new System.Drawing.Size(68, 24);
            this.rb100.TabIndex = 3;
            this.rb100.Text = "100%";
            this.rb100.UseVisualStyleBackColor = true;
            // 
            // rb002
            // 
            this.rb002.AutoSize = true;
            this.rb002.Location = new System.Drawing.Point(86, 29);
            this.rb002.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb002.Name = "rb002";
            this.rb002.Size = new System.Drawing.Size(50, 24);
            this.rb002.TabIndex = 1;
            this.rb002.Text = "2%";
            this.rb002.UseVisualStyleBackColor = true;
            // 
            // rb020
            // 
            this.rb020.AutoSize = true;
            this.rb020.Checked = true;
            this.rb020.Location = new System.Drawing.Point(164, 29);
            this.rb020.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb020.Name = "rb020";
            this.rb020.Size = new System.Drawing.Size(59, 24);
            this.rb020.TabIndex = 2;
            this.rb020.TabStop = true;
            this.rb020.Text = "20%";
            this.rb020.UseVisualStyleBackColor = true;
            // 
            // rbOFF
            // 
            this.rbOFF.AutoSize = true;
            this.rbOFF.Location = new System.Drawing.Point(9, 29);
            this.rbOFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOFF.Name = "rbOFF";
            this.rbOFF.Size = new System.Drawing.Size(59, 24);
            this.rbOFF.TabIndex = 0;
            this.rbOFF.Text = "OFF";
            this.rbOFF.UseVisualStyleBackColor = true;
            // 
            // btnSndFreqScale
            // 
            this.btnSndFreqScale.BackColor = System.Drawing.SystemColors.Control;
            this.btnSndFreqScale.Enabled = false;
            this.btnSndFreqScale.Location = new System.Drawing.Point(9, 65);
            this.btnSndFreqScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSndFreqScale.Name = "btnSndFreqScale";
            this.btnSndFreqScale.Size = new System.Drawing.Size(318, 35);
            this.btnSndFreqScale.TabIndex = 4;
            this.btnSndFreqScale.Text = "Send Frequency Scaling";
            this.btnSndFreqScale.UseVisualStyleBackColor = false;
            this.btnSndFreqScale.Click += new System.EventHandler(this.btnSndFreqScale_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1078, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.Text = "Status";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.Title = "Samples";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.Title = "Pulse Width (ms)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(363, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "TSC3200";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(702, 436);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Sensor Value";
            this.chart1.Titles.Add(title2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 431);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "00000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Value sensor:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(16, 509);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(193, 509);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(18, 467);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(334, 35);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            this.saveFileDialog1.Title = "Save data";
            // 
            // btnExportAll
            // 
            this.btnExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportAll.Location = new System.Drawing.Point(363, 509);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(702, 35);
            this.btnExportAll.TabIndex = 16;
            this.btnExportAll.Text = "Export Data+Image";
            this.btnExportAll.UseVisualStyleBackColor = false;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(363, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(702, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Export Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExportImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1078, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBlue);
            this.Controls.Add(this.checkGreen);
            this.Controls.Add(this.checkRed);
            this.Controls.Add(this.btnSndLed);
            this.Controls.Add(this.cbxPorts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Spectro Photometer TSC3200";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBlue;
        private System.Windows.Forms.CheckBox checkGreen;
        private System.Windows.Forms.CheckBox checkRed;
        private System.Windows.Forms.Button btnSndLed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.Button btnSndFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb100;
        private System.Windows.Forms.RadioButton rb002;
        private System.Windows.Forms.RadioButton rb020;
        private System.Windows.Forms.RadioButton rbOFF;
        private System.Windows.Forms.Button btnSndFreqScale;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button button1;
    }
}

