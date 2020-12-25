namespace WindowsFormsPlaneUsl
{
    partial class FormAirport
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonTakePLane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.listBoxAiports = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.buttonDelAirport = new System.Windows.Forms.Button();
            this.buttonFly = new System.Windows.Forms.Button();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьАэропортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьАэропортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonTakePLane);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Location = new System.Drawing.Point(763, 553);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(165, 100);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // buttonTakePLane
            // 
            this.buttonTakePLane.Location = new System.Drawing.Point(45, 71);
            this.buttonTakePLane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTakePLane.Name = "buttonTakePLane";
            this.buttonTakePLane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakePLane.TabIndex = 2;
            this.buttonTakePLane.Text = "Забрать";
            this.buttonTakePLane.UseVisualStyleBackColor = true;
            this.buttonTakePLane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(77, 36);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(57, 22);
            this.maskedTextBox.TabIndex = 0;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // pictureBoxAirport
            // 
            this.pictureBoxAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(743, 636);
            this.pictureBoxAirport.TabIndex = 3;
            this.pictureBoxAirport.TabStop = false;
            // 
            // listBoxAiports
            // 
            this.listBoxAiports.FormattingEnabled = true;
            this.listBoxAiports.ItemHeight = 16;
            this.listBoxAiports.Location = new System.Drawing.Point(764, 154);
            this.listBoxAiports.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAiports.Name = "listBoxAiports";
            this.listBoxAiports.Size = new System.Drawing.Size(164, 116);
            this.listBoxAiports.TabIndex = 4;
            this.listBoxAiports.SelectedIndexChanged += new System.EventHandler(this.ListBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(764, 59);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(164, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Аэропорты";
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.Location = new System.Drawing.Point(764, 90);
            this.buttonAddAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAirport.Name = "buttonAddAirport";
            this.buttonAddAirport.Size = new System.Drawing.Size(165, 58);
            this.buttonAddAirport.TabIndex = 7;
            this.buttonAddAirport.Text = "Добавить аэропорт";
            this.buttonAddAirport.UseVisualStyleBackColor = true;
            this.buttonAddAirport.Click += new System.EventHandler(this.ButtonAddAirport_Click);
            // 
            // buttonDelAirport
            // 
            this.buttonDelAirport.Location = new System.Drawing.Point(764, 277);
            this.buttonDelAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelAirport.Name = "buttonDelAirport";
            this.buttonDelAirport.Size = new System.Drawing.Size(165, 55);
            this.buttonDelAirport.TabIndex = 9;
            this.buttonDelAirport.Text = "Удалить аэропорт";
            this.buttonDelAirport.UseVisualStyleBackColor = true;
            this.buttonDelAirport.Click += new System.EventHandler(this.ButtonDelAirport_Click);
            // 
            // buttonFly
            // 
            this.buttonFly.Location = new System.Drawing.Point(764, 431);
            this.buttonFly.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(165, 55);
            this.buttonFly.TabIndex = 10;
            this.buttonFly.Text = "Полетать";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.ButtonFly_Click);
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(764, 492);
            this.buttonAddPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(165, 55);
            this.buttonAddPlane.TabIndex = 11;
            this.buttonAddPlane.Text = "Добавить самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.ButtonAddPlane_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 30);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem1,
            this.сохранитьАэропортToolStripMenuItem,
            this.загрузитьАэропортToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.сохранитьToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.загрузитьToolStripMenuItem.Text = "Сохранить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.загрузитьToolStripMenuItem1.Text = "Загрузить";
            this.загрузитьToolStripMenuItem1.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem1_Click);
            // 
            // сохранитьАэропортToolStripMenuItem
            // 
            this.сохранитьАэропортToolStripMenuItem.Name = "сохранитьАэропортToolStripMenuItem";
            this.сохранитьАэропортToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сохранитьАэропортToolStripMenuItem.Text = "Сохранить аэропорт";
            this.сохранитьАэропортToolStripMenuItem.Click += new System.EventHandler(this.СохранитьАэропортToolStripMenuItem_Click);
            // 
            // загрузитьАэропортToolStripMenuItem
            // 
            this.загрузитьАэропортToolStripMenuItem.Name = "загрузитьАэропортToolStripMenuItem";
            this.загрузитьАэропортToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.загрузитьАэропортToolStripMenuItem.Text = "Загрузить аэропорт";
            this.загрузитьАэропортToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьАэропортToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "«txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "«txt file | *.txt";
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(763, 363);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(164, 52);
            this.ButtonSort.TabIndex = 13;
            this.ButtonSort.Text = "Сортировать";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.buttonFly);
            this.Controls.Add(this.buttonDelAirport);
            this.Controls.Add(this.buttonAddAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxAiports);
            this.Controls.Add(this.pictureBoxAirport);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAirport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAirport";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonTakePLane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxAirport;
        private System.Windows.Forms.ListBox listBoxAiports;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.Button buttonDelAirport;
        private System.Windows.Forms.Button buttonFly;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem сохранитьАэропортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьАэропортToolStripMenuItem;
        private System.Windows.Forms.Button ButtonSort;
    }
}