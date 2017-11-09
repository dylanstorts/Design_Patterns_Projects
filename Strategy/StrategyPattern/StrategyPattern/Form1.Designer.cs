namespace StrategyPattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_intA = new System.Windows.Forms.TextBox();
            this.txtb_intB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_default = new System.Windows.Forms.RadioButton();
            this.rbtn_recursive = new System.Windows.Forms.RadioButton();
            this.rbtn_reverseDivision = new System.Windows.Forms.RadioButton();
            this.groupBox_multiply = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.groupBox_multiply.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter two integers to multiply below.";
            // 
            // txtb_intA
            // 
            this.txtb_intA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_intA.Location = new System.Drawing.Point(191, 58);
            this.txtb_intA.Name = "txtb_intA";
            this.txtb_intA.Size = new System.Drawing.Size(184, 40);
            this.txtb_intA.TabIndex = 1;
            // 
            // txtb_intB
            // 
            this.txtb_intB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_intB.Location = new System.Drawing.Point(191, 115);
            this.txtb_intB.Name = "txtb_intB";
            this.txtb_intB.Size = new System.Drawing.Size(184, 40);
            this.txtb_intB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now select a method to multiply the given integers.";
            // 
            // rbtn_default
            // 
            this.rbtn_default.AutoSize = true;
            this.rbtn_default.Location = new System.Drawing.Point(17, 36);
            this.rbtn_default.Name = "rbtn_default";
            this.rbtn_default.Size = new System.Drawing.Size(123, 17);
            this.rbtn_default.TabIndex = 4;
            this.rbtn_default.TabStop = true;
            this.rbtn_default.Text = "Default Multiplication";
            this.rbtn_default.UseVisualStyleBackColor = true;
            // 
            // rbtn_recursive
            // 
            this.rbtn_recursive.AutoSize = true;
            this.rbtn_recursive.Location = new System.Drawing.Point(17, 59);
            this.rbtn_recursive.Name = "rbtn_recursive";
            this.rbtn_recursive.Size = new System.Drawing.Size(137, 17);
            this.rbtn_recursive.TabIndex = 5;
            this.rbtn_recursive.TabStop = true;
            this.rbtn_recursive.Text = "Recursive Multiplication";
            this.rbtn_recursive.UseVisualStyleBackColor = true;
            // 
            // rbtn_reverseDivision
            // 
            this.rbtn_reverseDivision.AutoSize = true;
            this.rbtn_reverseDivision.Location = new System.Drawing.Point(17, 82);
            this.rbtn_reverseDivision.Name = "rbtn_reverseDivision";
            this.rbtn_reverseDivision.Size = new System.Drawing.Size(185, 17);
            this.rbtn_reverseDivision.TabIndex = 6;
            this.rbtn_reverseDivision.TabStop = true;
            this.rbtn_reverseDivision.Text = "Reverse w/ Division Multiplication";
            this.rbtn_reverseDivision.UseVisualStyleBackColor = true;
            // 
            // groupBox_multiply
            // 
            this.groupBox_multiply.Controls.Add(this.rbtn_default);
            this.groupBox_multiply.Controls.Add(this.rbtn_reverseDivision);
            this.groupBox_multiply.Controls.Add(this.rbtn_recursive);
            this.groupBox_multiply.Location = new System.Drawing.Point(191, 232);
            this.groupBox_multiply.Name = "groupBox_multiply";
            this.groupBox_multiply.Size = new System.Drawing.Size(238, 114);
            this.groupBox_multiply.TabIndex = 7;
            this.groupBox_multiply.TabStop = false;
            this.groupBox_multiply.Text = "Multiply Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(261, 371);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 33);
            this.lbl_result.TabIndex = 9;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(471, 268);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(138, 63);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_multiplier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_multiply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_intB);
            this.Controls.Add(this.txtb_intA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_multiply.ResumeLayout(false);
            this.groupBox_multiply.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_intA;
        private System.Windows.Forms.TextBox txtb_intB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_default;
        private System.Windows.Forms.RadioButton rbtn_recursive;
        private System.Windows.Forms.RadioButton rbtn_reverseDivision;
        private System.Windows.Forms.GroupBox groupBox_multiply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_calculate;
    }
}

