namespace ObserverPatternForm
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
            this.checkb_red = new System.Windows.Forms.CheckBox();
            this.checkb_green = new System.Windows.Forms.CheckBox();
            this.checkb_blue = new System.Windows.Forms.CheckBox();
            this.btn_led = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkb_red
            // 
            this.checkb_red.AutoSize = true;
            this.checkb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_red.Location = new System.Drawing.Point(62, 40);
            this.checkb_red.Name = "checkb_red";
            this.checkb_red.Size = new System.Drawing.Size(70, 29);
            this.checkb_red.TabIndex = 0;
            this.checkb_red.Text = "Red";
            this.checkb_red.UseVisualStyleBackColor = true;
            this.checkb_red.CheckedChanged += new System.EventHandler(this.checkb_red_CheckedChanged);
            // 
            // checkb_green
            // 
            this.checkb_green.AutoSize = true;
            this.checkb_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_green.Location = new System.Drawing.Point(12, 121);
            this.checkb_green.Name = "checkb_green";
            this.checkb_green.Size = new System.Drawing.Size(90, 29);
            this.checkb_green.TabIndex = 1;
            this.checkb_green.Text = "Green";
            this.checkb_green.UseVisualStyleBackColor = true;
            this.checkb_green.CheckedChanged += new System.EventHandler(this.checkb_green_CheckedChanged);
            // 
            // checkb_blue
            // 
            this.checkb_blue.AutoSize = true;
            this.checkb_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_blue.Location = new System.Drawing.Point(118, 121);
            this.checkb_blue.Name = "checkb_blue";
            this.checkb_blue.Size = new System.Drawing.Size(74, 29);
            this.checkb_blue.TabIndex = 2;
            this.checkb_blue.Text = "Blue";
            this.checkb_blue.UseVisualStyleBackColor = true;
            this.checkb_blue.CheckedChanged += new System.EventHandler(this.checkb_blue_CheckedChanged);
            // 
            // btn_led
            // 
            this.btn_led.Location = new System.Drawing.Point(57, 181);
            this.btn_led.Name = "btn_led";
            this.btn_led.Size = new System.Drawing.Size(75, 75);
            this.btn_led.TabIndex = 3;
            this.btn_led.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 277);
            this.Controls.Add(this.btn_led);
            this.Controls.Add(this.checkb_blue);
            this.Controls.Add(this.checkb_green);
            this.Controls.Add(this.checkb_red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkb_red;
        private System.Windows.Forms.CheckBox checkb_green;
        private System.Windows.Forms.CheckBox checkb_blue;
        private System.Windows.Forms.Button btn_led;
    }
}

