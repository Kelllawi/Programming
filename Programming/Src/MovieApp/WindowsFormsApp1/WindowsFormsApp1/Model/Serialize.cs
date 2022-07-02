using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Environment;
using Newtonsoft.Json;

namespace MovieApp.Model
{
    public static class Serializer
    {
        static Serializer()
        {
            Path = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}" + "/Markov Kosty/MoviesApp/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }
        public static void Serialize(List<Movie> movies)
        {
            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(movies));
            }
        }
        public static List<Movie> Deserialize()
        {
            var movies = new List<Movie>();
            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    movies = JsonConvert.DeserializeObject<List<Movie>>(reader.ReadToEnd());

                }
                if (movies == null) movies = new List<Movie>();

            }
            catch
            {
                return movies;
            }
            return movies;
        }

        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}
