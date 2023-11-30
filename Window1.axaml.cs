using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Avalonia.Media;
using System.Collections.ObjectModel;
using System;
using Avalonia.Data;
using DynamicData;
using Avalonia.Markup.Xaml;
using AvaloniaApplication4.Views;
using System.Threading.Tasks;
using Avalonia.Platform;

namespace AvaloniaApplication4;

public partial class Window1 : Window
{
    private int click;
    public Window1()
    {
        InitializeComponent();
        animals.Items = new string[]
            {"cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra" }
        .OrderBy(x => x);
        fontComboBox.Items = FontManager.Current
            .GetInstalledFontFamilyNames()
            .Select(x => new FontFamily(x))
            .OrderBy(x => x.Name);
        fontComboBox.SelectedIndex = 0;
    }
    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        Pravilo.IsVisible = false;
        Pane.IsPaneOpen = true;
        pictur1.IsVisible = false;
        pictur2.IsVisible = true;
    }
    public void ButtonPressed3(object sender, RoutedEventArgs args)
    {
            Pane.IsPaneOpen = false;
            Pravilo.IsVisible = true;
            pictur1.IsVisible = true;
            pictur2.IsVisible = false;

    }
}
