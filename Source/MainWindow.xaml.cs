using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Title = "Dynamic Title";



        //Brushes.Bisque
        Button button = new Button
        {
            Content = "Dynamic button",
            Background = new SolidColorBrush(Colors.BlueViolet),
            FontSize = 22,
        };

        Grid.SetColumn(button, 2);
        Grid.SetRow(button, 1);

        container.Children.Add(button);

    }
}