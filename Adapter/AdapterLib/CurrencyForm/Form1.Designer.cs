namespace CurrencyForm
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
            this.btn_new_calc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_new_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_new_amount = new System.Windows.Forms.TextBox();
            this.combob_new_to = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combob_new_from = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_amount = new System.Windows.Forms.TextBox();
            this.combob_to = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_new_calc
            // 
            this.btn_new_calc.Location = new System.Drawing.Point(512, 290);
            this.btn_new_calc.Name = "btn_new_calc";
            this.btn_new_calc.Size = new System.Drawing.Size(100, 23);
            this.btn_new_calc.TabIndex = 36;
            this.btn_new_calc.Text = "Calculate";
            this.btn_new_calc.UseVisualStyleBackColor = true;
            this.btn_new_calc.Click += new System.EventHandler(this.btn_new_calc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Result";
            // 
            // txtb_new_result
            // 
            this.txtb_new_result.Location = new System.Drawing.Point(512, 253);
            this.txtb_new_result.Name = "txtb_new_result";
            this.txtb_new_result.Size = new System.Drawing.Size(100, 20);
            this.txtb_new_result.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Amount";
            // 
            // txtb_new_amount
            // 
            this.txtb_new_amount.Location = new System.Drawing.Point(360, 253);
            this.txtb_new_amount.Name = "txtb_new_amount";
            this.txtb_new_amount.Size = new System.Drawing.Size(100, 20);
            this.txtb_new_amount.TabIndex = 32;
            // 
            // combob_new_to
            // 
            this.combob_new_to.AutoCompleteCustomSource.AddRange(new string[] {
            "Dollar",
            "Yen",
            "Pound",
            "Euro"});
            this.combob_new_to.FormattingEnabled = true;
            this.combob_new_to.Items.AddRange(new object[] {
            "dollar",
            "yen",
            "pound",
            "euro"});
            this.combob_new_to.Location = new System.Drawing.Point(199, 253);
            this.combob_new_to.Name = "combob_new_to";
            this.combob_new_to.Size = new System.Drawing.Size(121, 21);
            this.combob_new_to.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "To";
            // 
            // combob_new_from
            // 
            this.combob_new_from.AutoCompleteCustomSource.AddRange(new string[] {
            "Dollar",
            "Yen",
            "Pound",
            "Euro"});
            this.combob_new_from.FormattingEnabled = true;
            this.combob_new_from.Items.AddRange(new object[] {
            "dollar",
            "yen",
            "pound",
            "euro"});
            this.combob_new_from.Location = new System.Drawing.Point(28, 254);
            this.combob_new_from.Name = "combob_new_from";
            this.combob_new_from.Size = new System.Drawing.Size(121, 21);
            this.combob_new_from.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "From";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(512, 96);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 23);
            this.btn_calc.TabIndex = 27;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Result";
            // 
            // txtb_result
            // 
            this.txtb_result.Location = new System.Drawing.Point(512, 59);
            this.txtb_result.Name = "txtb_result";
            this.txtb_result.Size = new System.Drawing.Size(100, 20);
            this.txtb_result.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Amount";
            // 
            // txtb_amount
            // 
            this.txtb_amount.Location = new System.Drawing.Point(360, 59);
            this.txtb_amount.Name = "txtb_amount";
            this.txtb_amount.Size = new System.Drawing.Size(100, 20);
            this.txtb_amount.TabIndex = 23;
            // 
            // combob_to
            // 
            this.combob_to.FormattingEnabled = true;
            this.combob_to.Items.AddRange(new object[] {
            "dollar",
            "yen",
            "pound",
            "euro"});
            this.combob_to.Location = new System.Drawing.Point(199, 59);
            this.combob_to.Name = "combob_to";
            this.combob_to.Size = new System.Drawing.Size(121, 21);
            this.combob_to.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "U.S. Dollars ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new_calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_new_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_new_amount);
            this.Controls.Add(this.combob_new_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combob_new_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_amount);
            this.Controls.Add(this.combob_to);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new_calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_new_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_new_amount;
        private System.Windows.Forms.ComboBox combob_new_to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combob_new_from;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_amount;
        private System.Windows.Forms.ComboBox combob_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

