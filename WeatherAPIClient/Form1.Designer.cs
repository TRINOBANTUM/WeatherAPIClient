namespace WeatherAPIClient
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
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.grpTemp = new System.Windows.Forms.GroupBox();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.grpWindSpeed = new System.Windows.Forms.GroupBox();
            this.radKph = new System.Windows.Forms.RadioButton();
            this.radMph = new System.Windows.Forms.RadioButton();
            this.grpTemp.SuspendLayout();
            this.grpWindSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(12, 135);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(429, 31);
            this.btnShowResults.TabIndex = 0;
            this.btnShowResults.Text = "Get Weather Averages for London";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(12, 179);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(177, 18);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temperature 0.0 Celsius  ";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(262, 179);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(153, 18);
            this.lblWindSpeed.TabIndex = 2;
            this.lblWindSpeed.Text = "Wind Speed 0.0 Mph  ";
            // 
            // grpTemp
            // 
            this.grpTemp.Controls.Add(this.radFahrenheit);
            this.grpTemp.Controls.Add(this.radCelsius);
            this.grpTemp.Location = new System.Drawing.Point(12, 12);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(176, 103);
            this.grpTemp.TabIndex = 4;
            this.grpTemp.TabStop = false;
            this.grpTemp.Text = "Temp";
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Location = new System.Drawing.Point(19, 21);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(74, 21);
            this.radCelsius.TabIndex = 4;
            this.radCelsius.TabStop = true;
            this.radCelsius.Text = "Celsius";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Location = new System.Drawing.Point(19, 48);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(97, 21);
            this.radFahrenheit.TabIndex = 5;
            this.radFahrenheit.TabStop = true;
            this.radFahrenheit.Text = "Fahrenheit";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // grpWindSpeed
            // 
            this.grpWindSpeed.Controls.Add(this.radKph);
            this.grpWindSpeed.Controls.Add(this.radMph);
            this.grpWindSpeed.Location = new System.Drawing.Point(265, 12);
            this.grpWindSpeed.Name = "grpWindSpeed";
            this.grpWindSpeed.Size = new System.Drawing.Size(176, 103);
            this.grpWindSpeed.TabIndex = 5;
            this.grpWindSpeed.TabStop = false;
            this.grpWindSpeed.Text = "Wind Speed";
            // 
            // radKph
            // 
            this.radKph.AutoSize = true;
            this.radKph.Location = new System.Drawing.Point(19, 48);
            this.radKph.Name = "radKph";
            this.radKph.Size = new System.Drawing.Size(54, 21);
            this.radKph.TabIndex = 5;
            this.radKph.TabStop = true;
            this.radKph.Text = "Kph";
            this.radKph.UseVisualStyleBackColor = true;
            // 
            // radMph
            // 
            this.radMph.AutoSize = true;
            this.radMph.Location = new System.Drawing.Point(19, 21);
            this.radMph.Name = "radMph";
            this.radMph.Size = new System.Drawing.Size(56, 21);
            this.radMph.TabIndex = 4;
            this.radMph.TabStop = true;
            this.radMph.Text = "Mph";
            this.radMph.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 237);
            this.Controls.Add(this.grpWindSpeed);
            this.Controls.Add(this.grpTemp);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnShowResults);
            this.Name = "Form1";
            this.Text = "WeatherAPIClient";
            this.grpTemp.ResumeLayout(false);
            this.grpTemp.PerformLayout();
            this.grpWindSpeed.ResumeLayout(false);
            this.grpWindSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.GroupBox grpTemp;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.RadioButton radCelsius;
        private System.Windows.Forms.GroupBox grpWindSpeed;
        private System.Windows.Forms.RadioButton radKph;
        private System.Windows.Forms.RadioButton radMph;
    }
}

