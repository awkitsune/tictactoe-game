using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        Move move = new Move();
        TicTacToeField field = new TicTacToeField();

        string username = "";

        public void UpdateField(int[,] gameField) //make field updates
        {
            try
            {
                switch (gameField[0, 0])
                {
                    case 0: button_0_0.Image = null; break;
                    case 1: button_0_0.Image = Image.FromFile($"resources/cross_{field.GetIcon(0, 0)}.png"); break;
                    case 2: button_0_0.Image = Image.FromFile($"resources/zero_{field.GetIcon(0, 0)}.png"); break;
                }
                switch (gameField[1, 0])
                {
                    case 0: button_1_0.Image = null; break;
                    case 1: button_1_0.Image = Image.FromFile($"resources/cross_{field.GetIcon(1, 0)}.png"); break;
                    case 2: button_1_0.Image = Image.FromFile($"resources/zero_{field.GetIcon(1, 0)}.png"); break;
                }
                switch (gameField[2, 0])
                {
                    case 0: button_2_0.Image = null; break;
                    case 1: button_2_0.Image = Image.FromFile($"resources/cross_{field.GetIcon(2, 0)}.png"); break;
                    case 2: button_2_0.Image = Image.FromFile($"resources/zero_{field.GetIcon(2, 0)}.png"); break;
                }
                switch (gameField[0, 1])
                {
                    case 0: button_0_1.Image = null; break;
                    case 1: button_0_1.Image = Image.FromFile($"resources/cross_{field.GetIcon(0, 1)}.png"); break;
                    case 2: button_0_1.Image = Image.FromFile($"resources/zero_{field.GetIcon(0, 1)}.png"); break;
                }
                switch (gameField[1, 1])
                {
                    case 0: button_1_1.Image = null; break;
                    case 1: button_1_1.Image = Image.FromFile($"resources/cross_{field.GetIcon(1, 1)}.png"); break;
                    case 2: button_1_1.Image = Image.FromFile($"resources/zero_{field.GetIcon(1, 1)}.png"); break;
                }
                switch (gameField[2, 1])
                {
                    case 0: button_2_1.Image = null; break;
                    case 1: button_2_1.Image = Image.FromFile($"resources/cross_{field.GetIcon(2, 1)}.png"); break;
                    case 2: button_2_1.Image = Image.FromFile($"resources/zero_{field.GetIcon(2, 1)}.png"); break;
                }
                switch (gameField[0, 2])
                {
                    case 0: button_0_2.Image = null; break;
                    case 1: button_0_2.Image = Image.FromFile($"resources/cross_{field.GetIcon(0, 2)}.png"); break;
                    case 2: button_0_2.Image = Image.FromFile($"resources/zero_{field.GetIcon(0, 2)}.png"); break;
                }
                switch (gameField[1, 2])
                {
                    case 0: button_1_2.Image = null; break;
                    case 1: button_1_2.Image = Image.FromFile($"resources/cross_{field.GetIcon(1, 2)}.png"); break;
                    case 2: button_1_2.Image = Image.FromFile($"resources/zero_{field.GetIcon(1, 2)}.png"); break;
                }
                switch (gameField[2, 2])
                {
                    case 0: button_2_2.Image = null; break;
                    case 1: button_2_2.Image = Image.FromFile($"resources/cross_{field.GetIcon(2, 2)}.png"); break;
                    case 2: button_2_2.Image = Image.FromFile($"resources/zero_{field.GetIcon(2, 2)}.png"); break;
                }
            }
            catch (FileNotFoundException)
            {
                DialogResult result = MessageBox.Show(
                        "Buttons pictures are corrupted or not exist, check game folder!",
                        "Oh, no!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

        }

        public Form1()
        {
            InitializeComponent();

            panel_game.Enabled = false;
            panel_userdata.Visible = false;
            button_restart.Enabled = false;

            UpdateField(field.GetField());
        }
        private void label_score_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("userdata.dat"))
            {
                try
                {
                    using (BinaryReader file = new BinaryReader(File.OpenRead("userdata.dat")))
                    {
                        username = file.ReadString();
                        label_username.Text = username;
                        panel_userdata.Visible = true;
                        panel_login.Visible = false;
                        button_restart.Enabled = true;
                    }
                }
                catch (IOException)
                {
                    DialogResult result = MessageBox.Show(
                        "I cant read your username, would you like to delete it?",
                        "Oh, no!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete("userdata.dat");
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text.Length > 0)
            {
                username = textBox_username.Text;
                label_username.Text = username;
                panel_userdata.Visible = true;
                panel_login.Visible = false;
                button_restart.Enabled = true;
                try
                {
                    using (BinaryWriter file = new BinaryWriter(File.OpenWrite("userdata.dat")))
                    {
                        file.Write(username);
                    }
                }
                catch (IOException)
                {
                    
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            panel_game.Enabled = true;
            button_restart.Text = "Restart?";
            if (!field.GetWinState())
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
                    field.SetWinState(false);
                }
            }
            else
            {
                field.Flush();
                UpdateField(field.GetField());
                field.SetWinState(false);
            }

        }

        bool CheckWhoWin() //returns true if player, false if computer
        {

            if (field.GetWinState() && field.GetPlayerState()) return true;
            if (field.GetWinState() && !field.GetPlayerState()) return false;
            return false;
        }

        void WinMessage()
        {
            if (field.GetWinState() && CheckWhoWin()) 
                MessageBox.Show(
                    "Player won!", 
                    "Game end",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            if (field.GetWinState() && !CheckWhoWin()) 
                MessageBox.Show(
                    "Computer won!",
                    "Game end",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void button_0_0_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(0, 0);
                
                UpdateField(field.GetField());

                WinMessage();
            }

        }

        private void button_1_0_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(1, 0);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_2_0_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(2, 0);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_0_1_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(0, 1);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_1_1_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(1, 1);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_2_1_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(2, 1);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_0_2_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(0, 2);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_1_2_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(1, 2);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_2_2_Click(object sender, EventArgs e)
        {
            if (!field.GetWinState())
            {
                field.PlayerDraw(2, 2);
                
                UpdateField(field.GetField());

                WinMessage();
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
