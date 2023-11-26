using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace notes.MVVM.Model
{
    internal class NotesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Content { get; set; }

        public NotesModel(int id) 
        {
            Id = id;
            FilePath = Path.Combine(App.NOTES_FOLDER, $"{id}.txt");
            IEnumerable<string> readLiner = File.ReadLines(FilePath);
            Title = readLiner.FirstOrDefault("Title");

            Content = File.ReadAllText(FilePath);
        }
        public NotesModel() 
        {
            int id = new Random().Next(0, 20000);
            string filePath = Path.Combine(App.NOTES_FOLDER, $"{id}.txt");
            while (File.Exists(filePath))
            {
                id = new Random().Next(0, 20000);
                filePath = Path.Combine(App.NOTES_FOLDER, $"{id}.txt");
            }
            Title = "Title";
            Content = "Title";
            Id = id;
            FilePath = filePath;
            File.WriteAllText(filePath, Content);
        }
    }
}
