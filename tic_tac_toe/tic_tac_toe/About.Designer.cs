
namespace tic_tac_toe
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_vs_who = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_rps = new System.Windows.Forms.ComboBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tic_tac_toe.Properties.Resources.icoon_about;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox_rps
            // 
            this.comboBox_rps.FormattingEnabled = true;
            this.comboBox_rps.Items.AddRange(new object[] {
            resources.GetString("comboBox_rps.Items"),
            resources.GetString("comboBox_rps.Items1"),
            resources.GetString("comboBox_rps.Items2")});
            resources.ApplyResources(this.comboBox_rps, "comboBox_rps");
            this.comboBox_rps.Name = "comboBox_rps";
            this.comboBox_rps.SelectedIndexChanged += new System.EventHandler(this.comboBox_rps_SelectedIndexChanged);
            // 
            // label_answer
            // 
            resources.ApplyResources(this.label_answer, "label_answer");
            this.label_answer.Name = "label_answer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_answer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_rps);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_vs_who);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_vs_who;
        private System.Windows.Forms.ComboBox comboBox_rps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}