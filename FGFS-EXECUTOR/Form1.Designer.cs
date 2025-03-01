namespace FGFS_EXECUTOR
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.AppName = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.KeySystemPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.KeySYStitle = new System.Windows.Forms.Label();
            this.EnterKeyButton = new Guna.UI2.WinForms.Guna2Button();
            this.BlockButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Settingopenbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.CheatScriptTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Robloxkill = new Guna.UI2.WinForms.Guna2Button();
            this.Execute = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.guna2ToggleSwitch3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.KeySystemPanel.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.AppName;
            this.guna2DragControl2.TransparentWhileDrag = false;
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
            this.AppName.Image = global::FGFS_EXECUTOR.Properties.Resources.Ekran_görüntüsü_2025_02_25_193836;
            this.AppName.ImageSize = new System.Drawing.Size(344, 48);
            this.AppName.Location = new System.Drawing.Point(12, 17);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(341, 48);
            this.AppName.TabIndex = 8;
            this.AppName.Click += new System.EventHandler(this.AppName_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "FGFS cheat";
            this.notifyIcon.BalloonTipTitle = "FGFS cheat";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FGFS cheat";
            this.notifyIcon.Visible = true;
            // 
            // KeySystemPanel
            // 
            this.KeySystemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeySystemPanel.Controls.Add(this.label1);
            this.KeySystemPanel.Controls.Add(this.KeySYStitle);
            this.KeySystemPanel.Controls.Add(this.EnterKeyButton);
            this.KeySystemPanel.Location = new System.Drawing.Point(12, 68);
            this.KeySystemPanel.Name = "KeySystemPanel";
            this.KeySystemPanel.Size = new System.Drawing.Size(587, 227);
            this.KeySystemPanel.TabIndex = 9;
            this.KeySystemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.KeySystemPanel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(121, 124);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(345, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KeySYStitle
            // 
            this.KeySYStitle.AutoSize = true;
            this.KeySYStitle.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySYStitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeySYStitle.Location = new System.Drawing.Point(3, 1);
            this.KeySYStitle.Name = "KeySYStitle";
            this.KeySYStitle.Size = new System.Drawing.Size(231, 49);
            this.KeySYStitle.TabIndex = 2;
            this.KeySYStitle.Text = "Key System";
            // 
            // EnterKeyButton
            // 
            this.EnterKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterKeyButton.Animated = true;
            this.EnterKeyButton.BorderRadius = 5;
            this.EnterKeyButton.BorderThickness = 1;
            this.EnterKeyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EnterKeyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EnterKeyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnterKeyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EnterKeyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EnterKeyButton.ForeColor = System.Drawing.Color.White;
            this.EnterKeyButton.Image = global::FGFS_EXECUTOR.Properties.Resources.PASSWORD;
            this.EnterKeyButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EnterKeyButton.Location = new System.Drawing.Point(202, 73);
            this.EnterKeyButton.Name = "EnterKeyButton";
            this.EnterKeyButton.PressedDepth = 37;
            this.EnterKeyButton.Size = new System.Drawing.Size(183, 48);
            this.EnterKeyButton.TabIndex = 0;
            this.EnterKeyButton.Text = "Log in to make the key system";
            this.EnterKeyButton.Click += new System.EventHandler(this.EnterKeyButton_Click);
            // 
            // BlockButtonPanel
            // 
            this.BlockButtonPanel.Location = new System.Drawing.Point(425, 12);
            this.BlockButtonPanel.Name = "BlockButtonPanel";
            this.BlockButtonPanel.Size = new System.Drawing.Size(112, 53);
            this.BlockButtonPanel.TabIndex = 10;
            // 
            // Settingopenbutton
            // 
            this.Settingopenbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settingopenbutton.Animated = true;
            this.Settingopenbutton.BorderRadius = 10;
            this.Settingopenbutton.BorderThickness = 1;
            this.Settingopenbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settingopenbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settingopenbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settingopenbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settingopenbutton.FillColor = System.Drawing.Color.Blue;
            this.Settingopenbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Settingopenbutton.ForeColor = System.Drawing.Color.White;
            this.Settingopenbutton.Image = global::FGFS_EXECUTOR.Properties.Resources.setting;
            this.Settingopenbutton.Location = new System.Drawing.Point(425, 12);
            this.Settingopenbutton.Name = "Settingopenbutton";
            this.Settingopenbutton.Size = new System.Drawing.Size(53, 53);
            this.Settingopenbutton.TabIndex = 11;
            this.Settingopenbutton.Click += new System.EventHandler(this.Settingopenbutton_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Blue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::FGFS_EXECUTOR.Properties.Resources.ScriptHub1;
            this.guna2Button2.Location = new System.Drawing.Point(484, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(53, 53);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // CheatScriptTextBox
            // 
            this.CheatScriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheatScriptTextBox.Animated = true;
            this.CheatScriptTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CheatScriptTextBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CheatScriptTextBox.BackgroundImage = global::FGFS_EXECUTOR.Properties.Resources.EDITOR;
            this.CheatScriptTextBox.BorderRadius = 10;
            this.CheatScriptTextBox.BorderThickness = 4;
            this.CheatScriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheatScriptTextBox.DefaultText = "print(\"created by = fgfs-captain deniz\")";
            this.CheatScriptTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CheatScriptTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CheatScriptTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CheatScriptTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CheatScriptTextBox.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.CheatScriptTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheatScriptTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheatScriptTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CheatScriptTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheatScriptTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CheatScriptTextBox.Location = new System.Drawing.Point(12, 71);
            this.CheatScriptTextBox.Multiline = true;
            this.CheatScriptTextBox.Name = "CheatScriptTextBox";
            this.CheatScriptTextBox.PlaceholderText = "";
            this.CheatScriptTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheatScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CheatScriptTextBox.SelectedText = "";
            this.CheatScriptTextBox.Size = new System.Drawing.Size(584, 173);
            this.CheatScriptTextBox.TabIndex = 7;
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
            this.guna2Button1.Image = global::FGFS_EXECUTOR.Properties.Resources.close;
            this.guna2Button1.Location = new System.Drawing.Point(543, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(53, 53);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Robloxkill
            // 
            this.Robloxkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Robloxkill.Animated = true;
            this.Robloxkill.BackColor = System.Drawing.Color.Transparent;
            this.Robloxkill.BorderRadius = 10;
            this.Robloxkill.BorderThickness = 1;
            this.Robloxkill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Robloxkill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Robloxkill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Robloxkill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Robloxkill.FillColor = System.Drawing.Color.Red;
            this.Robloxkill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Robloxkill.ForeColor = System.Drawing.Color.White;
            this.Robloxkill.Image = global::FGFS_EXECUTOR.Properties.Resources.close;
            this.Robloxkill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Robloxkill.Location = new System.Drawing.Point(12, 250);
            this.Robloxkill.Name = "Robloxkill";
            this.Robloxkill.Size = new System.Drawing.Size(127, 45);
            this.Robloxkill.TabIndex = 3;
            this.Robloxkill.Text = "Close Roblox";
            this.Robloxkill.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Robloxkill.Click += new System.EventHandler(this.Robloxkill_Click);
            // 
            // Execute
            // 
            this.Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Execute.Animated = true;
            this.Execute.BorderRadius = 10;
            this.Execute.BorderThickness = 1;
            this.Execute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Execute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Image = global::FGFS_EXECUTOR.Properties.Resources.play_button_arrowhead;
            this.Execute.Location = new System.Drawing.Point(500, 250);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(45, 45);
            this.Execute.TabIndex = 2;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Inject
            // 
            this.Inject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inject.Animated = true;
            this.Inject.BorderRadius = 10;
            this.Inject.BorderThickness = 1;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Image = global::FGFS_EXECUTOR.Properties.Resources.inject;
            this.Inject.Location = new System.Drawing.Point(551, 250);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(45, 45);
            this.Inject.TabIndex = 1;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingPanel.Controls.Add(this.guna2ToggleSwitch3);
            this.SettingPanel.Controls.Add(this.guna2ToggleSwitch2);
            this.SettingPanel.Controls.Add(this.guna2ToggleSwitch1);
            this.SettingPanel.Controls.Add(this.label4);
            this.SettingPanel.Controls.Add(this.label3);
            this.SettingPanel.Controls.Add(this.label2);
            this.SettingPanel.Controls.Add(this.SettingLabel);
            this.SettingPanel.Location = new System.Drawing.Point(12, 71);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(584, 224);
            this.SettingPanel.TabIndex = 10;
            this.SettingPanel.Visible = false;
            // 
            // guna2ToggleSwitch3
            // 
            this.guna2ToggleSwitch3.Animated = true;
            this.guna2ToggleSwitch3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.Location = new System.Drawing.Point(107, 112);
            this.guna2ToggleSwitch3.Name = "guna2ToggleSwitch3";
            this.guna2ToggleSwitch3.Size = new System.Drawing.Size(35, 17);
            this.guna2ToggleSwitch3.TabIndex = 6;
            this.guna2ToggleSwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.Animated = true;
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(76, 92);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(35, 17);
            this.guna2ToggleSwitch2.TabIndex = 5;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(76, 72);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 17);
            this.guna2ToggleSwitch1.TabIndex = 4;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coming soon..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "outo inject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TopMost";
            // 
            // SettingLabel
            // 
            this.SettingLabel.AutoSize = true;
            this.SettingLabel.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingLabel.Location = new System.Drawing.Point(3, 9);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(150, 49);
            this.SettingLabel.TabIndex = 0;
            this.SettingLabel.Text = "Setting";
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.BlockButtonPanel;
            this.guna2DragControl3.TransparentWhileDrag = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(608, 307);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.BlockButtonPanel);
            this.Controls.Add(this.Settingopenbutton);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.KeySystemPanel);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.CheatScriptTextBox);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Robloxkill);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Inject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FGFS CHEAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeySystemPanel.ResumeLayout(false);
            this.KeySystemPanel.PerformLayout();
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2Button Execute;
        private Guna.UI2.WinForms.Guna2Button Robloxkill;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox CheatScriptTextBox;
        private Guna.UI2.WinForms.Guna2Button AppName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel KeySystemPanel;
        private Guna.UI2.WinForms.Guna2Button EnterKeyButton;
        private System.Windows.Forms.Label KeySYStitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel BlockButtonPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button Settingopenbutton;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Label SettingLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}

