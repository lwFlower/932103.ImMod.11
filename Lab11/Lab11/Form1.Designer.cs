namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StartBt = new System.Windows.Forms.Button();
            this.countN = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.varc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.meanc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TorFTxt = new System.Windows.Forms.Label();
            this.ChiTxt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.VarianceTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AverageTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StartBt);
            this.splitContainer1.Panel1.Controls.Add(this.countN);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.varc);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.meanc);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(918, 502);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // StartBt
            // 
            this.StartBt.Location = new System.Drawing.Point(64, 336);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(149, 35);
            this.StartBt.TabIndex = 12;
            this.StartBt.Text = "Старт";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // countN
            // 
            this.countN.Location = new System.Drawing.Point(172, 254);
            this.countN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countN.Name = "countN";
            this.countN.Size = new System.Drawing.Size(84, 22);
            this.countN.TabIndex = 11;
            this.countN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(51, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sample size";
            // 
            // varc
            // 
            this.varc.DecimalPlaces = 2;
            this.varc.Location = new System.Drawing.Point(172, 203);
            this.varc.Name = "varc";
            this.varc.Size = new System.Drawing.Size(84, 22);
            this.varc.TabIndex = 7;
            this.varc.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variance";
            // 
            // meanc
            // 
            this.meanc.DecimalPlaces = 2;
            this.meanc.Location = new System.Drawing.Point(172, 149);
            this.meanc.Name = "meanc";
            this.meanc.Size = new System.Drawing.Size(84, 22);
            this.meanc.TabIndex = 5;
            this.meanc.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(76, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mean";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TorFTxt);
            this.panel1.Controls.Add(this.ChiTxt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.VarianceTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.AverageTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 119);
            this.panel1.TabIndex = 1;
            // 
            // TorFTxt
            // 
            this.TorFTxt.AutoSize = true;
            this.TorFTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TorFTxt.Location = new System.Drawing.Point(264, 83);
            this.TorFTxt.Name = "TorFTxt";
            this.TorFTxt.Size = new System.Drawing.Size(56, 20);
            this.TorFTxt.TabIndex = 6;
            this.TorFTxt.Text = "is true";
            // 
            // ChiTxt
            // 
            this.ChiTxt.AutoSize = true;
            this.ChiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChiTxt.Location = new System.Drawing.Point(136, 83);
            this.ChiTxt.Name = "ChiTxt";
            this.ChiTxt.Size = new System.Drawing.Size(109, 20);
            this.ChiTxt.TabIndex = 5;
            this.ChiTxt.Text = "13.51 > 9.488";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(20, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Chi-squared: ";
            // 
            // VarianceTxt
            // 
            this.VarianceTxt.AutoSize = true;
            this.VarianceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarianceTxt.Location = new System.Drawing.Point(101, 50);
            this.VarianceTxt.Name = "VarianceTxt";
            this.VarianceTxt.Size = new System.Drawing.Size(49, 20);
            this.VarianceTxt.TabIndex = 3;
            this.VarianceTxt.Text = "2.876";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(20, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Variance:";
            // 
            // AverageTxt
            // 
            this.AverageTxt.AutoSize = true;
            this.AverageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageTxt.Location = new System.Drawing.Point(101, 15);
            this.AverageTxt.Name = "AverageTxt";
            this.AverageTxt.Size = new System.Drawing.Size(49, 20);
            this.AverageTxt.TabIndex = 1;
            this.AverageTxt.Text = "2.876";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Average:";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(609, 377);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown countN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown varc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown meanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button StartBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TorFTxt;
        private System.Windows.Forms.Label ChiTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label VarianceTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AverageTxt;
        private System.Windows.Forms.Label label8;
    }
}

