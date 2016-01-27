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
            this.buttonC_F = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.Color.DimGray;
            this.buttonMode.BackgroundImage = global::ClockApp.Properties.Resources.background;
            this.buttonMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMode.Location = new System.Drawing.Point(1, 433);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(95, 34);
            this.buttonMode.TabIndex = 0;
            this.buttonMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMode.UseVisualStyleBackColor = false;
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.DimGray;
            this.buttonAlarm.BackgroundImage = global::ClockApp.Properties.Resources.background;
            this.buttonAlarm.Location = new System.Drawing.Point(305, 433);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(95, 34);
            this.buttonAlarm.TabIndex = 1;
            this.buttonAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAlarm.UseVisualStyleBackColor = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.DimGray;
            this.buttonPlus.BackgroundImage = global::ClockApp.Properties.Resources.background;
            this.buttonPlus.Location = new System.Drawing.Point(102, 433);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(64, 34);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPlus.UseVisualStyleBackColor = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinus.BackgroundImage = global::ClockApp.Properties.Resources.background;
            this.buttonMinus.Location = new System.Drawing.Point(172, 433);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(64, 34);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonC_F
            // 
            this.buttonC_F.BackColor = System.Drawing.Color.DimGray;
            this.buttonC_F.BackgroundImage = global::ClockApp.Properties.Resources.background;
            this.buttonC_F.Location = new System.Drawing.Point(235, 433);
            this.buttonC_F.Name = "buttonC_F";
            this.buttonC_F.Size = new System.Drawing.Size(64, 34);
            this.buttonC_F.TabIndex = 4;
            this.buttonC_F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonC_F.UseVisualStyleBackColor = false;
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
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Image = global::ClockApp.Properties.Resources.background;
            this.labelDay.Location = new System.Drawing.Point(111, 131);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(55, 39);
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
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Image = global::ClockApp.Properties.Resources.background;
            this.labelMonth.Location = new System.Drawing.Point(228, 131);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(55, 39);
            this.labelMonth.TabIndex = 14;
            this.labelMonth.Text = "00";
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Font = new System.Drawing.Font("Quartz MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnOff.Image = global::ClockApp.Properties.Resources.background;
            this.labelOnOff.Location = new System.Drawing.Point(231, 303);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(45, 24);
            this.labelOnOff.TabIndex = 15;
            this.labelOnOff.Text = "OFF";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClockApp.Properties.Resources.clock;
            this.ClientSize = new System.Drawing.Size(399, 479);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonC_F);
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
        private System.Windows.Forms.Button buttonC_F;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelOnOff;
    }
}

