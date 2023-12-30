using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazeGame
{
    public partial class Form1 : Form
    {
        public MenuControl menuControl;

        public Form1()
        {
            InitializeComponent();
            ShowMenuControl();
        }

        private void ShowMenuControl()
        {
            menuControl = new MenuControl();
            menuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(menuControl);
        }
    }
}
