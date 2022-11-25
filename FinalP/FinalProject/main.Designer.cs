
namespace FinalProject
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnQus = new System.Windows.Forms.Button();
            this.btnDiag = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddM
            // 
            this.btnAddM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddM.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddM.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddM.Location = new System.Drawing.Point(8, 32);
            this.btnAddM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(137, 59);
            this.btnAddM.TabIndex = 0;
            this.btnAddM.Text = "הוספת מטופל";
            this.btnAddM.UseVisualStyleBackColor = false;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnQus
            // 
            this.btnQus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQus.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQus.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnQus.Location = new System.Drawing.Point(8, 190);
            this.btnQus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQus.Name = "btnQus";
            this.btnQus.Size = new System.Drawing.Size(137, 58);
            this.btnQus.TabIndex = 1;
            this.btnQus.Text = "יציאה";
            this.btnQus.UseVisualStyleBackColor = false;
            this.btnQus.Click += new System.EventHandler(this.btnQus_Click);
            // 
            // btnDiag
            // 
            this.btnDiag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiag.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiag.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDiag.Location = new System.Drawing.Point(8, 113);
            this.btnDiag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDiag.Name = "btnDiag";
            this.btnDiag.Size = new System.Drawing.Size(137, 58);
            this.btnDiag.TabIndex = 2;
            this.btnDiag.Text = "אבחנה רפואית";
            this.btnDiag.UseVisualStyleBackColor = false;
            this.btnDiag.Click += new System.EventHandler(this.btnDiag_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 280);
            this.Controls.Add(this.btnDiag);
            this.Controls.Add(this.btnQus);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQus;
        private System.Windows.Forms.Button btnDiag;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnAddM;
    }
}