namespace CmdPatternForm
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
            this.txtb_write = new System.Windows.Forms.TextBox();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_redo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_write
            // 
            this.txtb_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_write.Location = new System.Drawing.Point(30, 57);
            this.txtb_write.Multiline = true;
            this.txtb_write.Name = "txtb_write";
            this.txtb_write.Size = new System.Drawing.Size(378, 430);
            this.txtb_write.TabIndex = 0;
            this.txtb_write.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_write_KeyPress);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(65, 28);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(75, 23);
            this.btn_undo.TabIndex = 1;
            this.btn_undo.Text = "UNDO";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_redo
            // 
            this.btn_redo.Location = new System.Drawing.Point(285, 28);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(75, 23);
            this.btn_redo.TabIndex = 2;
            this.btn_redo.Text = "REDO";
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 513);
            this.Controls.Add(this.btn_redo);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.txtb_write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_write;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
    }
}

