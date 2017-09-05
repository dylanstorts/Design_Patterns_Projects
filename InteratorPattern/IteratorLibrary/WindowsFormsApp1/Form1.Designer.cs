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
            this.SuspendLayout();
            // 
            // btn_iterateAll
            // 
            this.btn_iterateAll.Location = new System.Drawing.Point(32, 90);
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
            this.listbox_displayAll.Location = new System.Drawing.Point(152, 28);
            this.listbox_displayAll.Name = "listbox_displayAll";
            this.listbox_displayAll.Size = new System.Drawing.Size(120, 212);
            this.listbox_displayAll.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listbox_displayAll);
            this.Controls.Add(this.btn_iterateAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iterateAll;
        private System.Windows.Forms.ListBox listbox_displayAll;
    }
}

