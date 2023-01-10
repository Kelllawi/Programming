namespace MovieApp
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
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieGenreComboBox = new System.Windows.Forms.ComboBox();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieDeleteButton = new System.Windows.Forms.Button();
            this.MovieAddButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieGenreComboBox);
            this.MovieGroupBox.Controls.Add(this.MovieDurationLabel);
            this.MovieGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MovieGroupBox.Controls.Add(this.MovieNameLabel);
            this.MovieGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieReleaseYearTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieNameTextBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(281, 48);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(281, 214);
            this.MovieGroupBox.TabIndex = 5;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = " Selected Movie";
            // 
            // MovieGenreComboBox
            // 
            this.MovieGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieGenreComboBox.FormattingEnabled = true;
            this.MovieGenreComboBox.Location = new System.Drawing.Point(84, 68);
            this.MovieGenreComboBox.Name = "MovieGenreComboBox";
            this.MovieGenreComboBox.Size = new System.Drawing.Size(100, 21);
            this.MovieGenreComboBox.TabIndex = 9;
            this.MovieGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.MovieGenreComboBox_SelectedIndexChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(30, 120);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(53, 13);
            this.MovieDurationLabel.TabIndex = 8;
            this.MovieDurationLabel.Text = "Duration :";
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(40, 100);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(44, 13);
            this.MovieRatingLabel.TabIndex = 7;
            this.MovieRatingLabel.Text = "Rating :";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(40, 70);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(42, 13);
            this.GenreLabel.TabIndex = 6;
            this.GenreLabel.Text = "Genre :";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(5, 48);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(77, 13);
            this.ReleaseYearLabel.TabIndex = 5;
            this.ReleaseYearLabel.Text = "Release Year :";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(43, 22);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(41, 13);
            this.MovieNameLabel.TabIndex = 4;
            this.MovieNameLabel.Text = "Name :";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Location = new System.Drawing.Point(84, 122);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieDurationTextBox.TabIndex = 3;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(84, 96);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieRatingTextBox.TabIndex = 2;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(84, 45);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieReleaseYearTextBox.TabIndex = 1;
            this.MovieReleaseYearTextBox.TextChanged += new System.EventHandler(this.MovieReleaseYearTextBox_TextChanged);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(84, 19);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.MovieNameTextBox.TabIndex = 0;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(12, 34);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(248, 329);
            this.MovieListBox.TabIndex = 4;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieDeleteButton
            // 
            this.MovieDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieDeleteButton.Image = global::MovieApp.Properties.Resources.cross_circle_24x24;
            this.MovieDeleteButton.Location = new System.Drawing.Point(93, 381);
            this.MovieDeleteButton.Name = "MovieDeleteButton";
            this.MovieDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.MovieDeleteButton.TabIndex = 7;
            this.MovieDeleteButton.UseVisualStyleBackColor = true;
            this.MovieDeleteButton.Click += new System.EventHandler(this.MovieDeleteButton_Click);
            this.MovieDeleteButton.MouseEnter += new System.EventHandler(this.MovieDeleteButton_MouseEnter);
            this.MovieDeleteButton.MouseLeave += new System.EventHandler(this.MovieDeleteButton_MouseLeave);
            // 
            // MovieAddButton
            // 
            this.MovieAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieAddButton.Image = global::MovieApp.Properties.Resources.add_24x24;
            this.MovieAddButton.Location = new System.Drawing.Point(12, 381);
            this.MovieAddButton.Name = "MovieAddButton";
            this.MovieAddButton.Size = new System.Drawing.Size(75, 23);
            this.MovieAddButton.TabIndex = 6;
            this.MovieAddButton.UseVisualStyleBackColor = true;
            this.MovieAddButton.Click += new System.EventHandler(this.MovieAddButton_Click);
            this.MovieAddButton.MouseEnter += new System.EventHandler(this.MovieAddButton_MouseEnter);
            this.MovieAddButton.MouseLeave += new System.EventHandler(this.MovieAddButton_MouseLeave);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(50, 13);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search  :";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(92, 9);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(130, 20);
            this.SearchTextBox.TabIndex = 9;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MovieGroupBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.MovieDeleteButton);
            this.Controls.Add(this.MovieAddButton);
            this.Name = "MainForm";
            this.Text = "MoviesApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.ComboBox MovieGenreComboBox;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.TextBox MovieReleaseYearTextBox;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Button MovieDeleteButton;
        private System.Windows.Forms.Button MovieAddButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

