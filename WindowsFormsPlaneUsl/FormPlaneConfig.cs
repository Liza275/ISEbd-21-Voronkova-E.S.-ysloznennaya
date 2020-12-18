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
    public partial class FormPlaneConfig : Form
    {
        Plane plane = null;
        private event Action<Plane> eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            panelRedColor.MouseDown += PanelColor_MouseDown;
            panelAquaColor.MouseDown += PanelColor_MouseDown;
            panelBlueColor.MouseDown += PanelColor_MouseDown;
            panelGrayColor.MouseDown += PanelColor_MouseDown;
            panelLimeColor.MouseDown += PanelColor_MouseDown;
            panelOrangeColor.MouseDown += PanelColor_MouseDown;
            panelPinkColor.MouseDown += PanelColor_MouseDown;
            panelYellowColor.MouseDown += PanelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 90, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                plane.DrawTransport(gr);
                pictureBoxDisplay.Image = bmp;
            }
        }
        public void AddEvent(Action<Plane> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Plane>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void LabelDopElements_MouseDown(object sender, MouseEventArgs e)
        {
            IDrawingElements drawing = new DrawingTriangleBombs(2);
            Label label = (Label)sender;
            if (label.Text.Equals("Круглые"))
            {
                drawing = new DrawingEllipseBombs(2);
            }
            if (label.Text.Equals("Контейнер"))
            {
                drawing = new DrawingBombsContainer(2);
            }
            int num = 2;
            if (radioButtonFour.Checked)
            {
                num = 4;
            }
            if (radioButtonSix.Checked)
            {
                num = 6;
            }
            drawing.Digit = num;
            labelwarplane.DoDragDrop(drawing, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void Labelwarplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelwarplane.DoDragDrop(labelwarplane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void Labelfighter_MouseDown(object sender, MouseEventArgs e)
        {
            labelfighter.DoDragDrop(labelfighter.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void Panelwarplane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(typeof(DrawingTriangleBombs))
                || e.Data.GetDataPresent(typeof(DrawingEllipseBombs)) || e.Data.GetDataPresent(typeof(DrawingBombsContainer)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void Panelwarplane_DragDrop(object sender, DragEventArgs e)
        {
            IDrawingElements drawing = null;
            if (e.Data.GetDataPresent(typeof(DrawingBombsContainer)))
            {
                drawing = (DrawingBombsContainer)e.Data.GetData(typeof(DrawingBombsContainer));
            }
            if (e.Data.GetDataPresent(typeof(DrawingEllipseBombs)))
            {
                drawing = (DrawingEllipseBombs)e.Data.GetData(typeof(DrawingEllipseBombs));
            }
            if (e.Data.GetDataPresent(typeof(DrawingTriangleBombs)))
            {
                drawing = (DrawingTriangleBombs)e.Data.GetData(typeof(DrawingTriangleBombs));
            }
            if (plane != null && drawing != null)
            {
                if (plane is Fighter)
                {
                    Fighter fighter = (Fighter)plane;
                    fighter.db = drawing;
                }
            }
            else
            {
                if (!e.Data.GetDataPresent(DataFormats.Text))
                {
                    return;
                }
                switch (e.Data.GetData(DataFormats.Text).ToString())
                {
                    case "Военный самолет":
                        plane = new Warplane((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                        break;
                    case "Истребитель":
                        plane = new Fighter((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxEngines.Checked, checkBoxBombs.Checked, 2, BombsForm.TRIANGLE);
                        break;
                }
            }
            DrawPlane();
        }
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Control panelColor = (Control)sender;
            panelColor.DoDragDrop(panelColor.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Labelmaincolor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }
        private void Labeldopcolor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is Fighter fighter)
                {
                    fighter.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                }
                else
                {
                    MessageBox.Show("У военного самолета не может быть дополнительного цвета");
                }
                DrawPlane();
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
