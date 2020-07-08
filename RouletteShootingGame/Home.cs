using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteShootingGame
{
    public partial class Home : Form
    {

        Timer timer;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender,EventArgs e)
        {
            timer.Stop();
            MainScreen gs = new MainScreen();
            gs.Show();
            this.Hide();
        }
    }
}
