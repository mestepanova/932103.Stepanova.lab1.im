using System.Windows.Forms.DataVisualization.Charting;

namespace lab1_stepanova
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editWeight = new System.Windows.Forms.NumericUpDown();
            this.editSize = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.editStep = new System.Windows.Forms.NumericUpDown();
            this.editAngle = new System.Windows.Forms.NumericUpDown();
            this.editSpeed = new System.Windows.Forms.NumericUpDown();
            this.editHeight = new System.Windows.Forms.NumericUpDown();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editWeight);
            this.panel1.Controls.Add(this.editSize);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.editStep);
            this.panel1.Controls.Add(this.editAngle);
            this.panel1.Controls.Add(this.editSpeed);
            this.panel1.Controls.Add(this.editHeight);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 435);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Масса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Размер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Шаг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Угол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Скорость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Высота";
            // 
            // editWeight
            // 
            this.editWeight.DecimalPlaces = 2;
            this.editWeight.Location = new System.Drawing.Point(81, 178);
            this.editWeight.Name = "editWeight";
            this.editWeight.Size = new System.Drawing.Size(98, 20);
            this.editWeight.TabIndex = 12;
            // 
            // editSize
            // 
            this.editSize.DecimalPlaces = 2;
            this.editSize.Location = new System.Drawing.Point(81, 146);
            this.editSize.Name = "editSize";
            this.editSize.Size = new System.Drawing.Size(98, 20);
            this.editSize.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(13, 218);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 32);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Пуск";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // editStep
            // 
            this.editStep.DecimalPlaces = 3;
            this.editStep.Location = new System.Drawing.Point(81, 113);
            this.editStep.Name = "editStep";
            this.editStep.Size = new System.Drawing.Size(98, 20);
            this.editStep.TabIndex = 7;
            this.editStep.ThousandsSeparator = true;
            // 
            // editAngle
            // 
            this.editAngle.Location = new System.Drawing.Point(81, 80);
            this.editAngle.Name = "editAngle";
            this.editAngle.Size = new System.Drawing.Size(98, 20);
            this.editAngle.TabIndex = 6;
            // 
            // editSpeed
            // 
            this.editSpeed.Location = new System.Drawing.Point(81, 49);
            this.editSpeed.Name = "editSpeed";
            this.editSpeed.Size = new System.Drawing.Size(98, 20);
            this.editSpeed.TabIndex = 5;
            // 
            // editHeight
            // 
            this.editHeight.Location = new System.Drawing.Point(81, 19);
            this.editHeight.Name = "editHeight";
            this.editHeight.Size = new System.Drawing.Size(98, 20);
            this.editHeight.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.LightBlue;
            this.chart.BorderlineWidth = 2;
            chartArea1.AxisX.Maximum = 50D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 50D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(225, 9);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.LabelBorderWidth = 3;
            series1.LabelForeColor = System.Drawing.Color.RosyBrown;
            series1.Legend = "Legend1";
            series1.Name = "График 1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.LabelBorderWidth = 3;
            series2.LabelForeColor = System.Drawing.Color.DarkOrange;
            series2.Legend = "Legend1";
            series2.Name = "График 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.LabelBorderWidth = 3;
            series3.LabelForeColor = System.Drawing.Color.DeepSkyBlue;
            series3.Legend = "Legend1";
            series3.Name = "График 3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.LabelBorderWidth = 3;
            series4.LabelForeColor = System.Drawing.Color.Indigo;
            series4.Legend = "Legend1";
            series4.Name = "График 4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.LabelBorderWidth = 3;
            series5.LabelForeColor = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "График 5";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(530, 434);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown editWeight;
        private System.Windows.Forms.NumericUpDown editSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown editStep;
        private System.Windows.Forms.NumericUpDown editAngle;
        private System.Windows.Forms.NumericUpDown editSpeed;
        private System.Windows.Forms.NumericUpDown editHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;

    }
}

