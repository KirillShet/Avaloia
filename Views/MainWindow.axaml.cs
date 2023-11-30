using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using Avalonia.Data;
using DynamicData;
using System.Threading.Tasks;
using Avalonia.Threading;

namespace AvaloniaApplication4.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void ClickHandler(object sender, RoutedEventArgs args)
        {
            ResultText.Text = "I'm working ...";
            RunButton.IsEnabled = false;
            if (message7.Text == "" || message7.Text == null)
            {
                message7.Background = Brushes.Red;
            }
            if (message8.Text == "" || message8.Text == null)
            {
                message8.Background = Brushes.Red;
            }
            if (message1.Text == "" || message1.Text == null)
            {
                message1.Background = Brushes.Red;
            }
            await Task.Delay(1000);
            message7.Background = Brushes.White;
            message8.Background = Brushes.White;
            message1.Background = Brushes.White;
            ResultText.Text = "Done";
            RunButton.IsEnabled = true;
            if (message7.Text != null && message8.Text != null && message1.Text != null)
            {
                new Window1().Show();
                Close();
            }
        }
      
        public void ButtonPressed2(object sender, RoutedEventArgs args)
        {
            if (message4.IsChecked == false)
            {
                message1.IsEnabled = true;
            }
            if (message4.IsChecked == true)
            {
                message1.IsEnabled = false;
            } 
        }
        public void ButtonPressed3(object sender, RoutedEventArgs args)
        {
            message7.Text = null;
            message8.Text = null;
            message1.Text = null;
        }
    }
}