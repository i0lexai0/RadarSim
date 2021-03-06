﻿namespace Radar
{
    partial class FormRadar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadar));
            this.pictureBoxRadar = new System.Windows.Forms.PictureBox();
            this.buttonAddTarget = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonStartRotate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonStopRotate = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonFlying = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonStopFly = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRadar
            // 
            this.pictureBoxRadar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxRadar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRadar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRadar.Name = "pictureBoxRadar";
            this.pictureBoxRadar.Size = new System.Drawing.Size(1021, 609);
            this.pictureBoxRadar.TabIndex = 0;
            this.pictureBoxRadar.TabStop = false;
            this.pictureBoxRadar.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxRadar_Paint);
            this.pictureBoxRadar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxFormRadar_MouseMove);
            this.pictureBoxRadar.Resize += new System.EventHandler(this.PictureBoxRadar_Resize);
            // 
            // buttonAddTarget
            // 
            this.buttonAddTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTarget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTarget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddTarget.Location = new System.Drawing.Point(875, 12);
            this.buttonAddTarget.Name = "buttonAddTarget";
            this.buttonAddTarget.Size = new System.Drawing.Size(134, 33);
            this.buttonAddTarget.TabIndex = 4;
            this.buttonAddTarget.Text = "Добавить";
            this.buttonAddTarget.UseVisualStyleBackColor = false;
            this.buttonAddTarget.Click += new System.EventHandler(this.ButtonAddTarget_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(875, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Масштаб";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "150";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "75";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(875, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скорость вращения";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(63, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "12 об";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "6 об";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // buttonStartRotate
            // 
            this.buttonStartRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartRotate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStartRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartRotate.BackgroundImage")));
            this.buttonStartRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartRotate.FlatAppearance.BorderSize = 0;
            this.buttonStartRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartRotate.Location = new System.Drawing.Point(875, 426);
            this.buttonStartRotate.Name = "buttonStartRotate";
            this.buttonStartRotate.Size = new System.Drawing.Size(40, 30);
            this.buttonStartRotate.TabIndex = 14;
            this.buttonStartRotate.UseVisualStyleBackColor = false;
            this.buttonStartRotate.Click += new System.EventHandler(this.ButtonStartRotate_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(921, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonStopRotate
            // 
            this.buttonStopRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopRotate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStopRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopRotate.BackgroundImage")));
            this.buttonStopRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStopRotate.FlatAppearance.BorderSize = 0;
            this.buttonStopRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopRotate.Location = new System.Drawing.Point(969, 426);
            this.buttonStopRotate.Name = "buttonStopRotate";
            this.buttonStopRotate.Size = new System.Drawing.Size(40, 30);
            this.buttonStopRotate.TabIndex = 16;
            this.buttonStopRotate.UseVisualStyleBackColor = false;
            this.buttonStopRotate.Click += new System.EventHandler(this.ButtonStopRotate_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonFlying
            // 
            this.buttonFlying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlying.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFlying.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFlying.Location = new System.Drawing.Point(875, 264);
            this.buttonFlying.Name = "buttonFlying";
            this.buttonFlying.Size = new System.Drawing.Size(134, 36);
            this.buttonFlying.TabIndex = 14;
            this.buttonFlying.Text = "Налет";
            this.buttonFlying.UseVisualStyleBackColor = false;
            this.buttonFlying.Click += new System.EventHandler(this.ButtonFlying_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(875, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Показать";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Координаты";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Номер";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Маршрут";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonStopFly
            // 
            this.buttonStopFly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopFly.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStopFly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStopFly.Location = new System.Drawing.Point(875, 316);
            this.buttonStopFly.Name = "buttonStopFly";
            this.buttonStopFly.Size = new System.Drawing.Size(134, 36);
            this.buttonStopFly.TabIndex = 18;
            this.buttonStopFly.Text = "Стоп";
            this.buttonStopFly.UseVisualStyleBackColor = false;
            this.buttonStopFly.Click += new System.EventHandler(this.ButtonStopFly_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPhoto.Location = new System.Drawing.Point(875, 371);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(134, 36);
            this.buttonPhoto.TabIndex = 19;
            this.buttonPhoto.Text = "Фото";
            this.buttonPhoto.UseVisualStyleBackColor = false;
            this.buttonPhoto.Click += new System.EventHandler(this.ButtonPhoto_Click);
            // 
            // FormRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 609);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonStopFly);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonStopRotate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonStartRotate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFlying);
            this.Controls.Add(this.buttonAddTarget);
            this.Controls.Add(this.pictureBoxRadar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRadar";
            this.Text = "Radar";
            this.SizeChanged += new System.EventHandler(this.FormRadar_SizeChanged);
            this.Resize += new System.EventHandler(this.FormRadar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRadar;
        private System.Windows.Forms.Button buttonAddTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buttonStartRotate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStopRotate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonFlying;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonStopFly;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonPhoto;
    }
}

