namespace FacadeForm
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.checkbox_filterPower = new System.Windows.Forms.CheckBox();
            this.tbox_gpm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeater = new System.Windows.Forms.Panel();
            this.numUpDown_temp = new System.Windows.Forms.NumericUpDown();
            this.checkbox_heaterPower = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Feeder = new System.Windows.Forms.Panel();
            this.numUpDown_dose = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_frequency = new System.Windows.Forms.NumericUpDown();
            this.checkbox_feederPower = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Lights = new System.Windows.Forms.Panel();
            this.checkbox_lightPower = new System.Windows.Forms.CheckBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_facade = new System.Windows.Forms.Panel();
            this.numUpDown_tanksize = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_population = new System.Windows.Forms.NumericUpDown();
            this.combobox_color = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.combobox_type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelFilter.SuspendLayout();
            this.panelHeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_temp)).BeginInit();
            this.panel_Feeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_frequency)).BeginInit();
            this.panel_Lights.SuspendLayout();
            this.panel_facade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_tanksize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_population)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.checkbox_filterPower);
            this.panelFilter.Controls.Add(this.tbox_gpm);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Location = new System.Drawing.Point(37, 50);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(200, 100);
            this.panelFilter.TabIndex = 0;
            // 
            // checkbox_filterPower
            // 
            this.checkbox_filterPower.AutoSize = true;
            this.checkbox_filterPower.Location = new System.Drawing.Point(19, 32);
            this.checkbox_filterPower.Name = "checkbox_filterPower";
            this.checkbox_filterPower.Size = new System.Drawing.Size(56, 17);
            this.checkbox_filterPower.TabIndex = 4;
            this.checkbox_filterPower.Text = "Power";
            this.checkbox_filterPower.UseVisualStyleBackColor = true;
            // 
            // tbox_gpm
            // 
            this.tbox_gpm.Location = new System.Drawing.Point(109, 56);
            this.tbox_gpm.Name = "tbox_gpm";
            this.tbox_gpm.Size = new System.Drawing.Size(57, 20);
            this.tbox_gpm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate (g.p.m.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // panelHeater
            // 
            this.panelHeater.Controls.Add(this.numUpDown_temp);
            this.panelHeater.Controls.Add(this.checkbox_heaterPower);
            this.panelHeater.Controls.Add(this.label4);
            this.panelHeater.Controls.Add(this.label3);
            this.panelHeater.Location = new System.Drawing.Point(37, 175);
            this.panelHeater.Name = "panelHeater";
            this.panelHeater.Size = new System.Drawing.Size(200, 111);
            this.panelHeater.TabIndex = 1;
            // 
            // numUpDown_temp
            // 
            this.numUpDown_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_temp.Location = new System.Drawing.Point(47, 69);
            this.numUpDown_temp.Maximum = new decimal(new int[] {
            82,
            0,
            0,
            0});
            this.numUpDown_temp.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numUpDown_temp.Name = "numUpDown_temp";
            this.numUpDown_temp.Size = new System.Drawing.Size(56, 31);
            this.numUpDown_temp.TabIndex = 5;
            this.numUpDown_temp.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // checkbox_heaterPower
            // 
            this.checkbox_heaterPower.AutoSize = true;
            this.checkbox_heaterPower.Location = new System.Drawing.Point(19, 33);
            this.checkbox_heaterPower.Name = "checkbox_heaterPower";
            this.checkbox_heaterPower.Size = new System.Drawing.Size(56, 17);
            this.checkbox_heaterPower.TabIndex = 4;
            this.checkbox_heaterPower.Text = "Power";
            this.checkbox_heaterPower.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Temperature (Fahrenheit)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Heater";
            // 
            // panel_Feeder
            // 
            this.panel_Feeder.Controls.Add(this.numUpDown_dose);
            this.panel_Feeder.Controls.Add(this.numUpDown_frequency);
            this.panel_Feeder.Controls.Add(this.checkbox_feederPower);
            this.panel_Feeder.Controls.Add(this.label7);
            this.panel_Feeder.Controls.Add(this.label6);
            this.panel_Feeder.Controls.Add(this.label5);
            this.panel_Feeder.Location = new System.Drawing.Point(37, 313);
            this.panel_Feeder.Name = "panel_Feeder";
            this.panel_Feeder.Size = new System.Drawing.Size(200, 114);
            this.panel_Feeder.TabIndex = 2;
            // 
            // numUpDown_dose
            // 
            this.numUpDown_dose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_dose.Location = new System.Drawing.Point(109, 75);
            this.numUpDown_dose.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDown_dose.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_dose.Name = "numUpDown_dose";
            this.numUpDown_dose.Size = new System.Drawing.Size(65, 26);
            this.numUpDown_dose.TabIndex = 8;
            this.numUpDown_dose.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDown_frequency
            // 
            this.numUpDown_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_frequency.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDown_frequency.Location = new System.Drawing.Point(109, 44);
            this.numUpDown_frequency.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUpDown_frequency.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUpDown_frequency.Name = "numUpDown_frequency";
            this.numUpDown_frequency.Size = new System.Drawing.Size(65, 26);
            this.numUpDown_frequency.TabIndex = 7;
            this.numUpDown_frequency.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // checkbox_feederPower
            // 
            this.checkbox_feederPower.AutoSize = true;
            this.checkbox_feederPower.Location = new System.Drawing.Point(19, 23);
            this.checkbox_feederPower.Name = "checkbox_feederPower";
            this.checkbox_feederPower.Size = new System.Drawing.Size(56, 17);
            this.checkbox_feederPower.TabIndex = 6;
            this.checkbox_feederPower.Text = "Power";
            this.checkbox_feederPower.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dose Size (pinches)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Feed Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Feeder";
            // 
            // panel_Lights
            // 
            this.panel_Lights.Controls.Add(this.checkbox_lightPower);
            this.panel_Lights.Controls.Add(this.btn_color);
            this.panel_Lights.Controls.Add(this.comboColor);
            this.panel_Lights.Controls.Add(this.label9);
            this.panel_Lights.Controls.Add(this.label8);
            this.panel_Lights.Location = new System.Drawing.Point(37, 448);
            this.panel_Lights.Name = "panel_Lights";
            this.panel_Lights.Size = new System.Drawing.Size(200, 130);
            this.panel_Lights.TabIndex = 3;
            // 
            // checkbox_lightPower
            // 
            this.checkbox_lightPower.AutoSize = true;
            this.checkbox_lightPower.Location = new System.Drawing.Point(22, 30);
            this.checkbox_lightPower.Name = "checkbox_lightPower";
            this.checkbox_lightPower.Size = new System.Drawing.Size(56, 17);
            this.checkbox_lightPower.TabIndex = 5;
            this.checkbox_lightPower.Text = "Power";
            this.checkbox_lightPower.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_color.Location = new System.Drawing.Point(54, 85);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(30, 30);
            this.btn_color.TabIndex = 4;
            this.btn_color.UseVisualStyleBackColor = false;
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "White",
            "No Color"});
            this.comboColor.Location = new System.Drawing.Point(64, 58);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(80, 21);
            this.comboColor.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lights";
            // 
            // panel_facade
            // 
            this.panel_facade.Controls.Add(this.numUpDown_tanksize);
            this.panel_facade.Controls.Add(this.numUpDown_population);
            this.panel_facade.Controls.Add(this.combobox_color);
            this.panel_facade.Controls.Add(this.label14);
            this.panel_facade.Controls.Add(this.combobox_type);
            this.panel_facade.Controls.Add(this.label13);
            this.panel_facade.Controls.Add(this.label12);
            this.panel_facade.Controls.Add(this.label11);
            this.panel_facade.Controls.Add(this.label10);
            this.panel_facade.Location = new System.Drawing.Point(279, 109);
            this.panel_facade.Name = "panel_facade";
            this.panel_facade.Size = new System.Drawing.Size(200, 177);
            this.panel_facade.TabIndex = 4;
            // 
            // numUpDown_tanksize
            // 
            this.numUpDown_tanksize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_tanksize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_tanksize.Location = new System.Drawing.Point(104, 40);
            this.numUpDown_tanksize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDown_tanksize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_tanksize.Name = "numUpDown_tanksize";
            this.numUpDown_tanksize.Size = new System.Drawing.Size(84, 26);
            this.numUpDown_tanksize.TabIndex = 11;
            this.numUpDown_tanksize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_tanksize.ValueChanged += new System.EventHandler(this.numUpDown_tanksize_ValueChanged);
            // 
            // numUpDown_population
            // 
            this.numUpDown_population.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_population.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDown_population.Location = new System.Drawing.Point(104, 76);
            this.numUpDown_population.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDown_population.Name = "numUpDown_population";
            this.numUpDown_population.Size = new System.Drawing.Size(84, 26);
            this.numUpDown_population.TabIndex = 10;
            this.numUpDown_population.ValueChanged += new System.EventHandler(this.numUpDown_population_ValueChanged);
            // 
            // combobox_color
            // 
            this.combobox_color.FormattingEnabled = true;
            this.combobox_color.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "White",
            "No Color"});
            this.combobox_color.Location = new System.Drawing.Point(104, 144);
            this.combobox_color.Name = "combobox_color";
            this.combobox_color.Size = new System.Drawing.Size(84, 21);
            this.combobox_color.TabIndex = 9;
            this.combobox_color.SelectedIndexChanged += new System.EventHandler(this.combobox_color_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Light Color";
            // 
            // combobox_type
            // 
            this.combobox_type.FormattingEnabled = true;
            this.combobox_type.Items.AddRange(new object[] {
            "Freshwater",
            "Saltwater"});
            this.combobox_type.Location = new System.Drawing.Point(104, 116);
            this.combobox_type.Name = "combobox_type";
            this.combobox_type.Size = new System.Drawing.Size(84, 21);
            this.combobox_type.TabIndex = 6;
            this.combobox_type.SelectedIndexChanged += new System.EventHandler(this.combobox_type_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fish Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Population";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tank Size (gal)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tank Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 614);
            this.Controls.Add(this.panel_facade);
            this.Controls.Add(this.panel_Lights);
            this.Controls.Add(this.panel_Feeder);
            this.Controls.Add(this.panelHeater);
            this.Controls.Add(this.panelFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelHeater.ResumeLayout(false);
            this.panelHeater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_temp)).EndInit();
            this.panel_Feeder.ResumeLayout(false);
            this.panel_Feeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_frequency)).EndInit();
            this.panel_Lights.ResumeLayout(false);
            this.panel_Lights.PerformLayout();
            this.panel_facade.ResumeLayout(false);
            this.panel_facade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_tanksize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_population)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox tbox_gpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Feeder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_Lights;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.CheckBox checkbox_filterPower;
        private System.Windows.Forms.CheckBox checkbox_heaterPower;
        private System.Windows.Forms.CheckBox checkbox_feederPower;
        private System.Windows.Forms.CheckBox checkbox_lightPower;
        private System.Windows.Forms.Panel panel_facade;
        private System.Windows.Forms.ComboBox combobox_color;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combobox_type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numUpDown_temp;
        private System.Windows.Forms.NumericUpDown numUpDown_dose;
        private System.Windows.Forms.NumericUpDown numUpDown_frequency;
        private System.Windows.Forms.NumericUpDown numUpDown_population;
        private System.Windows.Forms.NumericUpDown numUpDown_tanksize;
    }
}

