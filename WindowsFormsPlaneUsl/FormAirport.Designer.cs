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
            this.buttonSetWarplane = new System.Windows.Forms.Button();
            this.buttonSetFighter = new System.Windows.Forms.Button();
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.buttonTakePLane = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.listBoxAiports = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelAirport = new System.Windows.Forms.Label();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.buttonDelAirport = new System.Windows.Forms.Button();
            this.buttonFly = new System.Windows.Forms.Button();
            this.groupBoxPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetWarplane
            // 
            this.buttonSetWarplane.Location = new System.Drawing.Point(763, 448);
            this.buttonSetWarplane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetWarplane.Name = "buttonSetWarplane";
            this.buttonSetWarplane.Size = new System.Drawing.Size(165, 42);
            this.buttonSetWarplane.TabIndex = 0;
            this.buttonSetWarplane.Text = "Припарковать военный самолет";
            this.buttonSetWarplane.UseVisualStyleBackColor = true;
            this.buttonSetWarplane.Click += new System.EventHandler(this.buttonSetWarplane_Click);
            // 
            // buttonSetFighter
            // 
            this.buttonSetFighter.Location = new System.Drawing.Point(763, 495);
            this.buttonSetFighter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetFighter.Name = "buttonSetFighter";
            this.buttonSetFighter.Size = new System.Drawing.Size(165, 42);
            this.buttonSetFighter.TabIndex = 1;
            this.buttonSetFighter.Text = "Припарковать истребитель";
            this.buttonSetFighter.UseVisualStyleBackColor = true;
            this.buttonSetFighter.Click += new System.EventHandler(this.buttonSetFighter_Click);
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.buttonTakePLane);
            this.groupBoxPlane.Controls.Add(this.labelPlace);
            this.groupBoxPlane.Controls.Add(this.maskedTextBox);
            this.groupBoxPlane.Location = new System.Drawing.Point(763, 553);
            this.groupBoxPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPlane.Size = new System.Drawing.Size(165, 100);
            this.groupBoxPlane.TabIndex = 2;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Забрать самолет";
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
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(23, 39);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(49, 17);
            this.labelPlace.TabIndex = 1;
            this.labelPlace.Text = "Место";
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
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(743, 666);
            this.pictureBoxAirport.TabIndex = 3;
            this.pictureBoxAirport.TabStop = false;
            // 
            // listBoxAiports
            // 
            this.listBoxAiports.FormattingEnabled = true;
            this.listBoxAiports.ItemHeight = 16;
            this.listBoxAiports.Location = new System.Drawing.Point(763, 138);
            this.listBoxAiports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxAiports.Name = "listBoxAiports";
            this.listBoxAiports.Size = new System.Drawing.Size(164, 116);
            this.listBoxAiports.TabIndex = 4;
            this.listBoxAiports.SelectedIndexChanged += new System.EventHandler(this.ListBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(763, 43);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(164, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // labelAirport
            // 
            this.labelAirport.AutoSize = true;
            this.labelAirport.Location = new System.Drawing.Point(804, 23);
            this.labelAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAirport.Name = "labelAirport";
            this.labelAirport.Size = new System.Drawing.Size(81, 17);
            this.labelAirport.TabIndex = 6;
            this.labelAirport.Text = "Аэропорты";
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.Location = new System.Drawing.Point(763, 74);
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
            this.buttonDelAirport.Location = new System.Drawing.Point(763, 261);
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
            this.buttonFly.Location = new System.Drawing.Point(763, 400);
            this.buttonFly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(165, 42);
            this.buttonFly.TabIndex = 10;
            this.buttonFly.Text = "Полетать";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.ButtonFly_Click);
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.Controls.Add(this.buttonFly);
            this.Controls.Add(this.buttonDelAirport);
            this.Controls.Add(this.buttonAddAirport);
            this.Controls.Add(this.labelAirport);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxAiports);
            this.Controls.Add(this.pictureBoxAirport);
            this.Controls.Add(this.groupBoxPlane);
            this.Controls.Add(this.buttonSetFighter);
            this.Controls.Add(this.buttonSetWarplane);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAirport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAirport";
            this.groupBoxPlane.ResumeLayout(false);
            this.groupBoxPlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetWarplane;
        private System.Windows.Forms.Button buttonSetFighter;
        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Button buttonTakePLane;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxAirport;
        private System.Windows.Forms.ListBox listBoxAiports;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelAirport;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.Button buttonDelAirport;
        private System.Windows.Forms.Button buttonFly;
    }
}