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
    public partial class Form1 : Form
    {
        Random rnd_icon = new Random();
        public void UpdateField(int[,] field) //make field cleaning
        {
            switch (field[0, 0])
            {
                case 0: break;
                case 1: button_0_0.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_0_0.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[1, 0])
            {
                case 0: break;
                case 1: button_1_0.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_1_0.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[2, 0])
            {
                case 0: break;
                case 1: button_2_0.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_2_0.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[0, 1])
            {
                case 0: break;
                case 1: button_0_1.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_0_1.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[1, 1])
            {
                case 0: break;
                case 1: button_1_1.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_1_1.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[2, 1])
            {
                case 0: break;
                case 1: button_2_1.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_2_1.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[0, 2])
            {
                case 0: break;
                case 1: button_0_2.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_0_2.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[1, 2])
            {
                case 0: break;
                case 1: button_1_2.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_1_2.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
            switch (field[2, 2])
            {
                case 0: break;
                case 1: button_2_2.Image = Image.FromFile($"cross_{rnd_icon.Next(1, 3)}.png"); break;
                case 2: button_2_2.Image = Image.FromFile($"zero_{rnd_icon.Next(1, 3)}.png"); break;
            }
        }
        public Form1()
        {
            InitializeComponent();

            panel_game.Enabled = false;
            ttt_field field = new ttt_field();

            UpdateField(field.FieldGet());
        }

        private void label_score_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            panel_game.Enabled = true;
        }
    }
}
