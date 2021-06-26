using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            textBoxRules.Select(0, 0);
        }
    }
}
