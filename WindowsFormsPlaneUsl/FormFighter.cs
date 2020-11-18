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
        private IFlyingTransport warplane;

        private BombsForm bombsForm = BombsForm.TRIANGLE;

        public FormFighter()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxfighter.Width, pictureBoxfighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            warplane.DrawTransport(gr);
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
            warplane = new Fighter(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.ForestGreen,
           Color.Black, true, true, bombsNum, bombsForm);
            warplane.SetPosition(rnd.Next(10, 10), rnd.Next(64, 128), pictureBoxfighter.Width,
           pictureBoxfighter.Height);
            Draw();
        }


        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    warplane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    warplane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    warplane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    warplane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }

        private void ButtonCreateWarplane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warplane = new Warplane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.ForestGreen);
            warplane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxfighter.Width,
            pictureBoxfighter.Height);
            Draw();
        }

        private void CheckBoxTriangle_Click(object sender, EventArgs e)
        {
            if (checkBoxTriangle.Checked)
            {
                bombsForm = BombsForm.TRIANGLE;
                checkBoxContainer.Checked = false;
                checkBoxEllipse.Checked = false;
            }
            else
            {
                checkBoxTriangle.Checked = true;
            }
        }

        private void CheckBoxEllipse_Click(object sender, EventArgs e)
        {
            if (checkBoxEllipse.Checked)
            {
                bombsForm = BombsForm.ELLIPSE;
                checkBoxTriangle.Checked = false;
                checkBoxContainer.Checked = false;
            }
            else
            {
                checkBoxEllipse.Checked = true;
            }
        }

        private void CheckBoxContainer_Click(object sender, EventArgs e)
        {
            if (checkBoxContainer.Checked)
            {
                bombsForm = BombsForm.CONTAINER;
                checkBoxTriangle.Checked = false;
                checkBoxEllipse.Checked = false;
            }
            else
            {
                checkBoxContainer.Checked = true;
            }
        }
    }
}
