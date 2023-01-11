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
            this.itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.SuspendLayout();
            // 
            // itemsTabs1
            // 
            this.itemsTabs1.Location = new System.Drawing.Point(1, -4);
            this.itemsTabs1.Name = "itemsTabs1";
            this.itemsTabs1.Size = new System.Drawing.Size(800, 530);
            this.itemsTabs1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.itemsTabs1);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.Tabs.ItemsTabs itemsTabs1;
    }
}

