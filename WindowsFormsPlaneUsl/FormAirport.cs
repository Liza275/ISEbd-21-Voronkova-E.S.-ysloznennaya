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
    public partial class FormAirport : Form
    {
        private readonly Airport<Warplane,DrawingBombsContainer> airport;

        public FormAirport()
        {
            InitializeComponent();
            airport = new Airport<Warplane,DrawingBombsContainer>(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airport.Draw(gr);
            pictureBoxAirport.Image = bmp;
        }

        private void buttonSetWarplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var warplane = new Warplane(100, 100, dialog.Color);
                if (airport + warplane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetFighter_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var fighter = new Fighter(100, 100, dialog.Color, dialogDop.Color, true, true,6,BombsForm.TRIANGLE);

                    if (airport + fighter)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var warplane = airport - Convert.ToInt32(maskedTextBox.Text);
                if (warplane != null)
                {
                    FormFighter form = new FormFighter();
                    form.SetWarplane(warplane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
