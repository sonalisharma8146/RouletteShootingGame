using RouletteShootingGame.Engine;
using RouletteShootingGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteShootingGame
{
    public partial class MainScreen : Form
    {

        Cylinder cylinder;
        SoundPlayer player;
        int chance, pos,angle;//variables not in separate class file
        Random random;
        Timer timer;
       
        public MainScreen()
        {
            InitializeComponent();
            buttonLoad.Enabled = buttonPress.Enabled = buttonSpin.Enabled = false;
            random = new Random();
            pictureProcess.Visible = false;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text.Contains("Start"))
            {
                buttonStart.Text = "End Game";
                lblMessage.Text = "Click To Load the Bullet...";
                chance = 3;
                cylinder = new Cylinder();
                pictureProcess.Visible = true;
                ChangePicture(pictureProcess, Resources.emptychamber);
                buttonLoad.Enabled = true;
            }
            else
            {
                MessageBox.Show("Quit The Game...");
                this.Close();
            }
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            buttonLoad.Enabled = false;
            pos = random.Next(0, 6);
            lblMessage.Text = "Loading The Bullet at : " + (pos + 1);
            cylinder.LoadBullet(pos);
            await Task.Delay(1000);
            int angle = (pos + 1) * 30;
            Image image = new Bitmap(Resources.withbullet);
            //Store our old image so we can delete it
            Image oldImage = pictureProcess.Image;
            //Pass in our original image and return a new image rotated 35 degrees right
            pictureProcess.Image = Utility.RotateImage(image, new Point(), angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            lblMessage.Text = "Click to Spin it...";
            buttonSpin.Enabled = true;
        }

        private async void buttonSpin_Click(object sender, EventArgs e)
        {
            buttonSpin.Enabled = false;
            lblMessage.Text = "Spinning the Chamber...";
            cylinder.Spin();
            angle = 0;
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
            await Task.Delay(3000);
            timer.Stop();
            buttonPress.Enabled = true;
            ChangePicture(pictureProcess, Resources.gunwithoutfire);
            lblMessage.Text = "Click to Press, For Fire Bullet...";
            lblRemaining.Text = "Remaining Chance : " + chance;
            pos = 0;
        }

        private void Timer_Tick(object sender,EventArgs e)
        {
            angle += 20;
            if (angle == 360)
            {
                angle = 0;
            }
            Image image = new Bitmap(Resources.withbullet);
            //Store our old image so we can delete it
            Image oldImage = pictureProcess.Image;            
            pictureProcess.Image = Utility.RotateImage(image, new Point(), angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }

        }

        private async void buttonPress_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer();
            if (cylinder.Fire(pos))
            {
                player.Stream = Resources.GunShot;
                player.Play();
                ChangePicture(pictureProcess, Resources.gunwithfire);
                ChangePicture(pictureResult,Resources.dead);
                await Task.Delay(1000);
                lblRemaining.Text = "Dead!!!";
                MessageBox.Show("Sorry!!! You Lost Your Life...");
                this.Close();
                return;
            }
            else
            {
                player.Stream = Resources.Empty;
                player.Play();
                await Task.Delay(1000);
            }
            pos++;
            chance--;
            if (chance == 0)
            {
                lblRemaining.Text = "Thank God You Survived!!!";
                ChangePicture(pictureResult,Resources.lucky);
                await Task.Delay(500);
                MessageBox.Show("Congratulations. You Won!!!");
                this.Close();
            }
            else
            {
                lblRemaining.Text = "Remaining Chance: " + chance;
            }
        }

        private void ChangePicture(PictureBox pictureBox , Bitmap image)
        {
            pictureBox.Image = image;
        }
    }
}
