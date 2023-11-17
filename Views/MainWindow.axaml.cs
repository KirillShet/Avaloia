using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using Avalonia.Data;
using DynamicData;

namespace AvaloniaApplication4.Views
{
    public partial class MainWindow : Window
    {
        private string name;
        private string password;
        private string notes;
        public void ClickHandler(object sender, RoutedEventArgs args)
        {
            name = message7.Text;
            password = message8.Text;
            notes = message1.Text;
            message2.IsVisible = false;
            Text1.Text = "Имя пользоватяеля: " + name;
            Text2.Text = "Пароль пользоватяеля: " + password;
            Text3.Text = "Примечания пользоватяеля: " + notes;
            bor.IsVisible = true;
        }
        public void ClickHandler1(object sender, RoutedEventArgs args)
        {
            name = message7.Text;
            password = message8.Text;
            notes = message1.Text;
            message2.IsVisible = true;
            bor.IsVisible = false;
        }
        public MainWindow()
        {
            InitializeComponent();
            fontComboBox.Items = FontManager.Current
                .GetInstalledFontFamilyNames()
                .Select(x => new FontFamily(x))
                .OrderBy(x => x.Name);
            fontComboBox.SelectedIndex = 0;
        }

        public void ButtonPressed(object sender, RoutedEventArgs args)
        {
            message3.IsChecked = true;
        }
        public void ButtonPressed2(object sender, RoutedEventArgs args)
        {
            if (message3.IsChecked == false)
            {
                message1.IsEnabled = false;
            }
            else if (message3.IsChecked == true)
            {
                message1.IsEnabled = true;
                message3.IsChecked = false;
            }
        }
        public void ButtonPressed3(object sender, RoutedEventArgs args)
        {
            message7.Text = "";
            message8.Text = "";
            message1.Text = "";
        }
    }
}