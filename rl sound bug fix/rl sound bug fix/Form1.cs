using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rl_sound_bug_fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = string.Empty;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myPath = path + "\\SFX_AMB_CelebrationStadium.bnk";
                if (File.Exists(myPath))
                {
                    File.Delete(myPath);
                    MessageBox.Show("Success: Bug Fixed" + Environment.NewLine + "SFX_AMB_CelebrationStadium.bnk successfully deleted");
                }
                else
                {
                    MessageBox.Show("Error deleting 'SFX_AMB_CelebrationStadium.bnk'" + Environment.NewLine + "File does not exist");
                }
                
            }
            catch
            {
                MessageBox.Show("Error deleting 'SFX_AMB_CelebrationStadium.bnk'" + Environment.NewLine + "Please close Rocket League before attempting", "rl sound bug fix", MessageBoxButtons.OK); ;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Select Rocket League's CookedPCConsole" + Environment.NewLine + "eg. (F:\\Program Files (x86)\\Steam\\steamapps\\common\rocketleague\\TAGame\\CookedPCConsole)";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
                path = fbd.SelectedPath;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fixed by eric and natt", "rl sound bug fix", MessageBoxButtons.OK);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "eg. Path")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text == "")
            {
                textBox1.Text = "eg. Path";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "eg. Path";
            }
            else if (textBox1.Text == "eg. Path")
            {
                textBox1.Text = "";
            }
        }
    }
}
