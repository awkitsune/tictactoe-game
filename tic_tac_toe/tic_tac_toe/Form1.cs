﻿using System;
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
        Move move = new Move();
        ttt_field field = new ttt_field();

        bool isPlaying = false;
        public void UpdateField(int[,] gameField) //make field cleaning
        {
            switch (gameField[0, 0])
            {
                case 0: button_0_0.Image = null; break;
                case 1: button_0_0.Image = Image.FromFile($"cross_{field.GetIcon(0, 0)}.png"); break;
                case 2: button_0_0.Image = Image.FromFile($"zero_{field.GetIcon(0, 0)}.png"); break;
            }
            switch (gameField[1, 0])
            {
                case 0: button_1_0.Image = null; break;
                case 1: button_1_0.Image = Image.FromFile($"cross_{field.GetIcon(1, 0)}.png"); break;
                case 2: button_1_0.Image = Image.FromFile($"zero_{field.GetIcon(1, 0)}.png"); break;
            }
            switch (gameField[2, 0])
            {
                case 0: button_2_0.Image = null; break;
                case 1: button_2_0.Image = Image.FromFile($"cross_{field.GetIcon(2, 0)}.png"); break;
                case 2: button_2_0.Image = Image.FromFile($"zero_{field.GetIcon(2, 0)}.png"); break;
            }
            switch (gameField[0, 1])
            {
                case 0: button_0_1.Image = null; break;
                case 1: button_0_1.Image = Image.FromFile($"cross_{field.GetIcon(0, 1)}.png"); break;
                case 2: button_0_1.Image = Image.FromFile($"zero_{field.GetIcon(0, 1)}.png"); break;
            }
            switch (gameField[1, 1])
            {
                case 0: button_1_1.Image = null; break;
                case 1: button_1_1.Image = Image.FromFile($"cross_{field.GetIcon(1, 1)}.png"); break;
                case 2: button_1_1.Image = Image.FromFile($"zero_{field.GetIcon(1, 1)}.png"); break;
            }
            switch (gameField[2, 1])
            {
                case 0: button_2_1.Image = null; break;
                case 1: button_2_1.Image = Image.FromFile($"cross_{field.GetIcon(2, 1)}.png"); break;
                case 2: button_2_1.Image = Image.FromFile($"zero_{field.GetIcon(2, 1)}.png"); break;
            }
            switch (gameField[0, 2])
            {
                case 0: button_0_2.Image = null; break;
                case 1: button_0_2.Image = Image.FromFile($"cross_{field.GetIcon(0, 2)}.png"); break;
                case 2: button_0_2.Image = Image.FromFile($"zero_{field.GetIcon(0, 2)}.png"); break;
            }
            switch (gameField[1, 2])
            {
                case 0: button_1_2.Image = null; break;
                case 1: button_1_2.Image = Image.FromFile($"cross_{field.GetIcon(1, 2)}.png"); break;
                case 2: button_1_2.Image = Image.FromFile($"zero_{field.GetIcon(1, 2)}.png"); break;
            }
            switch (gameField[2, 2])
            {
                case 0: button_2_2.Image = null; break;
                case 1: button_2_2.Image = Image.FromFile($"cross_{field.GetIcon(2, 2)}.png"); break;
                case 2: button_2_2.Image = Image.FromFile($"zero_{field.GetIcon(2, 2)}.png"); break;
            }
        }

        public Form1()
        {
            InitializeComponent();

            panel_game.Enabled = false;

            UpdateField(field.GetField());
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
            if (isPlaying) //hmm, i think it's check for playing!
            {
                DialogResult result = MessageBox.Show(
                        "Do you really would like to restart your game?", 
                        "Restart?", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    field.Flush();
                    UpdateField(field.GetField());
                }
            }
            else //not playing
            {
                panel_game.Enabled = true;
                button_restart.Text = "Restart?";
                isPlaying = true;
            }
            
        }



        private void button_0_0_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(0, 0);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }

        }

        private void button_1_0_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(1, 0);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_2_0_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(2, 0);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_0_1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(0, 1);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_1_1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(1, 1);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_2_1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(2, 1);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_0_2_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(0, 2);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_1_2_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(1, 2);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }

        private void button_2_2_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                field.PlayerDraw(2, 2);
                UpdateField(field.GetField());
                isPlaying = !field.GetWinState();
            }
        }



    }
}