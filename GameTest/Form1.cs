using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class Form1 : Form
    {
        private int startX = 100;
        private int startY = 298;

        private int gravity = 10;
        private int gravityConst = 1;
        private double jumpHeight = 100;
        private int sideMoveSpeed = 3;
        private int globalMoveSpeed = 3;
        private int startingSideMoveSpeed = 3;
        private double jumpPositionY = 1;
        bool isPaused = false;
        double cumulativeGravity = 0;
        int gravityPerFrame = 3;

        int screenHeight = 100;
        int screenWidth = 100;
        int screenRightMargin = 100;
        int screenLeftMargin = 100;
        private bool inJump;
        private bool hasJumped;

        public Form1()
        {
            InitializeComponent();

            Reset();

            Screen myScreen = Screen.FromControl(this);
            screenHeight = this.Height;
            screenWidth = this.Width;
            screenRightMargin = screenWidth - (screenWidth / 100 * 10);
            screenLeftMargin = (screenWidth / 100 * 2);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                pauseMenu.Visible = false;
                Move();
                CheckJump();
                MoveBackGround();
                ApplyGravity();
                CheckIsDead();
            }
            else
            {
                pauseMenu.Visible = true;
            }
        }

        private void MoveBackGround()
        {
            var groundObjects = GetGroundObjects();

            for (int i = 0; i < groundObjects.Count(); i++)
            {
                Color Warn1Color = Color.FromArgb(255, 0, 0);//default colour
                if (groundObjects[i].Right < 0)
                {
                    groundObjects[i].Left = this.Width - 100;
                    //this.Controls.Remove(groundObjects[i]);
                    //PictureBox newGround = new PictureBox()
                    //{
                    //    Name = "ground" + new Guid(),
                    //    Location = new Point(300, 563),
                    //    Width = 1000,
                    //    Height = 50,
                    //    BackColor = Warn1Color,
                    //    AccessibleDescription = "ground"
                    //};
                    //this.Controls.Add(newGround);


                }

                groundObjects[i].Left -= globalMoveSpeed;
            }

        }

        private void ApplyGravity()
        {
            if (!IsOnGround())
            {
                cumulativeGravity += gravity;
                while (cumulativeGravity != 0)
                {
                    cumulativeGravity -= gravityPerFrame;
                    player.Top += gravityPerFrame;
                    if (cumulativeGravity < 0)
                    {
                        cumulativeGravity = 0;
                    }
                }
            }
        }

        private void Move()
        {
            if (player.Left <= screenLeftMargin)
            {
                sideMoveSpeed = sideMoveSpeed * -1;
                player.Left += sideMoveSpeed;
            }
            else if (player.Left <= screenRightMargin)
            {
                player.Left += sideMoveSpeed;
            }
            else
            {
                sideMoveSpeed = sideMoveSpeed * -1;
                player.Left += sideMoveSpeed;
            }


        }

        private List<Control> GetGroundObjects()
        {
            List<Control> groundObjects = new List<Control>();

            List<Control> c = Controls.OfType<PictureBox>().Cast<Control>().ToList();
            foreach (var control in c)
            {
                if (control.AccessibleDescription == "ground")
                {
                    groundObjects.Add(control);
                }
            }

            return groundObjects;

        }

        private void CheckJump()
        {
            if (inJump)
            {
                while (player.Top >= jumpPositionY)
                {
                    player.Top -= 1;
                    Move();
                    if (player.Top <= jumpPositionY)
                    {
                        inJump = false;
                    }
                    player.Top -= gravity;
                }
            }
        }

        private bool IsOnGround()
        {
            List<Control> groundObjects = GetGroundObjects();
            bool isOnGround = false;
            foreach (var ground in groundObjects)
            {
                if (player.Bounds.IntersectsWith(ground.Bounds))
                {
                    hasJumped = false;
                    isOnGround = true;
                }
            }

            return isOnGround;
        }

        private void CheckIsDead()
        {
            if ((player.Right >= screenWidth) || (player.Top >= screenHeight))
            {
                End();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!inJump) && (!hasJumped))
            {
                if (e.KeyCode == Keys.Space)
                {
                    inJump = true;
                    hasJumped = true;
                    jumpPositionY = player.Bottom - jumpHeight;
                }
                if (e.KeyCode == Keys.R)
                {
                    Reset();
                }
                if (e.KeyCode == Keys.P)
                {
                    if (isPaused)
                    {
                        isPaused = false;
                    }
                    else
                    {
                        isPaused = true;
                    }

                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            gravity = gravityConst;
        }

        private void End()
        {
            gameTimer.Stop();
            isPaused = true;
            Reset();

        }

        private void Reset()
        {
            player.Left = startX;
            player.Top = startY;
            sideMoveSpeed = startingSideMoveSpeed;

            gameTimer.Start();
        }
    }
}
