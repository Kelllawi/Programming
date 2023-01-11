namespace ObjectOrientedPractics
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
            this.ItemsTabControl = new System.Windows.Forms.TabPage();
            this.CustomersTabControl = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ItemsTabControl);
            this.tabControl1.Controls.Add(this.CustomersTabControl);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabControl.Size = new System.Drawing.Size(806, 495);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.Text = "Items";
            this.ItemsTabControl.UseVisualStyleBackColor = true;
            // 
            // CustomersTabControl
            // 
            this.CustomersTabControl.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabControl.Name = "CustomersTabControl";
            this.CustomersTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabControl.Size = new System.Drawing.Size(806, 495);
            this.CustomersTabControl.TabIndex = 1;
            this.CustomersTabControl.Text = "Customers";
            this.CustomersTabControl.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ItemsTabControl;
        private System.Windows.Forms.TabPage CustomersTabControl;
    }
}

