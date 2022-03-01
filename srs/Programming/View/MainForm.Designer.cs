namespace WindowsFormsApp5
{
    partial class MainForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gobutton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Weekday = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekTextbox = new System.Windows.Forms.TextBox();
            this.ParseInput = new System.Windows.Forms.Button();
            this.OutLabelWeekday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Weekday.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Weekday);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ValueListBox);
            this.tabPage1.Controls.Add(this.EnumsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Gobutton);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(350, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 97);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekday Parsing";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type value for Parsing:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // Gobutton
            // 
            this.Gobutton.Location = new System.Drawing.Point(204, 44);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(75, 23);
            this.Gobutton.TabIndex = 13;
            this.Gobutton.Text = "GO!";
            this.Gobutton.UseVisualStyleBackColor = true;
            this.Gobutton.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Weekday
            // 
            this.Weekday.Controls.Add(this.label4);
            this.Weekday.Controls.Add(this.WeekTextbox);
            this.Weekday.Controls.Add(this.ParseInput);
            this.Weekday.Controls.Add(this.OutLabelWeekday);
            this.Weekday.Location = new System.Drawing.Point(11, 314);
            this.Weekday.Name = "Weekday";
            this.Weekday.Size = new System.Drawing.Size(319, 97);
            this.Weekday.TabIndex = 15;
            this.Weekday.TabStop = false;
            this.Weekday.Text = "Weekday Parsing";
            this.Weekday.Enter += new System.EventHandler(this.Weekday_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type value for Parsing:";
            // 
            // WeekTextbox
            // 
            this.WeekTextbox.Location = new System.Drawing.Point(9, 44);
            this.WeekTextbox.Name = "WeekTextbox";
            this.WeekTextbox.Size = new System.Drawing.Size(190, 20);
            this.WeekTextbox.TabIndex = 9;
            this.WeekTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ParseInput
            // 
            this.ParseInput.Location = new System.Drawing.Point(205, 41);
            this.ParseInput.Name = "ParseInput";
            this.ParseInput.Size = new System.Drawing.Size(75, 23);
            this.ParseInput.TabIndex = 10;
            this.ParseInput.Text = "Parse";
            this.ParseInput.UseVisualStyleBackColor = true;
            this.ParseInput.Click += new System.EventHandler(this.ParseInput_Click);
            // 
            // OutLabelWeekday
            // 
            this.OutLabelWeekday.AutoSize = true;
            this.OutLabelWeekday.Location = new System.Drawing.Point(18, 67);
            this.OutLabelWeekday.Name = "OutLabelWeekday";
            this.OutLabelWeekday.Size = new System.Drawing.Size(0, 13);
            this.OutLabelWeekday.TabIndex = 11;
            this.OutLabelWeekday.Click += new System.EventHandler(this.OutLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose enumaration:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Int Value";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(180, 40);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(150, 225);
            this.ValueListBox.TabIndex = 1;
            this.ValueListBox.Tag = "";
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(10, 40);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(150, 225);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.Tag = "";
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Weekday.ResumeLayout(false);
            this.Weekday.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ParseInput;
        private System.Windows.Forms.TextBox WeekTextbox;
        private System.Windows.Forms.Label OutLabelWeekday;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox Weekday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

