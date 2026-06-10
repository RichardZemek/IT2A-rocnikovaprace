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
using System.Windows.Shapes;


namespace DetektivniHra.Scenes
{
    public partial class StreetView : UserControl
    {
        private MainWindow _mainWindow;

        public StreetView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Trash_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.GameState.HasKey = true;
            DialogText.Text = "Našel jsi klíč! Odemkni dveře.";
        }

        private void Door_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.GameState.HasKey)
            {
                _mainWindow.LoadApartment();
            }
            else
            {
                DialogText.Text = "Dveře jsou zamčené! Zkus se porozhlédnout po klíči..";
            }
        }
    }
}
