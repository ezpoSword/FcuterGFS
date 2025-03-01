using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cxapi;

namespace FGFS_EXECUTOR
{
    public partial class Form1 : Form
    {
        private string currentVersion = "VRS:[1.2.2]";

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("press ok to open the cheat", "FGFS Cheat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckForUpdates(); 
        }

        private async void CheckForUpdates()
        {
            string siteVersion = await GetSiteVersion();

            if (!string.IsNullOrEmpty(siteVersion) && siteVersion != currentVersion)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "A new version is available. Would you like to download it?",
                    "Update Available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/ezpoSword/Roblox-FGFS_Executor");
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private async Task<string> GetSiteVersion()
        {
            string versionUrl = "https://raw.githubusercontent.com/ezpoSword/Roblox-FGFS_Executor/refs/heads/master/VRS5432";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string versionInfo = await client.GetStringAsync(versionUrl);
                    return versionInfo.Trim(); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to check the version. Please check your internet connection.");
                    return string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Api.UserAgent("FGFS cheat", 1);
        }


        private void Inject_Click(object sender, EventArgs e)
        {
            if (Api.IsRobloxOpen())
            {
                Api.Attach();
                Api.Execute("print('Injected!')");
            }
            else
            {
                MessageBox.Show("Roblox is not open", "FGFS Cheat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (Api.IsInjected())
            {
                Api.Execute(CheatScriptTextBox.Text);
            }
            else
            {
                MessageBox.Show("Roblox Not Injected", "FGFS Cheat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Robloxkill_Click(object sender, EventArgs e)
        {
            if (Api.IsRobloxOpen())
            {
                Api.KillRoblox();
            }
            else
            {
                MessageBox.Show("Roblox is not open", "FGFS Cheat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppName_Click(object sender, EventArgs e)
        {
        }

        private void KeySystemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void EnterKeyButton_Click(object sender, EventArgs e)
        {
            string apiUrl = $"https://mboost.me/e84";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, null);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("✅ Key verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KeySystemPanel.Visible = false;
                        BlockButtonPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid key! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show(); 
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (s, args) =>
            {
                label1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            };
            timer.Start();
        }

        private void Settingopenbutton_Click(object sender, EventArgs e)
        {
            SettingPanel.Visible = !SettingPanel.Visible;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = guna2ToggleSwitch1.Checked;
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            Api.SetAutoInject(guna2ToggleSwitch2.Checked);
        }

    }
}