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
        private readonly AirportCollection airportCollection;

        private Stack<IFlyingTransport> stack = new Stack<IFlyingTransport>();

        public FormAirport()
        {
            InitializeComponent();
            airportCollection = new AirportCollection(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxAiports.SelectedIndex;
            listBoxAiports.Items.Clear();
            for (int i = 0; i < airportCollection.Keys.Count; i++)
            {
                listBoxAiports.Items.Add(airportCollection.Keys[i]);
            }
            if (listBoxAiports.Items.Count > 0 && (index == -1 || index >= listBoxAiports.Items.Count))
            {
                listBoxAiports.SelectedIndex = 0;
            }
            else if (listBoxAiports.Items.Count > 0 && index > -1 && index < listBoxAiports.Items.Count)
            {
                listBoxAiports.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirport.Width, pictureBoxAirport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                if (listBoxAiports.SelectedIndex > -1)
                {
                    airportCollection[listBoxAiports.SelectedItem.ToString()].Draw(gr);
                }
                else
                {
                    gr.FillRectangle(new SolidBrush(System.Drawing.Color.Transparent), 0, 0, pictureBoxAirport.Width, pictureBoxAirport.Height);
                }
                pictureBoxAirport.Image = bmp;
            }

        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var warplane = airportCollection[listBoxAiports.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (warplane != null)
                {
                    stack.Push(warplane);
                }
                Draw();
            }
        }

        private void ButtonDelAirport_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxAiports.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    airportCollection.DelAirport(listBoxAiports.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void ListBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonAddAirport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            airportCollection.AddAirport(textBoxNewLevelName.Text);
            ReloadLevels();
            listBoxAiports.SetSelected(listBoxAiports.Items.Count - 1, true);
            Draw();
        }

        private void ButtonFly_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                FormFighter form = new FormFighter();
                form.SetWarplane(stack.Pop());
                form.ShowDialog();
            }
        }

        private void ButtonAddPlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show();
        }

        private void AddPlane(Plane plane)
        {
            if (plane != null && listBoxAiports.SelectedIndex > -1)
            {
                if ((airportCollection[listBoxAiports.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Транспорт не удалось поставить");
                }
            }
        }


        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьАэропортToolStripMenuItem_Click(object sender, EventArgs e)//
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.SaveAirport(saveFileDialog.FileName, Convert.ToString(listBoxAiports.SelectedItem)))
                {
                    MessageBox.Show("Сохранение прoшло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьАэропортToolStripMenuItem_Click(object sender, EventArgs e)//
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.LoadAirport(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
