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
            this.enumerationsControl1 = new Programming.View.Control.EnumerationsControl();
            this.seasonGroupBox = new System.Windows.Forms.GroupBox();
            this.season_HandleConrol1 = new Programming.View.Control.Season_HandleConrol();
            this.weekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.filmGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Control.MoviesControl();
            this.rectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangsControll1 = new Programming.View.Control.RectangsControll();
            this.Reactagles = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl1 = new Programming.View.Control.RectangleCollisionControl();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl.SuspendLayout();
            this.EnumerationTabPage.SuspendLayout();
            this.enumerationsGroupBox.SuspendLayout();
            this.seasonGroupBox.SuspendLayout();
            this.weekdayGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.filmGroupBox.SuspendLayout();
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
            this.enumerationsGroupBox.Controls.Add(this.enumerationsControl1);
            this.enumerationsGroupBox.Location = new System.Drawing.Point(3, 5);
            this.enumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enumerationsGroupBox.Name = "enumerationsGroupBox";
            this.enumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.enumerationsGroupBox.Size = new System.Drawing.Size(622, 252);
            this.enumerationsGroupBox.TabIndex = 9;
            this.enumerationsGroupBox.TabStop = false;
            this.enumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(2, 15);
            this.enumerationsControl1.Margin = new System.Windows.Forms.Padding(2);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(618, 235);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // seasonGroupBox
            // 
            this.seasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonGroupBox.Controls.Add(this.season_HandleConrol1);
            this.seasonGroupBox.Location = new System.Drawing.Point(317, 261);
            this.seasonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.seasonGroupBox.Name = "seasonGroupBox";
            this.seasonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.seasonGroupBox.Size = new System.Drawing.Size(301, 132);
            this.seasonGroupBox.TabIndex = 8;
            this.seasonGroupBox.TabStop = false;
            this.seasonGroupBox.Text = "Season Handle";
            // 
            // season_HandleConrol1
            // 
            this.season_HandleConrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.season_HandleConrol1.Location = new System.Drawing.Point(2, 15);
            this.season_HandleConrol1.Name = "season_HandleConrol1";
            this.season_HandleConrol1.Size = new System.Drawing.Size(297, 115);
            this.season_HandleConrol1.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            this.weekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.weekdayGroupBox.Location = new System.Drawing.Point(7, 261);
            this.weekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayGroupBox.Name = "weekdayGroupBox";
            this.weekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.weekdayGroupBox.Size = new System.Drawing.Size(306, 132);
            this.weekdayGroupBox.TabIndex = 7;
            this.weekdayGroupBox.TabStop = false;
            this.weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(2, 15);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(302, 115);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.filmGroupBox);
            this.ClassesTabPage.Controls.Add(this.rectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(625, 400);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // filmGroupBox
            // 
            this.filmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filmGroupBox.Controls.Add(this.moviesControl1);
            this.filmGroupBox.Location = new System.Drawing.Point(304, 6);
            this.filmGroupBox.Name = "filmGroupBox";
            this.filmGroupBox.Size = new System.Drawing.Size(313, 386);
            this.filmGroupBox.TabIndex = 2;
            this.filmGroupBox.TabStop = false;
            this.filmGroupBox.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(3, 16);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(307, 367);
            this.moviesControl1.TabIndex = 0;
            // 
            // rectangleGroupBox
            // 
            this.rectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleGroupBox.Controls.Add(this.rectangsControll1);
            this.rectangleGroupBox.Location = new System.Drawing.Point(7, 5);
            this.rectangleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleGroupBox.Name = "rectangleGroupBox";
            this.rectangleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rectangleGroupBox.Size = new System.Drawing.Size(292, 388);
            this.rectangleGroupBox.TabIndex = 1;
            this.rectangleGroupBox.TabStop = false;
            this.rectangleGroupBox.Text = "Rectangles";
            // 
            // rectangsControll1
            // 
            this.rectangsControll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangsControll1.Location = new System.Drawing.Point(2, 15);
            this.rectangsControll1.Name = "rectangsControll1";
            this.rectangsControll1.Size = new System.Drawing.Size(288, 371);
            this.rectangsControll1.TabIndex = 0;
            // 
            // Reactagles
            // 
            this.Reactagles.Controls.Add(this.rectangleCollisionControl1);
            this.Reactagles.Location = new System.Drawing.Point(4, 22);
            this.Reactagles.Name = "Reactagles";
            this.Reactagles.Padding = new System.Windows.Forms.Padding(3);
            this.Reactagles.Size = new System.Drawing.Size(625, 400);
            this.Reactagles.TabIndex = 3;
            this.Reactagles.Text = "Rectangles";
            this.Reactagles.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(619, 394);
            this.rectangleCollisionControl1.TabIndex = 0;
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
            this.filmGroupBox.ResumeLayout(false);
            this.rectangleGroupBox.ResumeLayout(false);
            this.Reactagles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage Reactagles;
        private Control.RectangleCollisionControl rectangleCollisionControl1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage EnumerationTabPage;
        private System.Windows.Forms.GroupBox enumerationsGroupBox;
        private System.Windows.Forms.GroupBox seasonGroupBox;
        private System.Windows.Forms.GroupBox weekdayGroupBox;
        private Control.EnumerationsControl enumerationsControl1;
        private Control.Season_HandleConrol season_HandleConrol1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private System.Windows.Forms.GroupBox filmGroupBox;
        private Control.MoviesControl moviesControl1;
        private System.Windows.Forms.GroupBox rectangleGroupBox;
        private Control.RectangsControll rectangsControll1;
    }
}

