using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlaneUsl
{
    public partial class FormFighter : Form
    {
        private Fighter fighter;
        public FormFighter()
        {
            InitializeComponent();

       
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxfighter.Width, pictureBoxfighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fighter.DrawTransport(gr);
            pictureBoxfighter.Image = bmp;
        }
        

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            int bombsNum = 2;
            try
            {
                bombsNum = Convert.ToInt32(setBoxNum.Text);
            }
            catch (Exception) { }

            Random rnd = new Random();
            fighter = new Fighter(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.ForestGreen,
           Color.Black, true, true,bombsNum);
            fighter.SetPosition(rnd.Next(10, 10), rnd.Next(64, 128), pictureBoxfighter.Width,
           pictureBoxfighter.Height);
            Draw();
        }


        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    fighter.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    fighter.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    fighter.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    fighter.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }

        private void SetBoxNum_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
