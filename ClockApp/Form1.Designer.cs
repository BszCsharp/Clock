namespace ClockApp
{
    partial class FormStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMinPlus = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOnOff = new System.Windows.Forms.Label();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.timerOnOff = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.Color.DimGray;
            this.buttonMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMode.Location = new System.Drawing.Point(1, 433);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(95, 34);
            this.buttonMode.TabIndex = 0;
            this.buttonMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.DimGray;
            this.buttonAlarm.Location = new System.Drawing.Point(305, 433);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(95, 34);
            this.buttonAlarm.TabIndex = 1;
            this.buttonAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAlarm.UseVisualStyleBackColor = false;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.DimGray;
            this.buttonPlus.Location = new System.Drawing.Point(102, 433);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(64, 34);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinus.Location = new System.Drawing.Point(172, 433);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(64, 34);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMinPlus
            // 
            this.buttonMinPlus.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinPlus.Location = new System.Drawing.Point(235, 433);
            this.buttonMinPlus.Name = "buttonMinPlus";
            this.buttonMinPlus.Size = new System.Drawing.Size(64, 34);
            this.buttonMinPlus.TabIndex = 4;
            this.buttonMinPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMinPlus.UseVisualStyleBackColor = false;
            this.buttonMinPlus.Click += new System.EventHandler(this.buttonMinPlus_Click);
            this.buttonMinPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMinPlus_MouseDown);
            this.buttonMinPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMinPlus_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "background.png");
            this.imageList1.Images.SetKeyName(1, "clock.png");
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Quartz MS", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Image = global::ClockApp.Properties.Resources.background;
            this.labelTime.Location = new System.Drawing.Point(71, 197);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(199, 72);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Quartz MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Image = global::ClockApp.Properties.Resources.background;
            this.labelSeconds.Location = new System.Drawing.Point(266, 232);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(49, 33);
            this.labelSeconds.TabIndex = 9;
            this.labelSeconds.Text = "00";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Quartz MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.Image = global::ClockApp.Properties.Resources.background;
            this.labelMode.Location = new System.Drawing.Point(79, 303);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(67, 24);
            this.labelMode.TabIndex = 10;
            this.labelMode.Text = "Clock";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Quartz MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Image = global::ClockApp.Properties.Resources.background;
            this.labelDay.Location = new System.Drawing.Point(111, 131);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(59, 40);
            this.labelDay.TabIndex = 11;
            this.labelDay.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::ClockApp.Properties.Resources.background;
            this.label5.Location = new System.Drawing.Point(80, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::ClockApp.Properties.Resources.background;
            this.label6.Location = new System.Drawing.Point(186, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "M";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Quartz MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Image = global::ClockApp.Properties.Resources.background;
            this.labelMonth.Location = new System.Drawing.Point(228, 131);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(60, 41);
            this.labelMonth.TabIndex = 14;
            this.labelMonth.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Font = new System.Drawing.Font("Quartz MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnOff.Image = global::ClockApp.Properties.Resources.background;
            this.labelOnOff.Location = new System.Drawing.Point(248, 303);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(45, 24);
            this.labelOnOff.TabIndex = 15;
            this.labelOnOff.Text = "OFF";
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.BackgroundImage = global::ClockApp.Properties.Resources.off;
            this.buttonOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOnOff.Location = new System.Drawing.Point(181, 3);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(39, 37);
            this.buttonOnOff.TabIndex = 16;
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // timerOnOff
            // 
            this.timerOnOff.Interval = 1000;
            this.timerOnOff.Tick += new System.EventHandler(this.timerOnOff_Tick);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClockApp.Properties.Resources.clock;
            this.ClientSize = new System.Drawing.Size(399, 479);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonMinPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonMode);
            this.Name = "FormStart";
            this.Text = "Wecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMinPlus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.Timer timerOnOff;
    }
}

