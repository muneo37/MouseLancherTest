using System.Windows;

namespace MouseLancherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var lancherWindow = new MouseLancherWindow();
            lancherWindow.Show();
        }
    }
}
