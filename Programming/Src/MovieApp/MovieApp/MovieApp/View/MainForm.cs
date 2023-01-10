
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieApp.Model;
using MovieApp.Model.Enums;

namespace MovieApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция фильмов.
        /// </summary>
        private List<Movie> _movies = new List<Movie>();

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        private string _searchText;

        public MainForm()
        {
            InitializeComponent();
            var Items = Enum.GetValues(typeof(Genre));
            foreach (var item in Items)
            {
                MovieGenreComboBox.Items.Add(item);
            }



        }
        private List<Movie> SearchMovies()
        {
            var result = from movie in _movies
                         where movie.Name.Contains(_searchText) ||
                         movie.ReleaseYear.ToString().Contains(_searchText) ||
                         movie.Rating.ToString().Contains(_searchText) ||
                         movie.DurationTimeInMinutes.ToString().Contains(_searchText) ||
                         movie.Genre.Contains(_searchText)
                         select movie;

            return result.ToList();
        }
        private void UpdateInfo(int index)
        {
            List<Movie> movies;

            MovieListBox.Items.Clear();

            if (_searchText != "" && _searchText != null) movies = SearchMovies();
            else movies = _movies;

            foreach (var movie in movies)
            {
                if (movie.Name != null)
                {
                    MovieListBox.Items.Add(
                        $"{movie.Name} - {movie.ReleaseYear} - {movie.Genre}");
                }
                else
                {
                    MovieListBox.Items.Add($"Movie {movie.Id}");
                }
            }

            if (-1 <= index && index < MovieListBox.Items.Count)
                MovieListBox.SelectedIndex = index;
        }
        private void ClearInfo()
        {
            MovieListBox.SelectedIndex = -1;
            MovieNameTextBox.Clear();
            MovieGenreComboBox.SelectedIndex = -1;
            MovieRatingTextBox.Clear();
            MovieReleaseYearTextBox.Clear();
            MovieDurationTextBox.Clear();
        }
        private string GetMovieInfo(Movie movie)
        {
            return $"{movie.Name} | {movie.ReleaseYear} | {movie.Genre}";
        }


        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;


            if (_searchText == "" || _searchText == null)
                _currentMovie = _movies[MovieListBox.SelectedIndex];
            else
                _currentMovie = SearchMovies()[MovieListBox.SelectedIndex];

            MovieNameTextBox.Text = _currentMovie.Name;
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieDurationTextBox.Text = _currentMovie.DurationTimeInMinutes.ToString();
            MovieGenreComboBox.Text = _currentMovie.Genre;



        }

        private void SortingMovies()
        {
            _movies = (from Movie in _movies
                       orderby Movie.Name
                       select Movie).ToList();
        }

        private void MovieAddButton_Click(object sender, EventArgs e)
        {
            var movie = new Movie();
            _movies.Add(movie);
            SortingMovies();
            UpdateInfo(_movies.IndexOf(_currentMovie));


        }

        private void MovieDeleteButton_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;

            _movies.RemoveAt(MovieListBox.SelectedIndex);

            if (_movies.Count == 0)
            {
                UpdateInfo(-1);
                ClearInfo();
            }
            else
            {
                UpdateInfo(0);
            }
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;
            try
            {
                _currentMovie.Name = MovieNameTextBox.Text;
                MovieNameTextBox.BackColor = Color.FromArgb(255, 255, 255);
                SortingMovies();
                UpdateInfo(_movies.IndexOf(_currentMovie));

            }
            catch
            {
                MovieNameTextBox.BackColor = Color.Red;
            }
        }

        private void MovieReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.ReleaseYear = int.Parse(MovieReleaseYearTextBox.Text);
                MovieReleaseYearTextBox.BackColor = Color.FromArgb(255, 255, 255);
                UpdateInfo(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = Color.Red;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.Rating = int.Parse(MovieRatingTextBox.Text);
                MovieRatingTextBox.BackColor = Color.FromArgb(255, 255, 255);

                UpdateInfo(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieRatingTextBox.BackColor = Color.Red;
            }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;
            try
            {
                _currentMovie.DurationTimeInMinutes = int.Parse(MovieDurationTextBox.Text);
                MovieDurationTextBox.BackColor = Color.FromArgb(255, 255, 255);
                UpdateInfo(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieDurationTextBox.BackColor = Color.Red;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_movies);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _movies.AddRange(Serializer.Deserialize());
            for (int i = 0; i < _movies.Count; i++)
            {
                MovieListBox.Items.Add(GetMovieInfo(_movies[i]));
            }
        }

        private void MovieGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.Genre = MovieGenreComboBox.SelectedItem.ToString();
                SortingMovies();
                UpdateInfo(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor =Color.Red;
            }
        }

        private void MovieAddButton_MouseEnter(object sender, EventArgs e)
        {
            MovieAddButton.Image = MovieApp.Properties.Resources.add_24x24_black;
        }

        private void MovieAddButton_MouseLeave(object sender, EventArgs e)
        {
            MovieAddButton.Image = MovieApp.Properties.Resources.add_24x24;
        }

        private void MovieDeleteButton_MouseEnter(object sender, EventArgs e)
        {
            MovieDeleteButton.Image = MovieApp.Properties.Resources.cross_circle_24x24_black;
        }

        private void MovieDeleteButton_MouseLeave(object sender, EventArgs e)
        {
            MovieDeleteButton.Image = MovieApp.Properties.Resources.cross_circle_24x24;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _searchText = SearchTextBox.Text;
            ClearInfo();
            UpdateInfo(-1);
        }
    }
}
