﻿namespace ObjectOrientedPractics
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
            this.itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.customersTabs1 = new ObjectOrientedPractics.View.Tabs.CustomersTabs();
            this.tabControl1.SuspendLayout();
            this.ItemsTabControl.SuspendLayout();
            this.CustomersTabControl.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(834, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.itemsTabs1);
            this.ItemsTabControl.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabControl.Size = new System.Drawing.Size(826, 515);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.Text = "Items";
            this.ItemsTabControl.UseVisualStyleBackColor = true;
            // 
            // CustomersTabControl
            // 
            this.CustomersTabControl.Controls.Add(this.customersTabs1);
            this.CustomersTabControl.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabControl.Name = "CustomersTabControl";
            this.CustomersTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabControl.Size = new System.Drawing.Size(826, 515);
            this.CustomersTabControl.TabIndex = 1;
            this.CustomersTabControl.Text = "Customers";
            this.CustomersTabControl.UseVisualStyleBackColor = true;
            // 
            // itemsTabs1
            // 
            this.itemsTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTabs1.Location = new System.Drawing.Point(3, 3);
            this.itemsTabs1.Name = "itemsTabs1";
            this.itemsTabs1.Size = new System.Drawing.Size(820, 509);
            this.itemsTabs1.TabIndex = 0;
            // 
            // customersTabs1
            // 
            this.customersTabs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTabs1.Location = new System.Drawing.Point(0, 0);
            this.customersTabs1.Name = "customersTabs1";
            this.customersTabs1.Size = new System.Drawing.Size(826, 515);
            this.customersTabs1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(850, 580);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ItemsTabControl.ResumeLayout(false);
            this.CustomersTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ItemsTabControl;
        private System.Windows.Forms.TabPage CustomersTabControl;
        private View.Tabs.ItemsTabs itemsTabs1;
        private View.Tabs.CustomersTabs customersTabs1;
    }
}

