namespace Programming.View.Control
{
    partial class EnumsControl
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
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.ChooseEnumLabel);
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.EnumListBox);
            this.EnumGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox.Controls.Add(this.ValueListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(529, 431);
            this.EnumGroupBox.TabIndex = 7;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumeration";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(3, 16);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumLabel.TabIndex = 1;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(315, 16);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(6, 32);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(150, 199);
            this.EnumListBox.TabIndex = 0;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(318, 32);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(185, 20);
            this.IntValueTextBox.TabIndex = 4;
            this.IntValueTextBox.TextChanged += new System.EventHandler(this.IntValueTextBox_TextChanged);
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(162, 32);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(150, 199);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(159, 16);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumGroupBox);
            this.Name = "EnumsControl";
            this.Size = new System.Drawing.Size(529, 434);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.Label ChooseEnumLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label ChooseValueLabel;
    }
}
