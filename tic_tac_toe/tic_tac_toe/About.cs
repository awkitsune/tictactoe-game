using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void comboBox_rps_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_rps.SelectedIndex;
            switch (index)
            {
                case 0: label_answer.Text = "Computer says paper"; break;
                case 1: label_answer.Text = "Computer says scissors"; break;
                case 2: label_answer.Text = "Computer says rock"; break;
                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/awkitsune/tictactoe-game");
        }
    }
}
