using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Win10_WP字幕解析软件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathname, filename;
        string folder;
        List<string> new_lines = new List<string>();
        List<string> lines = new List<string>();
        List<string> transfered_lines = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Save.IsEnabled = false;
        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            int count;
            if (Open_file() == false)
            { MessageBox.Show("文件打开失败"); return; }

            using (StreamReader reader = new StreamReader(pathname))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                { lines.Add(line); }
            }
            if (lines.Count == 0) { return; }
            else {count = lines.Count(); }
            for(int i= 0; i<count;i++){
                if (LetterIsExists(lines[i]))
                { new_lines.Add(lines[i]); }}
                Handle_Words(lines,new_lines.Count());
                Display_Box.Text = "";
            for (int i =0; i<transfered_lines.Count();i++)
            {Display_Box.Text += transfered_lines[i] + "\n\n";}
            Save.IsEnabled = true;
        }

        private void Handle_Words(List<String> lines,int length){
            string sentence = "";
            transfered_lines.Add(new_lines[0]);
            for (int i = 1; i < length; i++){
                sentence += new_lines[i];
                if (new_lines[i].Contains('.')) {
                  var dot_position = new_lines[i].LastIndexOf(".");
                    if (new_lines[i].Count() == dot_position + 1 || new_lines[i][dot_position + 1] == ' ')
                    {
                        transfered_lines.Add(sentence);
                        sentence = "";
                    }
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult path_success = dialog.ShowDialog();
            var selectedpath = dialog.SelectedPath;

            //textbox中\n是一个回车，但是在txt文件中\r\n才是一个回车，所以保存前先进行一下转换
            string s = Display_Box.Text;
            s = s.Replace("\n", "\r\n");

            try
            {
                using (StreamWriter sw = new StreamWriter(selectedpath + "\\已修正文件.txt"))
                {
                    sw.Write(s);
                }
            }
            catch { MessageBox.Show("文件无法保存至此位置啦"); }

            lines.Clear();
            new_lines.Clear();
            transfered_lines.Clear();
        }

        private void Font_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(slider.Value>90)
            {Display_Box.FontSize = 30;}
            else if (slider.Value > 80) { Display_Box.FontSize = 28; }
            else if (slider.Value > 70) { Display_Box.FontSize = 26; }
            else if (slider.Value > 60) { Display_Box.FontSize = 24; }
            else if (slider.Value > 50) { Display_Box.FontSize = 22; }
            else if (slider.Value > 40) { Display_Box.FontSize = 20; }
            else if (slider.Value > 30) { Display_Box.FontSize = 18; }
            else if (slider.Value > 20) { Display_Box.FontSize = 16; }
            else if (slider.Value > 10) { Display_Box.FontSize = 14; }
        }

        public bool LetterIsExists(string str) { return Regex.IsMatch(str, "[A-z]"); }

        public bool Open_file()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".srt";
            dlg.Filter = "srt files (*.srt)|*.srt|ass files (*.ass)|*.ass";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                pathname = dlg.FileName;
                //get the folder name
                folder = pathname.Split('\\')[pathname.Split('\\').Count() - 2];
                filename = dlg.SafeFileName;
                return true;
            }
            else { return false; }
        }


    }
}
