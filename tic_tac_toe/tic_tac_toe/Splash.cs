﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Thread wait = new Thread(WaitThread);
            wait.Start();
        }
        private void WaitThread()
        {
            Thread.Sleep(3000);
            this.Close();
        }
    }
}
