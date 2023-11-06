using System;
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
using System.IO;

namespace homework06_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            //video_slider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            media.Volume = slider.Value;
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Failed to load media!", "Error!", MessageBoxButton.OK);
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var uri = new Uri(textbox.Text);
            media.Source = uri;
        }

        //private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    media.Position = TimeSpan.FromSeconds(video_slider.Value);
        //}
    }
}
