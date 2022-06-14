namespace Programming.View.Control
{
    partial class WeekdayParsingControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TryParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TryParsingLabel);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(352, 90);
            this.WeekdayGroupBox.TabIndex = 8;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(25, 77);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 20);
            this.OutputWeekdayLabel.TabIndex = 8;
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(231, 37);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(75, 23);
            this.ParseWeekdayButton.TabIndex = 7;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(6, 39);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(219, 20);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // TryParsingLabel
            // 
            this.TryParsingLabel.AutoSize = true;
            this.TryParsingLabel.Location = new System.Drawing.Point(3, 23);
            this.TryParsingLabel.Name = "TryParsingLabel";
            this.TryParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.TryParsingLabel.TabIndex = 6;
            this.TryParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(352, 90);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label TryParsingLabel;
    }
}
