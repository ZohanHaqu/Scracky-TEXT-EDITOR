using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;

namespace Pisces
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // InitializeComponent(); // Removed
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            // Editor.Document.Blocks.Clear(); // Removed
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|Scracky Text Files (*.scky)|*.scky|DLL Files (*.dll)|*.dll|Batch Files (*.bat)|*.bat|Command Files (*.cmd)|*.cmd|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                // Editor.Document.Blocks.Clear(); // Removed
                // Editor.Document.Blocks.Add(new Paragraph(new Run(fileContent))); // Removed
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                // string fileContent = new TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd).Text; // Removed
                // File.WriteAllText(saveFileDialog.FileName, fileContent); // Removed
            }
        }

        private void ViewFile_Click(object sender, RoutedEventArgs e)
        {
            // Implementation for View File
        }

        private void CombineFiles_Click(object sender, RoutedEventArgs e)
        {
            // Implementation for Combine Files
        }

        private void OpenSystemCode_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "DLL Files (*.dll)|*.dll|Command Files (*.cmd)|*.cmd|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                // Editor.Document.Blocks.Clear(); // Removed
                // Editor.Document.Blocks.Add(new Paragraph(new Run(fileContent))); // Removed
            }
        }
    }
}

