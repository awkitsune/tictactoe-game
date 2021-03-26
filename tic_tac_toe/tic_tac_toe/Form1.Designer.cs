
namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_username = new System.Windows.Forms.Label();
            this.label_vs_who = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.panel_game = new System.Windows.Forms.Panel();
            this.button_0_0 = new System.Windows.Forms.Button();
            this.button_2_2 = new System.Windows.Forms.Button();
            this.button_1_0 = new System.Windows.Forms.Button();
            this.button_1_2 = new System.Windows.Forms.Button();
            this.button_2_0 = new System.Windows.Forms.Button();
            this.button_0_2 = new System.Windows.Forms.Button();
            this.button_0_1 = new System.Windows.Forms.Button();
            this.button_2_1 = new System.Windows.Forms.Button();
            this.button_1_1 = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_userdata = new System.Windows.Forms.Panel();
            this.label_wins_loses = new System.Windows.Forms.Label();
            this.panel_game.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.panel_userdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username
            // 
            resources.ApplyResources(this.label_username, "label_username");
            this.label_username.Name = "label_username";
            // 
            // label_vs_who
            // 
            resources.ApplyResources(this.label_vs_who, "label_vs_who");
            this.label_vs_who.Name = "label_vs_who";
            this.label_vs_who.Click += new System.EventHandler(this.label_score_Click);
            // 
            // button_restart
            // 
            resources.ApplyResources(this.button_restart, "button_restart");
            this.button_restart.Name = "button_restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // button_about
            // 
            resources.ApplyResources(this.button_about, "button_about");
            this.button_about.Name = "button_about";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // panel_game
            // 
            resources.ApplyResources(this.panel_game, "panel_game");
            this.panel_game.BackColor = System.Drawing.SystemColors.Window;
            this.panel_game.BackgroundImage = global::tic_tac_toe.Properties.Resources.ttt_bg;
            this.panel_game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_game.Controls.Add(this.button_0_0);
            this.panel_game.Controls.Add(this.button_2_2);
            this.panel_game.Controls.Add(this.button_1_0);
            this.panel_game.Controls.Add(this.button_1_2);
            this.panel_game.Controls.Add(this.button_2_0);
            this.panel_game.Controls.Add(this.button_0_2);
            this.panel_game.Controls.Add(this.button_0_1);
            this.panel_game.Controls.Add(this.button_2_1);
            this.panel_game.Controls.Add(this.button_1_1);
            this.panel_game.Name = "panel_game";
            // 
            // button_0_0
            // 
            this.button_0_0.BackColor = System.Drawing.Color.Transparent;
            this.button_0_0.FlatAppearance.BorderSize = 0;
            this.button_0_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_0_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_0_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_0_0, "button_0_0");
            this.button_0_0.Name = "button_0_0";
            this.button_0_0.UseVisualStyleBackColor = false;
            this.button_0_0.Click += new System.EventHandler(this.button_0_0_Click);
            // 
            // button_2_2
            // 
            this.button_2_2.BackColor = System.Drawing.Color.Transparent;
            this.button_2_2.FlatAppearance.BorderSize = 0;
            this.button_2_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_2_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_2_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_2_2, "button_2_2");
            this.button_2_2.Name = "button_2_2";
            this.button_2_2.UseVisualStyleBackColor = false;
            this.button_2_2.Click += new System.EventHandler(this.button_2_2_Click);
            // 
            // button_1_0
            // 
            this.button_1_0.BackColor = System.Drawing.Color.Transparent;
            this.button_1_0.FlatAppearance.BorderSize = 0;
            this.button_1_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_1_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_1_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_1_0, "button_1_0");
            this.button_1_0.Name = "button_1_0";
            this.button_1_0.UseVisualStyleBackColor = false;
            this.button_1_0.Click += new System.EventHandler(this.button_1_0_Click);
            // 
            // button_1_2
            // 
            this.button_1_2.BackColor = System.Drawing.Color.Transparent;
            this.button_1_2.FlatAppearance.BorderSize = 0;
            this.button_1_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_1_2, "button_1_2");
            this.button_1_2.Name = "button_1_2";
            this.button_1_2.UseVisualStyleBackColor = false;
            this.button_1_2.Click += new System.EventHandler(this.button_1_2_Click);
            // 
            // button_2_0
            // 
            this.button_2_0.BackColor = System.Drawing.Color.Transparent;
            this.button_2_0.FlatAppearance.BorderSize = 0;
            this.button_2_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_2_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_2_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_2_0, "button_2_0");
            this.button_2_0.Name = "button_2_0";
            this.button_2_0.UseVisualStyleBackColor = false;
            this.button_2_0.Click += new System.EventHandler(this.button_2_0_Click);
            // 
            // button_0_2
            // 
            this.button_0_2.BackColor = System.Drawing.Color.Transparent;
            this.button_0_2.FlatAppearance.BorderSize = 0;
            this.button_0_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_0_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_0_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_0_2, "button_0_2");
            this.button_0_2.Name = "button_0_2";
            this.button_0_2.UseVisualStyleBackColor = false;
            this.button_0_2.Click += new System.EventHandler(this.button_0_2_Click);
            // 
            // button_0_1
            // 
            this.button_0_1.BackColor = System.Drawing.Color.Transparent;
            this.button_0_1.FlatAppearance.BorderSize = 0;
            this.button_0_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_0_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_0_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_0_1, "button_0_1");
            this.button_0_1.Name = "button_0_1";
            this.button_0_1.UseVisualStyleBackColor = false;
            this.button_0_1.Click += new System.EventHandler(this.button_0_1_Click);
            // 
            // button_2_1
            // 
            this.button_2_1.BackColor = System.Drawing.Color.Transparent;
            this.button_2_1.FlatAppearance.BorderSize = 0;
            this.button_2_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_2_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_2_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_2_1, "button_2_1");
            this.button_2_1.Name = "button_2_1";
            this.button_2_1.UseVisualStyleBackColor = false;
            this.button_2_1.Click += new System.EventHandler(this.button_2_1_Click);
            // 
            // button_1_1
            // 
            this.button_1_1.BackColor = System.Drawing.Color.Transparent;
            this.button_1_1.FlatAppearance.BorderSize = 0;
            this.button_1_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_1_1, "button_1_1");
            this.button_1_1.Name = "button_1_1";
            this.button_1_1.UseVisualStyleBackColor = false;
            this.button_1_1.Click += new System.EventHandler(this.button_1_1_Click);
            // 
            // panel_login
            // 
            resources.ApplyResources(this.panel_login, "panel_login");
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Name = "panel_login";
            // 
            // button_login
            // 
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_username
            // 
            resources.ApplyResources(this.textBox_username, "textBox_username");
            this.textBox_username.Name = "textBox_username";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel_userdata
            // 
            this.panel_userdata.Controls.Add(this.label_wins_loses);
            this.panel_userdata.Controls.Add(this.label_username);
            this.panel_userdata.Controls.Add(this.label_vs_who);
            resources.ApplyResources(this.panel_userdata, "panel_userdata");
            this.panel_userdata.Name = "panel_userdata";
            // 
            // label_wins_loses
            // 
            resources.ApplyResources(this.label_wins_loses, "label_wins_loses");
            this.label_wins_loses.Name = "label_wins_loses";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel_userdata);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.panel_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_game.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_userdata.ResumeLayout(false);
            this.panel_userdata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_0_0;
        private System.Windows.Forms.Button button_1_0;
        private System.Windows.Forms.Button button_2_0;
        private System.Windows.Forms.Button button_0_1;
        private System.Windows.Forms.Button button_1_1;
        private System.Windows.Forms.Button button_2_1;
        private System.Windows.Forms.Button button_0_2;
        private System.Windows.Forms.Button button_1_2;
        private System.Windows.Forms.Button button_2_2;
        private System.Windows.Forms.Panel panel_game;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_vs_who;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_userdata;
        private System.Windows.Forms.Label label_wins_loses;
    }
}

