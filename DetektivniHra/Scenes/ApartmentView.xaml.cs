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
    public partial class ApartmentView : UserControl
    {
        private MainWindow _mainWindow;

        public ApartmentView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            DialogText.Text = "Dveře jsou odemčené! Porozhlédni se po stopě..";
        }

        private void Note_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.GameState.HasNote = true;
            DialogText.Text = "Našel jsi poznámku: Heslo k notebooku je MILLER1988.";
        }

        private void Computer_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.GameState.HasNote)
            {
                DialogText.Text = "Notebook odemčen. Zpráva říká: Kufřík je ve starém skladu.";
            }
            else
            {
                DialogText.Text = "Notebook je zamčený. Potřebuješ najít heslo.";
            }
        }

        private void Safe_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.GameState.HasNote)
            {
                _mainWindow.GameState.HasMap = true;
                DialogText.Text = "Trezor otevřen. Našel jsi mapu ke skladu.";
                _mainWindow.LoadWarehouse();
            }
            else
            {
                DialogText.Text = "Trezor je zamčený. Nejdřív najdi stopu.";
            }
        }
    }
}
