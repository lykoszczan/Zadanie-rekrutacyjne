using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Zadanie_rekrutacyjne
{
    public partial class MainWindow : Window
    {
        private BitmapSource bitmapSource;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = System.Environment.CurrentDirectory,
                Filter = "Text files (*.txt)|*.txt"
            };
            Nullable<bool> result = openFile.ShowDialog();

            if (result == true)
            {
                Drawer graphic = new Drawer(openFile.FileName);
                bitmapSource = graphic.bitmap;
                Image.Source = graphic.bitmap;
            }
        }
        private void SaveAsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                InitialDirectory = System.Environment.CurrentDirectory,
                Filter = "PNG files (*.png)|*.png"
            };
            Nullable<bool> result = saveFile.ShowDialog();

            if(result == true)
            {
                if(bitmapSource != null)
                {
                    CreateThumbnail(saveFile.FileName, bitmapSource);
                }
            }

        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Image.Source = null;
            bitmapSource = null;
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void ConvertToCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            List<string> llist = new List<string>();
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = "Pliki obrazów | *.jpg; *.jpeg; *.png",
                Title = "Wybierz obraz do skonwertowania"
            };
            Nullable<bool> result = openFile.ShowDialog();
            if(result == true)
            {
                Stream fs = openFile.OpenFile();
                using (fs)
                {
                    try
                    {
                        BitmapImage imgsrc = new BitmapImage();
                        imgsrc.BeginInit();
                        imgsrc.StreamSource = fs;
                        imgsrc.EndInit();

                        int stride = imgsrc.PixelWidth * 4;
                        int size = imgsrc.PixelHeight * stride;
                        byte[] pixels = new byte[size];
                        imgsrc.CopyPixels(pixels, stride, 0);

                        int index;
                        string temp;
                        for (int i = 0; i < imgsrc.PixelWidth; i++)
                        {
                            for (int j = 0; j < imgsrc.PixelHeight; j++)
                            {
                                index = j * stride + 4 * i;
                                byte blue = pixels[index];
                                byte green = pixels[index + 1];
                                byte red = pixels[index + 2];
                                byte alpha = pixels[index + 3];
                                temp = (i + 1).ToString() + ',' + (j + 1).ToString() + ':' + red.ToString() + ',' + green.ToString() + ',' + blue.ToString();
                                llist.Add(temp);
                            }
                        }

                        string fileNameWithoutExt = openFile.SafeFileName.Remove(openFile.SafeFileName.IndexOf('.'));
                        SaveFileDialog saveFile = new SaveFileDialog
                        {
                            InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                            Filter = "Pliki tekstowe (*.txt)|*.txt",
                            Title = "Zapisz plik tekstowy",
                            FileName = fileNameWithoutExt                            
                        };
                        result = saveFile.ShowDialog();

                        if (result == true)
                        {
                            System.IO.File.WriteAllLines(saveFile.FileName, llist);
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Format pliku jest nieprawidłowy!");
                    }
                }
            }
        }

        private void CreateThumbnail(string filename, BitmapSource image5)
        {
            if (filename != string.Empty)
            {
                using (FileStream stream5 = new FileStream(filename, FileMode.Create))
                {
                    PngBitmapEncoder encoder5 = new PngBitmapEncoder();
                    encoder5.Frames.Add(BitmapFrame.Create(image5));
                    encoder5.Save(stream5);
                }
            }
        }

        private void ConvertToCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveToCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Image.Source != null)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }
    }
}
