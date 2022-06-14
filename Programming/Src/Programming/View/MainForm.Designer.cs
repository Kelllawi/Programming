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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumerationTabPage = new System.Windows.Forms.TabPage();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.season_HandleConrol1 = new Programming.View.Control.Season_HandleConrol();
            this.enumerationsControl1 = new Programming.View.Control.EnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreMovieLabel = new System.Windows.Forms.Label();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.NameMovieLabel = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingMovieLabel = new System.Windows.Forms.Label();
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.DurationMinutesMovieLabel = new System.Windows.Forms.Label();
            this.YearReleaseMovieTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseMovieLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.Reactagles = new System.Windows.Forms.TabPage();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.HeightRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Rectagleslabel = new System.Windows.Forms.Label();
            this.AddingRectaglesListBox = new System.Windows.Forms.ListBox();
            this.CanvaPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangsControll1 = new Programming.View.Control.RectangsControll();
            this.MainTabControl.SuspendLayout();
            this.EnumerationTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.Reactagles.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(734, 401);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumerationTabPage
            // 
            this.EnumerationTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumerationTabPage.Controls.Add(this.season_HandleConrol1);
            this.EnumerationTabPage.Controls.Add(this.enumerationsControl1);
            this.EnumerationTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationTabPage.Name = "EnumerationTabPage";
            this.EnumerationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationTabPage.Size = new System.Drawing.Size(726, 375);
            this.EnumerationTabPage.TabIndex = 1;
            this.EnumerationTabPage.Text = "Enums";
            this.EnumerationTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(5, 261);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(321, 106);
            this.weekdayParsingControl1.TabIndex = 2;
            // 
            // season_HandleConrol1
            // 
            this.season_HandleConrol1.Location = new System.Drawing.Point(377, 261);
            this.season_HandleConrol1.Name = "season_HandleConrol1";
            this.season_HandleConrol1.Size = new System.Drawing.Size(343, 106);
            this.season_HandleConrol1.TabIndex = 1;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 3);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(720, 369);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(726, 375);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.GenreMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.NameMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.NameMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.FindMovieButton);
            this.MoviesGroupBox.Controls.Add(this.RatingMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.RatingMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationMinutesMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationMinutesMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.YearReleaseMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearReleaseMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoviesGroupBox.Location = new System.Drawing.Point(366, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(145, 75);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreMovieTextBox.TabIndex = 19;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // GenreMovieLabel
            // 
            this.GenreMovieLabel.AutoSize = true;
            this.GenreMovieLabel.Location = new System.Drawing.Point(142, 59);
            this.GenreMovieLabel.Name = "GenreMovieLabel";
            this.GenreMovieLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreMovieLabel.TabIndex = 18;
            this.GenreMovieLabel.Text = "Genre:";
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.Location = new System.Drawing.Point(145, 36);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameMovieTextBox.TabIndex = 17;
            this.NameMovieTextBox.TextChanged += new System.EventHandler(this.NameMovieTextBox_TextChanged);
            // 
            // NameMovieLabel
            // 
            this.NameMovieLabel.AutoSize = true;
            this.NameMovieLabel.Location = new System.Drawing.Point(142, 20);
            this.NameMovieLabel.Name = "NameMovieLabel";
            this.NameMovieLabel.Size = new System.Drawing.Size(38, 13);
            this.NameMovieLabel.TabIndex = 16;
            this.NameMovieLabel.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(145, 286);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(103, 23);
            this.FindMovieButton.TabIndex = 15;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(145, 192);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingMovieTextBox.TabIndex = 14;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // RatingMovieLabel
            // 
            this.RatingMovieLabel.AutoSize = true;
            this.RatingMovieLabel.Location = new System.Drawing.Point(142, 176);
            this.RatingMovieLabel.Name = "RatingMovieLabel";
            this.RatingMovieLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingMovieLabel.TabIndex = 13;
            this.RatingMovieLabel.Text = "Rating:";
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(145, 153);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 12;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // DurationMinutesMovieLabel
            // 
            this.DurationMinutesMovieLabel.AutoSize = true;
            this.DurationMinutesMovieLabel.Location = new System.Drawing.Point(142, 137);
            this.DurationMinutesMovieLabel.Name = "DurationMinutesMovieLabel";
            this.DurationMinutesMovieLabel.Size = new System.Drawing.Size(100, 13);
            this.DurationMinutesMovieLabel.TabIndex = 11;
            this.DurationMinutesMovieLabel.Text = "Duration in minutes:";
            // 
            // YearReleaseMovieTextBox
            // 
            this.YearReleaseMovieTextBox.Location = new System.Drawing.Point(145, 114);
            this.YearReleaseMovieTextBox.Name = "YearReleaseMovieTextBox";
            this.YearReleaseMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearReleaseMovieTextBox.TabIndex = 10;
            this.YearReleaseMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseMovieTextBox_TextChanged);
            // 
            // YearReleaseMovieLabel
            // 
            this.YearReleaseMovieLabel.AutoSize = true;
            this.YearReleaseMovieLabel.Location = new System.Drawing.Point(142, 98);
            this.YearReleaseMovieLabel.Name = "YearReleaseMovieLabel";
            this.YearReleaseMovieLabel.Size = new System.Drawing.Size(81, 13);
            this.YearReleaseMovieLabel.TabIndex = 9;
            this.YearReleaseMovieLabel.Text = "Year of release:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(6, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(133, 290);
            this.MovieListBox.TabIndex = 8;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // Reactagles
            // 
            this.Reactagles.Controls.Add(this.RemoveRectangleButton);
            this.Reactagles.Controls.Add(this.AddRectangleButton);
            this.Reactagles.Controls.Add(this.HeightRectangleTextBox);
            this.Reactagles.Controls.Add(this.label13);
            this.Reactagles.Controls.Add(this.textBox1);
            this.Reactagles.Controls.Add(this.label14);
            this.Reactagles.Controls.Add(this.textBox2);
            this.Reactagles.Controls.Add(this.label12);
            this.Reactagles.Controls.Add(this.textBox3);
            this.Reactagles.Controls.Add(this.label11);
            this.Reactagles.Controls.Add(this.textBox4);
            this.Reactagles.Controls.Add(this.label10);
            this.Reactagles.Controls.Add(this.label9);
            this.Reactagles.Controls.Add(this.Rectagleslabel);
            this.Reactagles.Controls.Add(this.AddingRectaglesListBox);
            this.Reactagles.Controls.Add(this.CanvaPanel);
            this.Reactagles.Controls.Add(this.menuStrip1);
            this.Reactagles.Location = new System.Drawing.Point(4, 22);
            this.Reactagles.Name = "Reactagles";
            this.Reactagles.Padding = new System.Windows.Forms.Padding(3);
            this.Reactagles.Size = new System.Drawing.Size(726, 375);
            this.Reactagles.TabIndex = 3;
            this.Reactagles.Text = "Rectangles";
            this.Reactagles.UseVisualStyleBackColor = true;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.ForeColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(171, 145);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(45, 32);
            this.RemoveRectangleButton.TabIndex = 27;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            this.RemoveRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveRectangleButton_MouseMove);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.Color.White;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(28, 145);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(45, 32);
            this.AddRectangleButton.TabIndex = 26;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            this.AddRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddRectangleButton_MouseMove);
            // 
            // HeightRectangleTextBox
            // 
            this.HeightRectangleTextBox.Location = new System.Drawing.Point(63, 320);
            this.HeightRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightRectangleTextBox.Name = "HeightRectangleTextBox";
            this.HeightRectangleTextBox.Size = new System.Drawing.Size(87, 20);
            this.HeightRectangleTextBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 320);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Height:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 297);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 297);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Width:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 275);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 275);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Y:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 252);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(87, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "X:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(63, 229);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(87, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Selected Rectangle:";
            // 
            // Rectagleslabel
            // 
            this.Rectagleslabel.AutoSize = true;
            this.Rectagleslabel.Location = new System.Drawing.Point(8, 2);
            this.Rectagleslabel.Name = "Rectagleslabel";
            this.Rectagleslabel.Size = new System.Drawing.Size(58, 13);
            this.Rectagleslabel.TabIndex = 2;
            this.Rectagleslabel.Text = "Rectagles:";
            // 
            // AddingRectaglesListBox
            // 
            this.AddingRectaglesListBox.FormattingEnabled = true;
            this.AddingRectaglesListBox.Location = new System.Drawing.Point(8, 18);
            this.AddingRectaglesListBox.Name = "AddingRectaglesListBox";
            this.AddingRectaglesListBox.Size = new System.Drawing.Size(265, 121);
            this.AddingRectaglesListBox.TabIndex = 1;
            // 
            // CanvaPanel
            // 
            this.CanvaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvaPanel.Location = new System.Drawing.Point(279, 3);
            this.CanvaPanel.Name = "CanvaPanel";
            this.CanvaPanel.Size = new System.Drawing.Size(444, 376);
            this.CanvaPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectangsControll1);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            this.RectanglesGroupBox.Enter += new System.EventHandler(this.RectanglesGroupBox_Enter);
            // 
            // rectangsControll1
            // 
            this.rectangsControll1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rectangsControll1.Location = new System.Drawing.Point(3, 16);
            this.rectangsControll1.Name = "rectangsControll1";
            this.rectangsControll1.Size = new System.Drawing.Size(256, 350);
            this.rectangsControll1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.EnumerationTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.Reactagles.ResumeLayout(false);
            this.Reactagles.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EnumerationTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.TextBox RatingMovieTextBox;
        private System.Windows.Forms.Label RatingMovieLabel;
        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;
        private System.Windows.Forms.Label DurationMinutesMovieLabel;
        private System.Windows.Forms.TextBox YearReleaseMovieTextBox;
        private System.Windows.Forms.Label YearReleaseMovieLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.TextBox NameMovieTextBox;
        private System.Windows.Forms.Label NameMovieLabel;
        private System.Windows.Forms.TextBox GenreMovieTextBox;
        private System.Windows.Forms.Label GenreMovieLabel;
        private System.Windows.Forms.TabPage Reactagles;
        private System.Windows.Forms.Panel CanvaPanel;
        private System.Windows.Forms.Label Rectagleslabel;
        private System.Windows.Forms.ListBox AddingRectaglesListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.TextBox HeightRectangleTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private Control.Season_HandleConrol season_HandleConrol1;
        private Control.EnumerationsControl enumerationsControl1;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private Control.RectangsControll rectangsControll1;
    }
}

