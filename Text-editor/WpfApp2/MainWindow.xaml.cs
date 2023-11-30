using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfTextEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt|Word Document|*.doc";
            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath);
                if (fileExtension == ".txt")
                {
                    File.WriteAllText(filePath, textInputTextBox.Text);
                }
                else if (fileExtension == ".doc")
                {
                    File.WriteAllText(filePath, textInputTextBox.Text);
                }
                MessageBox.Show("File saved to " + filePath);
            }
        }
    }
}