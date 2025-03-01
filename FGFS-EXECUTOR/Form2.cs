using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGFS_EXECUTOR
{
    public partial class Form2 : Form
    {
        private Dictionary<string, string> scriptDictionary = new Dictionary<string, string>
        {
            { "VexonHub [TSB]", "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/DiosDi/VexonHub/refs/heads/main/VexonHub\"))()" },
            { "infinite yield", "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()" },
            { "TOUCH FLING", "-- coming soon!" },
            { "insanity xyz [ARSENAL]", "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/helldevelopment/RobloxScripts/main/SanityLoader.lua\"))()" }
        };

        public Form2()
        {
            InitializeComponent();


            listBox1.Items.Add("VexonHub [TSB]");
            listBox1.Items.Add("infinite yield");
            listBox1.Items.Add("TOUCH FLING");
            listBox1.Items.Add("insanity xyz [ARSENAL]");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = listBox1.SelectedItem as string;
            if (selectedItem != null)
            {

                if (scriptDictionary.ContainsKey(selectedItem))
                {
                    CnameHT.Text = selectedItem;
                    CHscriptT.Text = scriptDictionary[selectedItem]; 
                }
            }
        }
    }
}