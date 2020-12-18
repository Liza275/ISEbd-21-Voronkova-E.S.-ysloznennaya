namespace WindowsFormsPlaneUsl
{
    partial class FormPlaneConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBombs = new System.Windows.Forms.GroupBox();
            this.radioButtonSix = new System.Windows.Forms.RadioButton();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonFour = new System.Windows.Forms.RadioButton();
            this.checkBoxEngines = new System.Windows.Forms.CheckBox();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelmaincolor = new System.Windows.Forms.Label();
            this.labeldopcolor = new System.Windows.Forms.Label();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelfighter = new System.Windows.Forms.Label();
            this.labelwarplane = new System.Windows.Forms.Label();
            this.panelwarplane = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelGrayColor = new System.Windows.Forms.Panel();
            this.panelAquaColor = new System.Windows.Forms.Panel();
            this.panelPinkColor = new System.Windows.Forms.Panel();
            this.panelOrangeColor = new System.Windows.Forms.Panel();
            this.panelBlueColor = new System.Windows.Forms.Panel();
            this.panelLimeColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.groupBoxDopElems = new System.Windows.Forms.GroupBox();
            this.labelContainer = new System.Windows.Forms.Label();
            this.labelEllipse = new System.Windows.Forms.Label();
            this.labelTriangle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxBombs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelwarplane.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxDopElems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxBombs);
            this.groupBox1.Controls.Add(this.checkBoxEngines);
            this.groupBox1.Controls.Add(this.checkBoxBombs);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.numericUpDownSpeed);
            this.groupBox1.Controls.Add(this.labelWeight);
            this.groupBox1.Controls.Add(this.labelMaxSpeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(433, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // groupBoxBombs
            // 
            this.groupBoxBombs.Controls.Add(this.radioButtonSix);
            this.groupBoxBombs.Controls.Add(this.radioButtonTwo);
            this.groupBoxBombs.Controls.Add(this.radioButtonFour);
            this.groupBoxBombs.Location = new System.Drawing.Point(300, 22);
            this.groupBoxBombs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBombs.Name = "groupBoxBombs";
            this.groupBoxBombs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBombs.Size = new System.Drawing.Size(127, 137);
            this.groupBoxBombs.TabIndex = 9;
            this.groupBoxBombs.TabStop = false;
            this.groupBoxBombs.Text = "Бомбы";
            // 
            // radioButtonSix
            // 
            this.radioButtonSix.AutoSize = true;
            this.radioButtonSix.Location = new System.Drawing.Point(8, 91);
            this.radioButtonSix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSix.Name = "radioButtonSix";
            this.radioButtonSix.Size = new System.Drawing.Size(41, 21);
            this.radioButtonSix.TabIndex = 8;
            this.radioButtonSix.TabStop = true;
            this.radioButtonSix.Text = "6 ";
            this.radioButtonSix.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwo
            // 
            this.radioButtonTwo.AutoSize = true;
            this.radioButtonTwo.Checked = true;
            this.radioButtonTwo.Location = new System.Drawing.Point(8, 34);
            this.radioButtonTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.Size = new System.Drawing.Size(41, 21);
            this.radioButtonTwo.TabIndex = 6;
            this.radioButtonTwo.TabStop = true;
            this.radioButtonTwo.Text = "2 ";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            // 
            // radioButtonFour
            // 
            this.radioButtonFour.AutoSize = true;
            this.radioButtonFour.Location = new System.Drawing.Point(8, 63);
            this.radioButtonFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFour.Name = "radioButtonFour";
            this.radioButtonFour.Size = new System.Drawing.Size(41, 21);
            this.radioButtonFour.TabIndex = 7;
            this.radioButtonFour.TabStop = true;
            this.radioButtonFour.Text = "4 ";
            this.radioButtonFour.UseVisualStyleBackColor = true;
            // 
            // checkBoxEngines
            // 
            this.checkBoxEngines.AutoSize = true;
            this.checkBoxEngines.Checked = true;
            this.checkBoxEngines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEngines.Location = new System.Drawing.Point(185, 103);
            this.checkBoxEngines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEngines.Name = "checkBoxEngines";
            this.checkBoxEngines.Size = new System.Drawing.Size(100, 21);
            this.checkBoxEngines.TabIndex = 5;
            this.checkBoxEngines.Text = "Двигатели";
            this.checkBoxEngines.UseVisualStyleBackColor = true;
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Checked = true;
            this.checkBoxBombs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBombs.Location = new System.Drawing.Point(185, 58);
            this.checkBoxBombs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(74, 21);
            this.checkBoxBombs.TabIndex = 4;
            this.checkBoxBombs.Text = "Бомбы";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(19, 126);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(19, 58);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 96);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(103, 17);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес самолета:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(15, 30);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // labelmaincolor
            // 
            this.labelmaincolor.AllowDrop = true;
            this.labelmaincolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelmaincolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmaincolor.Location = new System.Drawing.Point(5, 36);
            this.labelmaincolor.Name = "labelmaincolor";
            this.labelmaincolor.Size = new System.Drawing.Size(121, 61);
            this.labelmaincolor.TabIndex = 4;
            this.labelmaincolor.Text = "Основной цвет";
            this.labelmaincolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.Labelmaincolor_DragDrop);
            this.labelmaincolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labeldopcolor
            // 
            this.labeldopcolor.AllowDrop = true;
            this.labeldopcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldopcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldopcolor.Location = new System.Drawing.Point(144, 36);
            this.labeldopcolor.Name = "labeldopcolor";
            this.labeldopcolor.Size = new System.Drawing.Size(135, 61);
            this.labeldopcolor.TabIndex = 5;
            this.labeldopcolor.Text = "Доп. Цвет";
            this.labeldopcolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.Labeldopcolor_DragDrop);
            this.labeldopcolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(181, 213);
            this.pictureBoxDisplay.TabIndex = 1;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelfighter);
            this.groupBox2.Controls.Add(this.labelwarplane);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(184, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип самолета";
            // 
            // labelfighter
            // 
            this.labelfighter.AllowDrop = true;
            this.labelfighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelfighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfighter.Location = new System.Drawing.Point(7, 133);
            this.labelfighter.Name = "labelfighter";
            this.labelfighter.Size = new System.Drawing.Size(157, 56);
            this.labelfighter.TabIndex = 1;
            this.labelfighter.Text = "Истребитель";
            this.labelfighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Labelfighter_MouseDown);
            // 
            // labelwarplane
            // 
            this.labelwarplane.AllowDrop = true;
            this.labelwarplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelwarplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelwarplane.Location = new System.Drawing.Point(7, 58);
            this.labelwarplane.Name = "labelwarplane";
            this.labelwarplane.Size = new System.Drawing.Size(157, 54);
            this.labelwarplane.TabIndex = 0;
            this.labelwarplane.Text = "Военный самолет";
            this.labelwarplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Labelwarplane_MouseDown);
            // 
            // panelwarplane
            // 
            this.panelwarplane.AllowDrop = true;
            this.panelwarplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelwarplane.Controls.Add(this.pictureBoxDisplay);
            this.panelwarplane.Location = new System.Drawing.Point(235, 27);
            this.panelwarplane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelwarplane.Name = "panelwarplane";
            this.panelwarplane.Size = new System.Drawing.Size(182, 212);
            this.panelwarplane.TabIndex = 3;
            this.panelwarplane.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panelwarplane_DragDrop);
            this.panelwarplane.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panelwarplane_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(671, 290);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(228, 57);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(671, 370);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(228, 57);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelGrayColor);
            this.groupBoxColors.Controls.Add(this.panelAquaColor);
            this.groupBoxColors.Controls.Add(this.panelPinkColor);
            this.groupBoxColors.Controls.Add(this.panelOrangeColor);
            this.groupBoxColors.Controls.Add(this.panelBlueColor);
            this.groupBoxColors.Controls.Add(this.panelLimeColor);
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Controls.Add(this.labeldopcolor);
            this.groupBoxColors.Controls.Add(this.labelmaincolor);
            this.groupBoxColors.Location = new System.Drawing.Point(601, 12);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxColors.Size = new System.Drawing.Size(297, 254);
            this.groupBoxColors.TabIndex = 9;
            this.groupBoxColors.TabStop = false;
            // 
            // panelGrayColor
            // 
            this.panelGrayColor.AllowDrop = true;
            this.panelGrayColor.BackColor = System.Drawing.Color.Silver;
            this.panelGrayColor.Location = new System.Drawing.Point(192, 169);
            this.panelGrayColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGrayColor.Name = "panelGrayColor";
            this.panelGrayColor.Size = new System.Drawing.Size(39, 37);
            this.panelGrayColor.TabIndex = 7;
            // 
            // panelAquaColor
            // 
            this.panelAquaColor.AllowDrop = true;
            this.panelAquaColor.BackColor = System.Drawing.Color.Aqua;
            this.panelAquaColor.Location = new System.Drawing.Point(132, 169);
            this.panelAquaColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAquaColor.Name = "panelAquaColor";
            this.panelAquaColor.Size = new System.Drawing.Size(39, 37);
            this.panelAquaColor.TabIndex = 7;
            // 
            // panelPinkColor
            // 
            this.panelPinkColor.AllowDrop = true;
            this.panelPinkColor.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPinkColor.Location = new System.Drawing.Point(69, 169);
            this.panelPinkColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPinkColor.Name = "panelPinkColor";
            this.panelPinkColor.Size = new System.Drawing.Size(39, 37);
            this.panelPinkColor.TabIndex = 7;
            // 
            // panelOrangeColor
            // 
            this.panelOrangeColor.AllowDrop = true;
            this.panelOrangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrangeColor.Location = new System.Drawing.Point(13, 169);
            this.panelOrangeColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrangeColor.Name = "panelOrangeColor";
            this.panelOrangeColor.Size = new System.Drawing.Size(39, 37);
            this.panelOrangeColor.TabIndex = 7;
            // 
            // panelBlueColor
            // 
            this.panelBlueColor.AllowDrop = true;
            this.panelBlueColor.BackColor = System.Drawing.Color.Blue;
            this.panelBlueColor.Location = new System.Drawing.Point(192, 110);
            this.panelBlueColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBlueColor.Name = "panelBlueColor";
            this.panelBlueColor.Size = new System.Drawing.Size(39, 37);
            this.panelBlueColor.TabIndex = 7;
            // 
            // panelLimeColor
            // 
            this.panelLimeColor.AllowDrop = true;
            this.panelLimeColor.BackColor = System.Drawing.Color.Lime;
            this.panelLimeColor.Location = new System.Drawing.Point(132, 110);
            this.panelLimeColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLimeColor.Name = "panelLimeColor";
            this.panelLimeColor.Size = new System.Drawing.Size(39, 37);
            this.panelLimeColor.TabIndex = 7;
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.AllowDrop = true;
            this.panelYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.panelYellowColor.Location = new System.Drawing.Point(69, 110);
            this.panelYellowColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(39, 37);
            this.panelYellowColor.TabIndex = 7;
            // 
            // panelRedColor
            // 
            this.panelRedColor.AllowDrop = true;
            this.panelRedColor.BackColor = System.Drawing.Color.Red;
            this.panelRedColor.Location = new System.Drawing.Point(13, 110);
            this.panelRedColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(39, 37);
            this.panelRedColor.TabIndex = 6;
            // 
            // groupBoxDopElems
            // 
            this.groupBoxDopElems.Controls.Add(this.labelContainer);
            this.groupBoxDopElems.Controls.Add(this.labelEllipse);
            this.groupBoxDopElems.Controls.Add(this.labelTriangle);
            this.groupBoxDopElems.Location = new System.Drawing.Point(452, 267);
            this.groupBoxDopElems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDopElems.Name = "groupBoxDopElems";
            this.groupBoxDopElems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDopElems.Size = new System.Drawing.Size(212, 167);
            this.groupBoxDopElems.TabIndex = 10;
            this.groupBoxDopElems.TabStop = false;
            this.groupBoxDopElems.Text = "Дополнительные элементы";
            // 
            // labelContainer
            // 
            this.labelContainer.AllowDrop = true;
            this.labelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContainer.Location = new System.Drawing.Point(24, 118);
            this.labelContainer.Name = "labelContainer";
            this.labelContainer.Size = new System.Drawing.Size(157, 40);
            this.labelContainer.TabIndex = 4;
            this.labelContainer.Text = "Контейнер";
            this.labelContainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelDopElements_MouseDown);
            // 
            // labelEllipse
            // 
            this.labelEllipse.AllowDrop = true;
            this.labelEllipse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEllipse.Location = new System.Drawing.Point(24, 78);
            this.labelEllipse.Name = "labelEllipse";
            this.labelEllipse.Size = new System.Drawing.Size(157, 40);
            this.labelEllipse.TabIndex = 3;
            this.labelEllipse.Text = "Круглые";
            this.labelEllipse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEllipse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelDopElements_MouseDown);
            // 
            // labelTriangle
            // 
            this.labelTriangle.AllowDrop = true;
            this.labelTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTriangle.Location = new System.Drawing.Point(24, 37);
            this.labelTriangle.Name = "labelTriangle";
            this.labelTriangle.Size = new System.Drawing.Size(157, 40);
            this.labelTriangle.TabIndex = 2;
            this.labelTriangle.Text = "Треугольные";
            this.labelTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTriangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelDopElements_MouseDown);
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 441);
            this.Controls.Add(this.groupBoxDopElems);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelwarplane);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBombs.ResumeLayout(false);
            this.groupBoxBombs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelwarplane.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxDopElems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEngines;
        private System.Windows.Forms.CheckBox checkBoxBombs;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelmaincolor;
        private System.Windows.Forms.Label labeldopcolor;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelfighter;
        private System.Windows.Forms.Label labelwarplane;
        private System.Windows.Forms.Panel panelwarplane;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelGrayColor;
        private System.Windows.Forms.Panel panelAquaColor;
        private System.Windows.Forms.Panel panelPinkColor;
        private System.Windows.Forms.Panel panelOrangeColor;
        private System.Windows.Forms.Panel panelBlueColor;
        private System.Windows.Forms.Panel panelLimeColor;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Panel panelRedColor;
        private System.Windows.Forms.RadioButton radioButtonSix;
        private System.Windows.Forms.RadioButton radioButtonFour;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.GroupBox groupBoxDopElems;
        private System.Windows.Forms.GroupBox groupBoxBombs;
        private System.Windows.Forms.Label labelContainer;
        private System.Windows.Forms.Label labelEllipse;
        private System.Windows.Forms.Label labelTriangle;
    }
}