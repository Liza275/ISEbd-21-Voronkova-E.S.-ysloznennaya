namespace WindowsFormsPlaneUsl
{
    partial class FormFighter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFighter));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pictureBoxfighter = new System.Windows.Forms.PictureBox();
            this.setBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateWarplane = new System.Windows.Forms.Button();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.checkBoxEllipse = new System.Windows.Forms.CheckBox();
            this.checkBoxContainer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(103, 39);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsPlaneUsl.Properties.Resources.green_arrow_arrow_up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(856, 372);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(820, 408);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsPlaneUsl.Properties.Resources.kisspng_the_station_church_arrow_clip_art_5b38af4e54ea72_2767045215304415503478;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDown.Location = new System.Drawing.Point(856, 408);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsPlaneUsl.Properties.Resources.computer_icons_arrow_symbol_direction;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(892, 408);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // pictureBoxfighter
            // 
            this.pictureBoxfighter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxfighter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxfighter.Name = "pictureBoxfighter";
            this.pictureBoxfighter.Size = new System.Drawing.Size(933, 450);
            this.pictureBoxfighter.TabIndex = 5;
            this.pictureBoxfighter.TabStop = false;
            // 
            // setBoxNum
            // 
            this.setBoxNum.Location = new System.Drawing.Point(346, 21);
            this.setBoxNum.Name = "setBoxNum";
            this.setBoxNum.Size = new System.Drawing.Size(39, 22);
            this.setBoxNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bombs:";
            // 
            // buttonCreateWarplane
            // 
            this.buttonCreateWarplane.Location = new System.Drawing.Point(121, 12);
            this.buttonCreateWarplane.Name = "buttonCreateWarplane";
            this.buttonCreateWarplane.Size = new System.Drawing.Size(146, 39);
            this.buttonCreateWarplane.TabIndex = 8;
            this.buttonCreateWarplane.Text = "Военный самолет";
            this.buttonCreateWarplane.UseVisualStyleBackColor = true;
            this.buttonCreateWarplane.Click += new System.EventHandler(this.ButtonCreateWarplane_Click);
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Checked = true;
            this.checkBoxTriangle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTriangle.Location = new System.Drawing.Point(415, 23);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(116, 21);
            this.checkBoxTriangle.TabIndex = 9;
            this.checkBoxTriangle.Text = "Треугольные";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            this.checkBoxTriangle.Click += new System.EventHandler(this.CheckBoxTriangle_Click);
            // 
            // checkBoxEllipse
            // 
            this.checkBoxEllipse.AutoSize = true;
            this.checkBoxEllipse.Location = new System.Drawing.Point(547, 23);
            this.checkBoxEllipse.Name = "checkBoxEllipse";
            this.checkBoxEllipse.Size = new System.Drawing.Size(85, 21);
            this.checkBoxEllipse.TabIndex = 10;
            this.checkBoxEllipse.Text = "Круглые";
            this.checkBoxEllipse.UseVisualStyleBackColor = true;
            this.checkBoxEllipse.Click += new System.EventHandler(this.CheckBoxEllipse_Click);
            // 
            // checkBoxContainer
            // 
            this.checkBoxContainer.AutoSize = true;
            this.checkBoxContainer.Location = new System.Drawing.Point(647, 23);
            this.checkBoxContainer.Name = "checkBoxContainer";
            this.checkBoxContainer.Size = new System.Drawing.Size(102, 21);
            this.checkBoxContainer.TabIndex = 11;
            this.checkBoxContainer.Text = "Контейнер";
            this.checkBoxContainer.UseVisualStyleBackColor = true;
            this.checkBoxContainer.Click += new System.EventHandler(this.CheckBoxContainer_Click);
            // 
            // FormFighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.checkBoxContainer);
            this.Controls.Add(this.checkBoxEllipse);
            this.Controls.Add(this.checkBoxTriangle);
            this.Controls.Add(this.buttonCreateWarplane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setBoxNum);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxfighter);
            this.Name = "FormFighter";
            this.Text = "Истребитель";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.PictureBox pictureBoxfighter;
        private System.Windows.Forms.TextBox setBoxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateWarplane;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.CheckBox checkBoxEllipse;
        private System.Windows.Forms.CheckBox checkBoxContainer;
    }
}

