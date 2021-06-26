using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace tic_tac_toe
{
    public partial class GameForm : Form
    {
        string saveName = "userdata.dat";

        Move move = new Move();
        TicTacToeField field = new TicTacToeField();

        string username = "";
        int wins = 0;
        int loses = 0;

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
                        "Картинки для кнопок отсутствуют, скопируйте их вручную и перезапустите игру!",
                        "О, нет!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

        }

        public GameForm()
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
            this.Hide();
            Splash splash = new Splash();
            splash.ShowDialog();
            splash.Dispose();


            button_0_0.BackColor = Color.FromArgb(16, Color.Black);
            button_0_1.BackColor = Color.FromArgb(16, Color.Black);
            button_0_2.BackColor = Color.FromArgb(16, Color.Black);
            button_1_0.BackColor = Color.FromArgb(16, Color.Black);
            button_1_1.BackColor = Color.FromArgb(16, Color.Black);
            button_1_2.BackColor = Color.FromArgb(16, Color.Black);
            button_2_0.BackColor = Color.FromArgb(16, Color.Black);
            button_2_1.BackColor = Color.FromArgb(16, Color.Black);
            button_2_2.BackColor = Color.FromArgb(16, Color.Black);

            if (File.Exists(saveName))
            {
                try
                {
                    using (BinaryReader file = new BinaryReader(File.OpenRead(saveName)))
                    {
                        username = file.ReadString();
                        wins = file.ReadInt32();
                        loses = file.ReadInt32();

                        label_username.Text = username;
                        panel_userdata.Visible = true;
                        panel_login.Visible = false;
                        button_restart.Enabled = true;
                        label_wins_loses.Visible = true;

                        textBox_username.Text = username;
                    }
                }
                catch (IOException)
                {
                    DialogResult result = MessageBox.Show(
                        "Я не могу прочитать информацию об игроке, удалить файл?",
                        "О, нет!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        File.Delete(saveName);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Похоже, вы запустили игру в первый раз. Показать правила?", 
                    "Первый запуск", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RulesForm rules = new RulesForm();
                    rules.ShowDialog();
                    rules.Dispose();
                }
            }

            this.Show();

            UpdateWinLose();
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
                label_wins_loses.Visible = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            panel_game.Enabled = true;
            button_restart.Text = "Перезапустить?";
            if (!field.GetWinState())
            {
                DialogResult result = MessageBox.Show(
                        "Вы реально хотите перезапустить игру?", 
                        "Подтверждение", 
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

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (textBox_username.Text != "")
            {
                try
                {
                    using (BinaryWriter file = new BinaryWriter(File.OpenWrite(saveName)))
                    {
                        file.Write(username);
                        file.Write(wins);
                        file.Write(loses);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show(
                        "Произошла ошибка при сохранении данных", 
                        "О, нет!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);

                }
            }

            //Application.OpenForms[0].Close();
        }

        void UpdateWinLose()
        { 
            label_wins_loses.Text = $"Побед: {wins}, Поражений: {loses}";
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
            {
                MessageBox.Show(
                    "Победил игрок!",
                    "Конец игры",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                wins++;
                UpdateWinLose();
            }
            if (field.GetWinState() && !CheckWhoWin())
            {
                MessageBox.Show(
                    "Победил компьютер!",
                    "Конец игры",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loses++;
                UpdateWinLose();
            }
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
            AboutForm about = new AboutForm();
            about.ShowDialog();
            about.Dispose();
        }

        private void button_rulezzz_Click(object sender, EventArgs e)
        {
            RulesForm rules = new RulesForm();
            rules.ShowDialog();
            rules.Dispose();
        }
    }
}
