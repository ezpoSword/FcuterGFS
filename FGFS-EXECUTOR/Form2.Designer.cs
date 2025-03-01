namespace FGFS_EXECUTOR
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TSBpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CnameHT = new System.Windows.Forms.Label();
            this.CHscriptT = new Guna.UI2.WinForms.Guna2TextBox();
            this.AppName = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TSBpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(15, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(175, 218);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TSBpanel
            // 
            this.TSBpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSBpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TSBpanel.Controls.Add(this.CnameHT);
            this.TSBpanel.Controls.Add(this.CHscriptT);
            this.TSBpanel.Location = new System.Drawing.Point(193, 71);
            this.TSBpanel.Name = "TSBpanel";
            this.TSBpanel.Size = new System.Drawing.Size(403, 218);
            this.TSBpanel.TabIndex = 8;
            // 
            // CnameHT
            // 
            this.CnameHT.AutoSize = true;
            this.CnameHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CnameHT.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnameHT.Location = new System.Drawing.Point(0, 0);
            this.CnameHT.Name = "CnameHT";
            this.CnameHT.Size = new System.Drawing.Size(94, 25);
            this.CnameHT.TabIndex = 1;
            this.CnameHT.Text = "CnameHT";
            // 
            // CHscriptT
            // 
            this.CHscriptT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CHscriptT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CHscriptT.DefaultText = "";
            this.CHscriptT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CHscriptT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CHscriptT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CHscriptT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CHscriptT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CHscriptT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CHscriptT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CHscriptT.Location = new System.Drawing.Point(3, 55);
            this.CHscriptT.Name = "CHscriptT";
            this.CHscriptT.PlaceholderText = "";
            this.CHscriptT.SelectedText = "";
            this.CHscriptT.Size = new System.Drawing.Size(397, 36);
            this.CHscriptT.TabIndex = 0;
            // 
            // AppName
            // 
            this.AppName.Animated = true;
            this.AppName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Image = global::FGFS_EXECUTOR.Properties.Resources.FGFScloud1;
            this.AppName.ImageSize = new System.Drawing.Size(64, 64);
            this.AppName.Location = new System.Drawing.Point(12, 12);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(57, 58);
            this.AppName.TabIndex = 9;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::FGFS_EXECUTOR.Properties.Resources.enter1;
            this.guna2Button1.Location = new System.Drawing.Point(543, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(53, 53);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.AppName;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Thanks For opening\r\n";
            this.notifyIcon.Visible = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(608, 307);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.TSBpanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = " FGFS CHEAT SCRIPT HUB";
            this.TSBpanel.ResumeLayout(false);
            this.TSBpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Panel TSBpanel;
        private Guna.UI2.WinForms.Guna2TextBox CHscriptT;
        private System.Windows.Forms.Label CnameHT;
        private Guna.UI2.WinForms.Guna2Button AppName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}