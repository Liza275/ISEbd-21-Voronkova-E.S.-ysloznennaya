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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakePLane = new System.Windows.Forms.Button();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetWarplane
            // 
            this.buttonSetWarplane.Location = new System.Drawing.Point(762, 15);
            this.buttonSetWarplane.Name = "buttonSetWarplane";
            this.buttonSetWarplane.Size = new System.Drawing.Size(165, 42);
            this.buttonSetWarplane.TabIndex = 0;
            this.buttonSetWarplane.Text = "Припарковать военный самолет";
            this.buttonSetWarplane.UseVisualStyleBackColor = true;
            this.buttonSetWarplane.Click += new System.EventHandler(this.buttonSetWarplane_Click);
            // 
            // buttonSetFighter
            // 
            this.buttonSetFighter.Location = new System.Drawing.Point(762, 81);
            this.buttonSetFighter.Name = "buttonSetFighter";
            this.buttonSetFighter.Size = new System.Drawing.Size(165, 42);
            this.buttonSetFighter.TabIndex = 1;
            this.buttonSetFighter.Text = "Припарковать истребитель";
            this.buttonSetFighter.UseVisualStyleBackColor = true;
            this.buttonSetFighter.Click += new System.EventHandler(this.buttonSetFighter_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonTakePLane);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Location = new System.Drawing.Point(762, 165);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(165, 100);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(78, 36);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(57, 22);
            this.maskedTextBox.TabIndex = 0;
            this.maskedTextBox.ValidatingType = typeof(int);
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
            // buttonTakePLane
            // 
            this.buttonTakePLane.Location = new System.Drawing.Point(46, 71);
            this.buttonTakePLane.Name = "buttonTakePLane";
            this.buttonTakePLane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakePLane.TabIndex = 2;
            this.buttonTakePLane.Text = "Забрать";
            this.buttonTakePLane.UseVisualStyleBackColor = true;
            this.buttonTakePLane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // pictureBoxAirport
            // 
            this.pictureBoxAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(743, 666);
            this.pictureBoxAirport.TabIndex = 3;
            this.pictureBoxAirport.TabStop = false;
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.Controls.Add(this.pictureBoxAirport);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonSetFighter);
            this.Controls.Add(this.buttonSetWarplane);
            this.Name = "FormAirport";
            this.Text = "FormAirport";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetWarplane;
        private System.Windows.Forms.Button buttonSetFighter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonTakePLane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxAirport;
    }
}