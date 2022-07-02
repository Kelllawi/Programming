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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumerationTabPage = new System.Windows.Forms.TabPage();
            this.enumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsControl = new Programming.View.Control.EnumerationsControl();
            this.seasonGroupBox = new System.Windows.Forms.GroupBox();
            this.Season_HandleConrol = new Programming.View.Control.Season_HandleConrol();
            this.weekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.FilmGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesControl = new Programming.View.Control.MoviesControl();
            this.rectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesControll = new Programming.View.Control.RectanglesControll();
            this.Reactagles = new System.Windows.Forms.TabPage();
            this.RectangleCollisionControl = new Programming.View.Control.RectangleCollisionControl();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl.SuspendLayout();
            this.EnumerationTabPage.SuspendLayout();
            this.enumerationsGroupBox.SuspendLayout();
            this.seasonGroupBox.SuspendLayout();
            this.weekdayGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.rectangleGroupBox.SuspendLayout();
            this.Reactagles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumerationTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.Reactagles);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(633, 426);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumerationTabPage
            // 
            this.EnumerationTabPage.Controls.Add(this.enumerationsGroupBox);
            this.EnumerationTabPage.Controls.Add(this.seasonGroupBox);
            this.EnumerationTabPage.Controls.Add(this.weekdayGroupBox);
            this.EnumerationTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationTabPage.Name = "EnumerationTabPage";
            this.EnumerationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationTabPage.Size = new System.Drawing.Size(625, 400);
            this.EnumerationTabPage.TabIndex = 1;
            this.EnumerationTabPage.Text = "Enums";
            this.EnumerationTabPage.UseVisualStyleBackColor = true;
            // 
            // enumerationsGroupBox
            // 
            this.enumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationsGroupBox.Controls.Add(this.EnumerationsControl);
            this.enumerationsGroupBox.Location = new System.Drawing.Point(3, 5);
            this.enumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enumerationsGroupBox.Name = "enumerationsGroupBox";
            this.enumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enumerationsGroupBox.Size = new System.Drawing.Size(622, 252);
            this.enumerationsGroupBox.TabIndex = 9;
            this.enumerationsGroupBox.TabStop = false;
            this.enumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsControl.Location = new System.Drawing.Point(2, 15);
            this.EnumerationsControl.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(618, 235);
            this.EnumerationsControl.TabIndex = 0;
            // 
            // seasonGroupBox
            // 
            this.seasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonGroupBox.Controls.Add(this.Season_HandleConrol);
            this.seasonGroupBox.Location = new System.Drawing.Point(317, 261);
            this.seasonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.seasonGroupBox.Name = "seasonGroupBox";
            this.seasonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.seasonGroupBox.Size = new System.Drawing.Size(301, 132);
            this.seasonGroupBox.TabIndex = 8;
            this.seasonGroupBox.TabStop = false;
            this.seasonGroupBox.Text = "Season Handle";
            // 
            // Season_HandleConrol
            // 
            this.Season_HandleConrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Season_HandleConrol.Location = new System.Drawing.Point(2, 15);
            this.Season_HandleConrol.Name = "Season_HandleConrol";
            this.Season_HandleConrol.Size = new System.Drawing.Size(297, 115);
            this.Season_HandleConrol.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            this.weekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weekdayGroupBox.Controls.Add(this.WeekdayParsingControl);
            this.weekdayGroupBox.Location = new System.Drawing.Point(7, 261);
            this.weekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayGroupBox.Name = "weekdayGroupBox";
            this.weekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.weekdayGroupBox.Size = new System.Drawing.Size(306, 132);
            this.weekdayGroupBox.TabIndex = 7;
            this.weekdayGroupBox.TabStop = false;
            this.weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingControl.Location = new System.Drawing.Point(2, 15);
            this.WeekdayParsingControl.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(302, 115);
            this.WeekdayParsingControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.FilmGroupBox);
            this.ClassesTabPage.Controls.Add(this.rectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(625, 400);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilmGroupBox.Controls.Add(this.MoviesControl);
            this.FilmGroupBox.Location = new System.Drawing.Point(304, 6);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Size = new System.Drawing.Size(313, 386);
            this.FilmGroupBox.TabIndex = 2;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Movies";
            // 
            // MoviesControl
            // 
            this.MoviesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesControl.Location = new System.Drawing.Point(3, 16);
            this.MoviesControl.Name = "MoviesControl";
            this.MoviesControl.Size = new System.Drawing.Size(307, 367);
            this.MoviesControl.TabIndex = 0;
            // 
            // rectangleGroupBox
            // 
            this.rectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleGroupBox.Controls.Add(this.RectanglesControll);
            this.rectangleGroupBox.Location = new System.Drawing.Point(7, 5);
            this.rectangleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleGroupBox.Name = "rectangleGroupBox";
            this.rectangleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rectangleGroupBox.Size = new System.Drawing.Size(292, 388);
            this.rectangleGroupBox.TabIndex = 1;
            this.rectangleGroupBox.TabStop = false;
            this.rectangleGroupBox.Text = "Rectangles";
            // 
            // RectanglesControll
            // 
            this.RectanglesControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesControll.Location = new System.Drawing.Point(2, 15);
            this.RectanglesControll.Name = "RectanglesControll";
            this.RectanglesControll.Size = new System.Drawing.Size(288, 371);
            this.RectanglesControll.TabIndex = 0;
            // 
            // Reactagles
            // 
            this.Reactagles.Controls.Add(this.RectangleCollisionControl);
            this.Reactagles.Location = new System.Drawing.Point(4, 22);
            this.Reactagles.Name = "Reactagles";
            this.Reactagles.Padding = new System.Windows.Forms.Padding(3);
            this.Reactagles.Size = new System.Drawing.Size(625, 400);
            this.Reactagles.TabIndex = 3;
            this.Reactagles.Text = "Rectangles";
            this.Reactagles.UseVisualStyleBackColor = true;
            // 
            // RectangleCollisionControl
            // 
            this.RectangleCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectangleCollisionControl.Location = new System.Drawing.Point(3, 3);
            this.RectangleCollisionControl.Name = "RectangleCollisionControl";
            this.RectangleCollisionControl.Size = new System.Drawing.Size(619, 394);
            this.RectangleCollisionControl.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 426);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(620, 450);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.MainTabControl.ResumeLayout(false);
            this.EnumerationTabPage.ResumeLayout(false);
            this.enumerationsGroupBox.ResumeLayout(false);
            this.seasonGroupBox.ResumeLayout(false);
            this.weekdayGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.rectangleGroupBox.ResumeLayout(false);
            this.Reactagles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage Reactagles;
        private Control.RectangleCollisionControl RectangleCollisionControl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage EnumerationTabPage;
        private System.Windows.Forms.GroupBox enumerationsGroupBox;
        private System.Windows.Forms.GroupBox seasonGroupBox;
        private System.Windows.Forms.GroupBox weekdayGroupBox;
        private Control.EnumerationsControl EnumerationsControl;
        private Control.Season_HandleConrol Season_HandleConrol;
        private Controls.WeekdayParsingControl WeekdayParsingControl;
        private System.Windows.Forms.GroupBox FilmGroupBox;
        private Control.MoviesControl MoviesControl;
        private System.Windows.Forms.GroupBox rectangleGroupBox;
        private Control.RectanglesControll RectanglesControll;
    }
}

