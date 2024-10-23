using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using Renci.SshNet;
using System;
using System.Diagnostics;
using System.IO;

namespace BackupUploadApplication.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object source, RoutedEventArgs args)
        {
            //if (Double.TryParse(kanina.Text, out double k))
            //{
            //    var p = k * 100;
            //    pandatina.Text = p.ToString("0.0");
            //}
            //else
            //{
            //    kanina.Text = "0";
            //    pandatina.Text = "0";
            //}
        }

        public void TextBox_PropertyChanged(object? sender, Avalonia.AvaloniaPropertyChangedEventArgs e)
        {
            //if (kanina is null) return;
            //if (Double.TryParse(kanina.Text, out double k))
            //{
            //    var p = k * 100;
            //    pandatina.Text = p.ToString("0.0");
            //}
            //else
            //{
            //    kanina.Text = "0";
            //    pandatina.Text = "0";
            //}
        }

        private async void OpenFileButton_Clicked(object sender, RoutedEventArgs args)
        {

            var host = "";
            var port = 265;
            var username = "";
            var password = "";

            var client = new SftpClient(host, port, username, password);
            client.Connect();


            try
            { 

                var dirs = client.ListDirectory("/");

                foreach (var dir in dirs)
                {
                    Debug.WriteLine(dir.FullName);
                }
            }
            catch (Exception ex)
            {
                var a = ex.Message;
                Console.WriteLine(a);
            }


            client.Disconnect();

            //// Get top level from the current control. Alternatively, you can use Window reference instead.
            //var topLevel = TopLevel.GetTopLevel(this);

            //// Start async operation to open the dialog.
            //var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            //{
            //    Title = "Open Text File",
            //    AllowMultiple = false
            //});
        }

    }
}