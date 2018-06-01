namespace WindowsFormsClient
{
    partial class Weather
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabCelsius = new System.Windows.Forms.RadioButton();
            this.rabFahrenheit = new System.Windows.Forms.RadioButton();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblWeaCondition = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtWeaCondition = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabFahrenheit);
            this.groupBox1.Controls.Add(this.rabCelsius);
            this.groupBox1.Location = new System.Drawing.Point(95, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Type";
            // 
            // rabCelsius
            // 
            this.rabCelsius.AutoSize = true;
            this.rabCelsius.Location = new System.Drawing.Point(44, 39);
            this.rabCelsius.Name = "rabCelsius";
            this.rabCelsius.Size = new System.Drawing.Size(84, 19);
            this.rabCelsius.TabIndex = 0;
            this.rabCelsius.TabStop = true;
            this.rabCelsius.Text = "Celsius";
            this.rabCelsius.UseVisualStyleBackColor = true;
            // 
            // rabFahrenheit
            // 
            this.rabFahrenheit.AutoSize = true;
            this.rabFahrenheit.Location = new System.Drawing.Point(44, 75);
            this.rabFahrenheit.Name = "rabFahrenheit";
            this.rabFahrenheit.Size = new System.Drawing.Size(108, 19);
            this.rabFahrenheit.TabIndex = 1;
            this.rabFahrenheit.TabStop = true;
            this.rabFahrenheit.Text = "Fahrenheit";
            this.rabFahrenheit.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(392, 75);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 15);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(395, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 25);
            this.txtCity.TabIndex = 2;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(95, 268);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(200, 23);
            this.btnGetWeather.TabIndex = 3;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblWeaCondition
            // 
            this.lblWeaCondition.AutoSize = true;
            this.lblWeaCondition.Location = new System.Drawing.Point(95, 397);
            this.lblWeaCondition.Name = "lblWeaCondition";
            this.lblWeaCondition.Size = new System.Drawing.Size(143, 15);
            this.lblWeaCondition.TabIndex = 4;
            this.lblWeaCondition.Text = "Weather Condition";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(98, 461);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(95, 15);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "Temperature";
            // 
            // txtWeaCondition
            // 
            this.txtWeaCondition.Location = new System.Drawing.Point(395, 397);
            this.txtWeaCondition.Name = "txtWeaCondition";
            this.txtWeaCondition.Size = new System.Drawing.Size(183, 25);
            this.txtWeaCondition.TabIndex = 6;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(395, 461);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(183, 25);
            this.txtTemperature.TabIndex = 7;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 599);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtWeaCondition);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWeaCondition);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Weather";
            this.Text = "Weature";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabFahrenheit;
        private System.Windows.Forms.RadioButton rabCelsius;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeaCondition;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtWeaCondition;
        private System.Windows.Forms.TextBox txtTemperature;
    }
}