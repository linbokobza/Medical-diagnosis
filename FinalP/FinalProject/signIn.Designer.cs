namespace FinalProject
{
    partial class signIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_form = new System.Windows.Forms.TextBox();
            this.password_form = new System.Windows.Forms.TextBox();
            this.ID_form = new System.Windows.Forms.TextBox();
            this.btnSignIn_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "סיסמה:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "שם משתמש:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(399, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "תעודת זהות:";
            // 
            // username_form
            // 
            this.username_form.Location = new System.Drawing.Point(228, 92);
            this.username_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_form.Name = "username_form";
            this.username_form.Size = new System.Drawing.Size(148, 26);
            this.username_form.TabIndex = 11;
            // 
            // password_form
            // 
            this.password_form.Location = new System.Drawing.Point(228, 145);
            this.password_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_form.Name = "password_form";
            this.password_form.Size = new System.Drawing.Size(148, 26);
            this.password_form.TabIndex = 8;
            // 
            // ID_form
            // 
            this.ID_form.Location = new System.Drawing.Point(228, 35);
            this.ID_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_form.Name = "ID_form";
            this.ID_form.Size = new System.Drawing.Size(148, 26);
            this.ID_form.TabIndex = 7;
            // 
            // btnSignIn_form
            // 
            this.btnSignIn_form.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSignIn_form.FlatAppearance.BorderSize = 0;
            this.btnSignIn_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn_form.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn_form.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignIn_form.Location = new System.Drawing.Point(274, 215);
            this.btnSignIn_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignIn_form.Name = "btnSignIn_form";
            this.btnSignIn_form.Size = new System.Drawing.Size(237, 45);
            this.btnSignIn_form.TabIndex = 12;
            this.btnSignIn_form.Text = "הרשמה";
            this.btnSignIn_form.UseVisualStyleBackColor = false;
            this.btnSignIn_form.Click += new System.EventHandler(this.btnSignIn_form_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.password_form);
            this.panel1.Controls.Add(this.username_form);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ID_form);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 198);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(13, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignIn_form);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "signIn";
            this.Text = "signIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_form;
        private System.Windows.Forms.TextBox password_form;
        private System.Windows.Forms.TextBox ID_form;
        private System.Windows.Forms.Button btnSignIn_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}