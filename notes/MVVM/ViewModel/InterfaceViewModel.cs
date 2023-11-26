using notes.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows;
using System.IO;
using System.Threading;
using System.Windows.Controls;
using notes.Core;

namespace notes.MVVM.ViewModel
{
    internal class InterfaceViewModel : INotifyPropertyChanged
    {
        public static InterfaceViewModel Instance { get; } = new InterfaceViewModel();

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
                SaveNote(SelectedItem);
            }
        }

        private void SaveNote(NotesModel note)
        {
            if (note != null)
            {
                File.WriteAllText(note.FilePath, Text);
                note.Content = Text;
            }
        }

        private ObservableCollection<NotesModel> _notes;
        private NotesModel _selectedNotes;
        public ObservableCollection<NotesModel> Notes
        {
            get
            {
                if (_notes == null)
                {
                    _notes = new();
                }
                return _notes;
            }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    OnPropertyChanged(nameof(Notes));
                }
            }
        }
        public NotesModel SelectedItem
        {
            get { return _selectedNotes; }
            set
            {
                if (_selectedNotes != value)
                {
                    _selectedNotes = value;
                    OnPropertyChanged(nameof(SelectedItem));
                    OnItemSelected();
                }
            }
        }
        public InterfaceViewModel()
        {
            RefreshNotes();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnItemSelected()
        {
            try
            {
                if (SelectedItem != null)
                {
                    Text = SelectedItem.Content;
                }
                else
                {
                    Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке текста: {ex.Message}");
            }
            
        }

        public void RefreshNotes()
        {
            DirectoryInfo notesFolderInfo = new DirectoryInfo(App.NOTES_FOLDER);
            FileInfo[] notes = notesFolderInfo.GetFiles("*.txt");
            Notes.Clear();

            foreach (FileInfo note in notes)
            {
                string NotePath = Path.Combine(App.NOTES_FOLDER, note.Name);
                int noteId = int.Parse(Path.GetFileNameWithoutExtension(NotePath));

                NotesModel noteModel = new NotesModel(noteId);

                Notes.Add(noteModel);
            }
        }

        public void DeleteNote()
        {
            if (SelectedItem != null)
            {
                File.Delete(SelectedItem.FilePath);
                RefreshNotes();
            }
            else
                return;
        }
    }
}
