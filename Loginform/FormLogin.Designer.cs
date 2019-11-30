namespace Loginform
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeicon = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.txticon2 = new System.Windows.Forms.PictureBox();
            this.txticon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(200, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(200, 327);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // closeicon
            // 
            this.closeicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeicon.Image = ((System.Drawing.Image)(resources.GetObject("closeicon.Image")));
            this.closeicon.Location = new System.Drawing.Point(488, 8);
            this.closeicon.Name = "closeicon";
            this.closeicon.Size = new System.Drawing.Size(22, 17);
            this.closeicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeicon.TabIndex = 8;
            this.closeicon.TabStop = false;
            this.closeicon.Click += new System.EventHandler(this.closeicon_Click);
            // 
            // icon2
            // 
            this.icon2.Image = global::Loginform.Properties.Resources.password;
            this.icon2.Location = new System.Drawing.Point(159, 321);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(31, 32);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2.TabIndex = 6;
            this.icon2.TabStop = false;
            // 
            // icon
            // 
            this.icon.Image = global::Loginform.Properties.Resources.username;
            this.icon.Location = new System.Drawing.Point(159, 248);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(31, 32);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // txticon2
            // 
            this.txticon2.Image = ((System.Drawing.Image)(resources.GetObject("txticon2.Image")));
            this.txticon2.Location = new System.Drawing.Point(141, 309);
            this.txticon2.Name = "txticon2";
            this.txticon2.Size = new System.Drawing.Size(221, 54);
            this.txticon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txticon2.TabIndex = 2;
            this.txticon2.TabStop = false;
            // 
            // txticon
            // 
            this.txticon.Image = ((System.Drawing.Image)(resources.GetObject("txticon.Image")));
            this.txticon.Location = new System.Drawing.Point(141, 235);
            this.txticon.Name = "txticon";
            this.txticon.Size = new System.Drawing.Size(221, 54);
            this.txticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txticon.TabIndex = 1;
            this.txticon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(106, 358);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(282, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.closeicon);
            this.Controls.Add(this.icon2);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txticon2);
            this.Controls.Add(this.txticon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.closeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox txticon;
        private System.Windows.Forms.PictureBox txticon2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox closeicon;
    }
}

