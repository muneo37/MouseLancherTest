using System.Windows;

namespace MouseLancherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MouseLancherWindow _lancherWindow = new MouseLancherWindow();

        public MainWindow()
        {
            InitializeComponent();

            _lancherWindow.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _lancherWindow.Close();
        }
    }


}
