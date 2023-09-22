using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer StartSoundPlayer = new System.Media.SoundPlayer(@"c:/windows/media/Windows Battery Low.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"c:/windows/media/tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void MoveToStart()
        {
            StartSoundPlayer.Play();
            Point Startingpoint = panel1.Location;
            Startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(Startingpoint);
        }

        private void Finih_Label(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
