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
                case 0: label_answer.Text = "Компьютер отвечает бумагой"; break;
                case 1: label_answer.Text = "Компьютер отвечает ножницами"; break;
                case 2: label_answer.Text = "Компьютер отвечает камнем"; break;
                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/awkitsune/tictactoe-game");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 5))
            {
                case 0: label_program.ForeColor = Color.Orange; label_dev.Text = label_dev.Text + "🦊🦊🦊"; break;
                case 1: label_program.ForeColor = Color.Cyan; break;
                case 2: label_program.ForeColor = Color.Magenta; break;
                case 3: label_program.ForeColor = Color.DarkBlue; break;
                case 4: label_program.ForeColor = Color.Black; break;

            }
        }
    }
}
