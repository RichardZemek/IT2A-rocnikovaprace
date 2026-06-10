using System.Windows;
using System.Windows.Controls;
using DetektivniHra.Game;

namespace DetektivniHra.Scenes
{
    public partial class EndView : UserControl
    {
        private MainWindow _mainWindow;

        public EndView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.GameState = new GameState();
            _mainWindow.LoadStreet();
        }
    }
}