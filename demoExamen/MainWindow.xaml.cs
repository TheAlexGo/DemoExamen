using System.Windows;
using demoExamen.Pages;

namespace demoExamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMain.Content = new LoginPage();
        }
    }
}
