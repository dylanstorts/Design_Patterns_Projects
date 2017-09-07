namespace WindowsFormsApp1
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
            this.btn_iterateAll = new System.Windows.Forms.Button();
            this.listbox_displayAll = new System.Windows.Forms.ListBox();
            this.btn_IterateA = new System.Windows.Forms.Button();
            this.btn_IterateB = new System.Windows.Forms.Button();
            this.btn_IterateC = new System.Windows.Forms.Button();
            this.listbox_selected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_iterateAll
            // 
            this.btn_iterateAll.Location = new System.Drawing.Point(12, 12);
            this.btn_iterateAll.Name = "btn_iterateAll";
            this.btn_iterateAll.Size = new System.Drawing.Size(75, 23);
            this.btn_iterateAll.TabIndex = 0;
            this.btn_iterateAll.Text = "Iterate All";
            this.btn_iterateAll.UseVisualStyleBackColor = true;
            this.btn_iterateAll.Click += new System.EventHandler(this.btn_iterateAll_Click);
            // 
            // listbox_displayAll
            // 
            this.listbox_displayAll.FormattingEnabled = true;
            this.listbox_displayAll.Location = new System.Drawing.Point(12, 41);
            this.listbox_displayAll.Name = "listbox_displayAll";
            this.listbox_displayAll.Size = new System.Drawing.Size(120, 251);
            this.listbox_displayAll.TabIndex = 1;
            // 
            // btn_IterateA
            // 
            this.btn_IterateA.Location = new System.Drawing.Point(179, 41);
            this.btn_IterateA.Name = "btn_IterateA";
            this.btn_IterateA.Size = new System.Drawing.Size(75, 23);
            this.btn_IterateA.TabIndex = 2;
            this.btn_IterateA.Text = "Iterate A\'s";
            this.btn_IterateA.UseVisualStyleBackColor = true;
            this.btn_IterateA.Click += new System.EventHandler(this.btn_IterateA_Click);
            // 
            // btn_IterateB
            // 
            this.btn_IterateB.Location = new System.Drawing.Point(179, 82);
            this.btn_IterateB.Name = "btn_IterateB";
            this.btn_IterateB.Size = new System.Drawing.Size(75, 23);
            this.btn_IterateB.TabIndex = 3;
            this.btn_IterateB.Text = "Iterate B\'s";
            this.btn_IterateB.UseVisualStyleBackColor = true;
            this.btn_IterateB.Click += new System.EventHandler(this.btn_IterateB_Click);
            // 
            // btn_IterateC
            // 
            this.btn_IterateC.Location = new System.Drawing.Point(179, 121);
            this.btn_IterateC.Name = "btn_IterateC";
            this.btn_IterateC.Size = new System.Drawing.Size(75, 23);
            this.btn_IterateC.TabIndex = 4;
            this.btn_IterateC.Text = "Iterate C\'s";
            this.btn_IterateC.UseVisualStyleBackColor = true;
            this.btn_IterateC.Click += new System.EventHandler(this.btn_IterateC_Click);
            // 
            // listbox_selected
            // 
            this.listbox_selected.FormattingEnabled = true;
            this.listbox_selected.Location = new System.Drawing.Point(292, 41);
            this.listbox_selected.Name = "listbox_selected";
            this.listbox_selected.Size = new System.Drawing.Size(120, 199);
            this.listbox_selected.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.listbox_selected);
            this.Controls.Add(this.btn_IterateC);
            this.Controls.Add(this.btn_IterateB);
            this.Controls.Add(this.btn_IterateA);
            this.Controls.Add(this.listbox_displayAll);
            this.Controls.Add(this.btn_iterateAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iterateAll;
        private System.Windows.Forms.ListBox listbox_displayAll;
        private System.Windows.Forms.Button btn_IterateA;
        private System.Windows.Forms.Button btn_IterateB;
        private System.Windows.Forms.Button btn_IterateC;
        private System.Windows.Forms.ListBox listbox_selected;
    }
}

