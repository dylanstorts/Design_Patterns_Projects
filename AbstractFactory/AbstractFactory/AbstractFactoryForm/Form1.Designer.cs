namespace AbstractFactoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_naginata = new System.Windows.Forms.Button();
            this.btn_pilum = new System.Windows.Forms.Button();
            this.btn_katana = new System.Windows.Forms.Button();
            this.btn_gladius = new System.Windows.Forms.Button();
            this.txtb_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Japanese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sword";
            // 
            // btn_naginata
            // 
            this.btn_naginata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_naginata.Location = new System.Drawing.Point(113, 71);
            this.btn_naginata.Name = "btn_naginata";
            this.btn_naginata.Size = new System.Drawing.Size(96, 36);
            this.btn_naginata.TabIndex = 4;
            this.btn_naginata.Text = "Naginata";
            this.btn_naginata.UseVisualStyleBackColor = true;
            this.btn_naginata.Click += new System.EventHandler(this.btn_naginata_Click);
            // 
            // btn_pilum
            // 
            this.btn_pilum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pilum.Location = new System.Drawing.Point(242, 71);
            this.btn_pilum.Name = "btn_pilum";
            this.btn_pilum.Size = new System.Drawing.Size(96, 36);
            this.btn_pilum.TabIndex = 5;
            this.btn_pilum.Text = "Pilum";
            this.btn_pilum.UseVisualStyleBackColor = true;
            this.btn_pilum.Click += new System.EventHandler(this.btn_pilum_Click);
            // 
            // btn_katana
            // 
            this.btn_katana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_katana.Location = new System.Drawing.Point(113, 123);
            this.btn_katana.Name = "btn_katana";
            this.btn_katana.Size = new System.Drawing.Size(96, 36);
            this.btn_katana.TabIndex = 6;
            this.btn_katana.Text = "Katana";
            this.btn_katana.UseVisualStyleBackColor = true;
            this.btn_katana.Click += new System.EventHandler(this.btn_katana_Click);
            // 
            // btn_gladius
            // 
            this.btn_gladius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gladius.Location = new System.Drawing.Point(242, 123);
            this.btn_gladius.Name = "btn_gladius";
            this.btn_gladius.Size = new System.Drawing.Size(96, 36);
            this.btn_gladius.TabIndex = 7;
            this.btn_gladius.Text = "Gladius";
            this.btn_gladius.UseVisualStyleBackColor = true;
            this.btn_gladius.Click += new System.EventHandler(this.btn_gladius_Click);
            // 
            // txtb_desc
            // 
            this.txtb_desc.Location = new System.Drawing.Point(113, 180);
            this.txtb_desc.Multiline = true;
            this.txtb_desc.Name = "txtb_desc";
            this.txtb_desc.Size = new System.Drawing.Size(225, 164);
            this.txtb_desc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 356);
            this.Controls.Add(this.txtb_desc);
            this.Controls.Add(this.btn_gladius);
            this.Controls.Add(this.btn_katana);
            this.Controls.Add(this.btn_pilum);
            this.Controls.Add(this.btn_naginata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_naginata;
        private System.Windows.Forms.Button btn_pilum;
        private System.Windows.Forms.Button btn_katana;
        private System.Windows.Forms.Button btn_gladius;
        private System.Windows.Forms.TextBox txtb_desc;
    }
}

