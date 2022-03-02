namespace Programming.View
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.ChooseEnumeration = new System.Windows.Forms.Label();
            this.SeasonHandle = new System.Windows.Forms.GroupBox();
            this.ChooseSeason = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.Weekday = new System.Windows.Forms.GroupBox();
            this.TypeValueForParsing = new System.Windows.Forms.Label();
            this.WeekTextbox = new System.Windows.Forms.TextBox();
            this.ParseInputButton = new System.Windows.Forms.Button();
            this.OutLabelWeekday = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.Weekday.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 469);
            this.tabControl1.TabIndex = 1;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.Enumerations);
            this.Enums.Controls.Add(this.SeasonHandle);
            this.Enums.Controls.Add(this.Weekday);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(761, 443);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.ValueListBox);
            this.Enumerations.Controls.Add(this.EnumsListBox);
            this.Enumerations.Controls.Add(this.IntValue);
            this.Enumerations.Controls.Add(this.ChooseValue);
            this.Enumerations.Controls.Add(this.IntBox);
            this.Enumerations.Controls.Add(this.ChooseEnumeration);
            this.Enumerations.Location = new System.Drawing.Point(8, 6);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(670, 310);
            this.Enumerations.TabIndex = 17;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(180, 40);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(150, 225);
            this.ValueListBox.TabIndex = 1;
            this.ValueListBox.Tag = "";
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(8, 40);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(150, 225);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.Tag = "";
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(350, 25);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(52, 13);
            this.IntValue.TabIndex = 5;
            this.IntValue.Text = "Int Value:";
            // 
            // ChooseValue
            // 
            this.ChooseValue.AutoSize = true;
            this.ChooseValue.Location = new System.Drawing.Point(178, 25);
            this.ChooseValue.Name = "ChooseValue";
            this.ChooseValue.Size = new System.Drawing.Size(76, 13);
            this.ChooseValue.TabIndex = 8;
            this.ChooseValue.Text = "Choose Value:";
            // 
            // IntBox
            // 
            this.IntBox.Location = new System.Drawing.Point(350, 40);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(100, 20);
            this.IntBox.TabIndex = 6;
            // 
            // ChooseEnumeration
            // 
            this.ChooseEnumeration.AutoSize = true;
            this.ChooseEnumeration.Location = new System.Drawing.Point(7, 25);
            this.ChooseEnumeration.Name = "ChooseEnumeration";
            this.ChooseEnumeration.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumeration.TabIndex = 7;
            this.ChooseEnumeration.Text = "Choose enumeration:";
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.ChooseSeason);
            this.SeasonHandle.Controls.Add(this.GoButton);
            this.SeasonHandle.Controls.Add(this.SeasonsComboBox);
            this.SeasonHandle.Location = new System.Drawing.Point(358, 315);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Size = new System.Drawing.Size(320, 100);
            this.SeasonHandle.TabIndex = 16;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // ChooseSeason
            // 
            this.ChooseSeason.AutoSize = true;
            this.ChooseSeason.Location = new System.Drawing.Point(6, 28);
            this.ChooseSeason.Name = "ChooseSeason";
            this.ChooseSeason.Size = new System.Drawing.Size(82, 13);
            this.ChooseSeason.TabIndex = 11;
            this.ChooseSeason.Text = "Choose Season";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(204, 44);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 13;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(9, 44);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(189, 21);
            this.SeasonsComboBox.TabIndex = 14;
            // 
            // Weekday
            // 
            this.Weekday.Controls.Add(this.TypeValueForParsing);
            this.Weekday.Controls.Add(this.WeekTextbox);
            this.Weekday.Controls.Add(this.ParseInputButton);
            this.Weekday.Controls.Add(this.OutLabelWeekday);
            this.Weekday.Location = new System.Drawing.Point(8, 315);
            this.Weekday.Name = "Weekday";
            this.Weekday.Size = new System.Drawing.Size(320, 100);
            this.Weekday.TabIndex = 15;
            this.Weekday.TabStop = false;
            this.Weekday.Text = "Weekday Parsing";
            // 
            // TypeValueForParsing
            // 
            this.TypeValueForParsing.AutoSize = true;
            this.TypeValueForParsing.Location = new System.Drawing.Point(6, 28);
            this.TypeValueForParsing.Name = "TypeValueForParsing";
            this.TypeValueForParsing.Size = new System.Drawing.Size(116, 13);
            this.TypeValueForParsing.TabIndex = 11;
            this.TypeValueForParsing.Text = "Type value for Parsing:";
            // 
            // WeekTextbox
            // 
            this.WeekTextbox.Location = new System.Drawing.Point(8, 45);
            this.WeekTextbox.Name = "WeekTextbox";
            this.WeekTextbox.Size = new System.Drawing.Size(190, 20);
            this.WeekTextbox.TabIndex = 9;
            // 
            // ParseInputButton
            // 
            this.ParseInputButton.Location = new System.Drawing.Point(205, 44);
            this.ParseInputButton.Name = "ParseInputButton";
            this.ParseInputButton.Size = new System.Drawing.Size(79, 22);
            this.ParseInputButton.TabIndex = 10;
            this.ParseInputButton.Text = "Parse";
            this.ParseInputButton.UseVisualStyleBackColor = true;
            this.ParseInputButton.Click += new System.EventHandler(this.ParseInput_Click);
            // 
            // OutLabelWeekday
            // 
            this.OutLabelWeekday.AutoSize = true;
            this.OutLabelWeekday.Location = new System.Drawing.Point(18, 67);
            this.OutLabelWeekday.Name = "OutLabelWeekday";
            this.OutLabelWeekday.Size = new System.Drawing.Size(0, 13);
            this.OutLabelWeekday.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.Weekday.ResumeLayout(false);
            this.Weekday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.GroupBox SeasonHandle;
        private System.Windows.Forms.Label ChooseSeason;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.GroupBox Weekday;
        private System.Windows.Forms.Label TypeValueForParsing;
        private System.Windows.Forms.TextBox WeekTextbox;
        private System.Windows.Forms.Button ParseInputButton;
        private System.Windows.Forms.Label OutLabelWeekday;
        private System.Windows.Forms.Label ChooseValue;
        private System.Windows.Forms.Label ChooseEnumeration;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.Label IntValue;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox Enumerations;
    }
}

