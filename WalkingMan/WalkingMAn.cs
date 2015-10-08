using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// for pause
using System.Threading;

namespace WalkingMan
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            int loopCounter = 0;

            do
            {
                if (picWalkingMan.Location.X <0)
                {
                    picWalkingMan.Location = new Point(100, 12);
                }
                if (loopCounter == 0)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk2;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 1)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk3;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 2)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk4;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else  if (loopCounter == 3)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk5;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 4)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk6;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 5)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk7;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 6)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk8;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 7)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk9;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                else if (loopCounter == 8)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk10;
                    this.picWalkingMan.Left = this.picWalkingMan.Left - 5;
                }

                

                loopCounter++;

                // pause
                this.Refresh();
                Thread.Sleep(100);

            }while (loopCounter < 10);
        }
    }
}
