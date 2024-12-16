namespace softer
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel_pic = new System.Windows.Forms.Panel();
            this.Exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.Enter = new Guna.UI2.WinForms.Guna2Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_pic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pic
            // 
            this.panel_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_pic.BackgroundImage")));
            this.panel_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_pic.Controls.Add(this.Exit);
            this.panel_pic.Controls.Add(this.Enter);
            this.panel_pic.Controls.Add(this.pass);
            this.panel_pic.Controls.Add(this.username);
            this.panel_pic.Location = new System.Drawing.Point(-2, 0);
            this.panel_pic.Name = "panel_pic";
            this.panel_pic.Size = new System.Drawing.Size(555, 545);
            this.panel_pic.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.color = System.Drawing.Color.Transparent;
            this.Exit.colorActive = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = null;
            this.Exit.ImagePosition = 20;
            this.Exit.ImageZoom = 50;
            this.Exit.LabelPosition = 41;
            this.Exit.LabelText = "";
            this.Exit.Location = new System.Drawing.Point(6, 6);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 43);
            this.Exit.TabIndex = 12;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Enter.Animated = true;
            this.Enter.AutoRoundedCorners = true;
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.Enter.BorderRadius = 16;
            this.Enter.CheckedState.Parent = this.Enter;
            this.Enter.CustomImages.Parent = this.Enter;
            this.Enter.FillColor = System.Drawing.Color.Teal;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.ForeColor = System.Drawing.Color.White;
            this.Enter.HoverState.Parent = this.Enter;
            this.Enter.Location = new System.Drawing.Point(217, 427);
            this.Enter.Name = "Enter";
            this.Enter.ShadowDecoration.Parent = this.Enter;
            this.Enter.Size = new System.Drawing.Size(116, 34);
            this.Enter.TabIndex = 11;
            this.Enter.Text = "تسجيل الدخول";
            this.Enter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(205, 390);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(142, 28);
            this.pass.TabIndex = 1;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(205, 358);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 28);
            this.username.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.username;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.pass;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(553, 546);
            this.Controls.Add(this.panel_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_pic.ResumeLayout(false);
            this.panel_pic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pic;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox username;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2Button Enter;
        private Bunifu.Framework.UI.BunifuTileButton Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}