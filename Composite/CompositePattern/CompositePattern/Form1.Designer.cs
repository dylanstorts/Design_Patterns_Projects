namespace CompositePattern
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
            this.btn_generateBuilding = new System.Windows.Forms.Button();
            this.txtb_buildingInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generateBuilding
            // 
            this.btn_generateBuilding.Location = new System.Drawing.Point(34, 21);
            this.btn_generateBuilding.Name = "btn_generateBuilding";
            this.btn_generateBuilding.Size = new System.Drawing.Size(180, 68);
            this.btn_generateBuilding.TabIndex = 0;
            this.btn_generateBuilding.Text = "GenerateOffices";
            this.btn_generateBuilding.UseVisualStyleBackColor = true;
            this.btn_generateBuilding.Click += new System.EventHandler(this.btn_generateBuilding_Click);
            // 
            // txtb_buildingInfo
            // 
            this.txtb_buildingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_buildingInfo.Location = new System.Drawing.Point(12, 117);
            this.txtb_buildingInfo.Multiline = true;
            this.txtb_buildingInfo.Name = "txtb_buildingInfo";
            this.txtb_buildingInfo.Size = new System.Drawing.Size(241, 361);
            this.txtb_buildingInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 481);
            this.Controls.Add(this.txtb_buildingInfo);
            this.Controls.Add(this.btn_generateBuilding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generateBuilding;
        private System.Windows.Forms.TextBox txtb_buildingInfo;
    }
}

