namespace Calculator
{
    partial class splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loaderprog = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(196, 101);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(145, 35);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Calculator";
            // 
            // loaderprog
            // 
            this.loaderprog.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.loaderprog.Location = new System.Drawing.Point(-3, 252);
            this.loaderprog.Name = "loaderprog";
            this.loaderprog.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loaderprog.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loaderprog.ShadowDecoration.Parent = this.loaderprog;
            this.loaderprog.Size = new System.Drawing.Size(487, 10);
            this.loaderprog.TabIndex = 2;
            this.loaderprog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnclose
            // 
            this.btnclose.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnclose.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnclose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Location = new System.Drawing.Point(438, -2);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(46, 36);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            // 
            // btnminimize
            // 
            this.btnminimize.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnminimize.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnminimize.CheckedState.Parent = this.btnminimize;
            this.btnminimize.CustomImages.Parent = this.btnminimize;
            this.btnminimize.FillColor = System.Drawing.Color.Transparent;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnminimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnminimize.HoverState.Parent = this.btnminimize;
            this.btnminimize.Location = new System.Drawing.Point(401, -2);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.ShadowDecoration.Parent = this.btnminimize;
            this.btnminimize.Size = new System.Drawing.Size(46, 36);
            this.btnminimize.TabIndex = 4;
            this.btnminimize.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.Calculator1;
            this.pictureBox1.Location = new System.Drawing.Point(106, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.loaderprog);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar loaderprog;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btnminimize;

    }
}

