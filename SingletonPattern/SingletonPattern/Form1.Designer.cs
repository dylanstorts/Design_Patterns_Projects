namespace SingletonPattern
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
            this.Btn_getfish = new System.Windows.Forms.Button();
            this.Btn_releasefish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_keepfish = new System.Windows.Forms.Button();
            this.tb_justcaught = new System.Windows.Forms.TextBox();
            this.tb_livewell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_getfish
            // 
            this.Btn_getfish.Location = new System.Drawing.Point(55, 89);
            this.Btn_getfish.Name = "Btn_getfish";
            this.Btn_getfish.Size = new System.Drawing.Size(103, 23);
            this.Btn_getfish.TabIndex = 0;
            this.Btn_getfish.Text = "Get Another Fish";
            this.Btn_getfish.UseVisualStyleBackColor = true;
            this.Btn_getfish.Click += new System.EventHandler(this.Btn_getfish_Click);
            // 
            // Btn_releasefish
            // 
            this.Btn_releasefish.Location = new System.Drawing.Point(174, 100);
            this.Btn_releasefish.Name = "Btn_releasefish";
            this.Btn_releasefish.Size = new System.Drawing.Size(89, 23);
            this.Btn_releasefish.TabIndex = 1;
            this.Btn_releasefish.Text = "Release Fish";
            this.Btn_releasefish.UseVisualStyleBackColor = true;
            this.Btn_releasefish.Click += new System.EventHandler(this.Btn_releasefish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livewell:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Just Caught:";
            // 
            // Btn_keepfish
            // 
            this.Btn_keepfish.Location = new System.Drawing.Point(55, 119);
            this.Btn_keepfish.Name = "Btn_keepfish";
            this.Btn_keepfish.Size = new System.Drawing.Size(103, 23);
            this.Btn_keepfish.TabIndex = 4;
            this.Btn_keepfish.Text = "Keep Fish";
            this.Btn_keepfish.UseVisualStyleBackColor = true;
            this.Btn_keepfish.Click += new System.EventHandler(this.Btn_keepfish_Click);
            // 
            // tb_justcaught
            // 
            this.tb_justcaught.Location = new System.Drawing.Point(148, 153);
            this.tb_justcaught.Name = "tb_justcaught";
            this.tb_justcaught.Size = new System.Drawing.Size(100, 20);
            this.tb_justcaught.TabIndex = 5;
            // 
            // tb_livewell
            // 
            this.tb_livewell.Location = new System.Drawing.Point(148, 200);
            this.tb_livewell.Name = "tb_livewell";
            this.tb_livewell.Size = new System.Drawing.Size(100, 20);
            this.tb_livewell.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_livewell);
            this.Controls.Add(this.tb_justcaught);
            this.Controls.Add(this.Btn_keepfish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_releasefish);
            this.Controls.Add(this.Btn_getfish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_getfish;
        private System.Windows.Forms.Button Btn_releasefish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_keepfish;
        private System.Windows.Forms.TextBox tb_justcaught;
        private System.Windows.Forms.TextBox tb_livewell;
    }
}

