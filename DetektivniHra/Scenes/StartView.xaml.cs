using System.Windows;
using System.Windows.Controls;

namespace DetektivniHra.Scenes
{
    public partial class StartView : UserControl
    {
        private MainWindow _mainWindow;

        public StartView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.LoadStreet();
        }
    }
}