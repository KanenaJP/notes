﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace notes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string NOTES_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "NoteStorage");
    }
}
