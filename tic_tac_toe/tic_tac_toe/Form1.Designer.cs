﻿
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
            this.button_0_0 = new System.Windows.Forms.Button();
            this.button_1_0 = new System.Windows.Forms.Button();
            this.button_2_0 = new System.Windows.Forms.Button();
            this.button_0_1 = new System.Windows.Forms.Button();
            this.button_1_1 = new System.Windows.Forms.Button();
            this.button_2_1 = new System.Windows.Forms.Button();
            this.button_0_2 = new System.Windows.Forms.Button();
            this.button_1_2 = new System.Windows.Forms.Button();
            this.button_2_2 = new System.Windows.Forms.Button();
            this.panel_game = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.label_curr_combo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_rec = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.label_max_combo = new System.Windows.Forms.Label();
            this.panel_userinfo = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.panel_game.SuspendLayout();
            this.panel_userinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_0_0
            // 
            this.button_0_0.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_0_0, "button_0_0");
            this.button_0_0.Name = "button_0_0";
            this.button_0_0.UseVisualStyleBackColor = true;
            // 
            // button_1_0
            // 
            this.button_1_0.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_1_0, "button_1_0");
            this.button_1_0.Name = "button_1_0";
            this.button_1_0.UseVisualStyleBackColor = true;
            // 
            // button_2_0
            // 
            this.button_2_0.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_2_0, "button_2_0");
            this.button_2_0.Name = "button_2_0";
            this.button_2_0.UseVisualStyleBackColor = true;
            // 
            // button_0_1
            // 
            this.button_0_1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_0_1, "button_0_1");
            this.button_0_1.Name = "button_0_1";
            this.button_0_1.UseVisualStyleBackColor = true;
            // 
            // button_1_1
            // 
            this.button_1_1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_1_1, "button_1_1");
            this.button_1_1.Name = "button_1_1";
            this.button_1_1.UseVisualStyleBackColor = true;
            // 
            // button_2_1
            // 
            this.button_2_1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_2_1, "button_2_1");
            this.button_2_1.Name = "button_2_1";
            this.button_2_1.UseVisualStyleBackColor = true;
            // 
            // button_0_2
            // 
            this.button_0_2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_0_2, "button_0_2");
            this.button_0_2.Name = "button_0_2";
            this.button_0_2.UseVisualStyleBackColor = true;
            // 
            // button_1_2
            // 
            this.button_1_2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_1_2, "button_1_2");
            this.button_1_2.Name = "button_1_2";
            this.button_1_2.UseVisualStyleBackColor = true;
            // 
            // button_2_2
            // 
            this.button_2_2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_2_2, "button_2_2");
            this.button_2_2.Name = "button_2_2";
            this.button_2_2.UseVisualStyleBackColor = true;
            // 
            // panel_game
            // 
            resources.ApplyResources(this.panel_game, "panel_game");
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
            // label_username
            // 
            resources.ApplyResources(this.label_username, "label_username");
            this.label_username.Name = "label_username";
            // 
            // label_curr_combo
            // 
            resources.ApplyResources(this.label_curr_combo, "label_curr_combo");
            this.label_curr_combo.Name = "label_curr_combo";
            this.label_curr_combo.Click += new System.EventHandler(this.label_score_Click);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items")});
            this.listBox1.Name = "listBox1";
            // 
            // label_rec
            // 
            resources.ApplyResources(this.label_rec, "label_rec");
            this.label_rec.Name = "label_rec";
            // 
            // button_restart
            // 
            resources.ApplyResources(this.button_restart, "button_restart");
            this.button_restart.Name = "button_restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // label_max_combo
            // 
            resources.ApplyResources(this.label_max_combo, "label_max_combo");
            this.label_max_combo.Name = "label_max_combo";
            // 
            // panel_userinfo
            // 
            this.panel_userinfo.Controls.Add(this.label_max_combo);
            this.panel_userinfo.Controls.Add(this.label_curr_combo);
            this.panel_userinfo.Controls.Add(this.label_username);
            resources.ApplyResources(this.panel_userinfo, "panel_userinfo");
            this.panel_userinfo.Name = "panel_userinfo";
            // 
            // button_login
            // 
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            resources.ApplyResources(this.button_logout, "button_logout");
            this.button_logout.Name = "button_logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            resources.ApplyResources(this.button_about, "button_about");
            this.button_about.Name = "button_about";
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.label_rec);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel_userinfo);
            this.Controls.Add(this.panel_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_game.ResumeLayout(false);
            this.panel_userinfo.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_curr_combo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_rec;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label_max_combo;
        private System.Windows.Forms.Panel panel_userinfo;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_about;
    }
}

