using notes.Core;
using notes.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace notes.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject 
    {
        public RelayCommand MoveWindowCommand {  get; set; }
        public RelayCommand ShutdownCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand OpenNoteCommand { get; set; }
        public RelayCommand AddNewNoteCommand {  get; set; }
        public RelayCommand DeleteNoteCommand { get; set; }
        public InterfaceViewModel Interface { get; } = InterfaceViewModel.Instance;


        private object _currentView;
        public object CurrentView
        { 
            get { return _currentView; } 
            set {  _currentView = value; OnProprtyChanged(); }   
        }

        public MainViewModel()
        {
            if (!Directory.Exists(App.NOTES_FOLDER))
            {
                Directory.CreateDirectory(App.NOTES_FOLDER);
            }

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutdownCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizeWindowCommand = new RelayCommand(o => 
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                else
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;    
            });
            MinimizeWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized; });
            AddNewNoteCommand = new RelayCommand(o => { NotesModel notesModel = new NotesModel(); Interface.RefreshNotes(); });
            DeleteNoteCommand = new RelayCommand(o => { Interface.DeleteNote(); });
        }

    }
}
