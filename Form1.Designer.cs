namespace exercise2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox = new System.Windows.Forms.ListBox();
            this.EditBox = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewDiary = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 19;
            this.listBox.Location = new System.Drawing.Point(12, 40);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(152, 327);
            this.listBox.TabIndex = 1;
            this.listBox.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // EditBox
            // 
            this.EditBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.EditBox.Location = new System.Drawing.Point(170, 40);
            this.EditBox.Margin = new System.Windows.Forms.Padding(0);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(403, 400);
            this.EditBox.TabIndex = 2;
            this.EditBox.Text = "";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(47, 392);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 29);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(170, 12);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(197, 22);
            this.TitleBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title :";
            // 
            // NewDiary
            // 
            this.NewDiary.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewDiary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDiary.Location = new System.Drawing.Point(12, 3);
            this.NewDiary.Name = "NewDiary";
            this.NewDiary.Size = new System.Drawing.Size(75, 33);
            this.NewDiary.TabIndex = 7;
            this.NewDiary.Text = "New";
            this.NewDiary.UseVisualStyleBackColor = false;
            this.NewDiary.Click += new System.EventHandler(this.NewDiary_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.Location = new System.Drawing.Point(386, 10);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(187, 23);
            this.TimeBox.TabIndex = 20;
            this.TimeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 452);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.NewDiary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EditBox);
            this.Controls.Add(this.listBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox EditBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewDiary;
        private System.Windows.Forms.Label TimeBox;
        private System.Windows.Forms.Timer timer1;
    }
}

