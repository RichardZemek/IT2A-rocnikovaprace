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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;
using System.Windows.Controls;

namespace DetektivniHra.Scenes
{
    public partial class WarehouseView : UserControl
    {
        private MainWindow _mainWindow;

        public WarehouseView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Suitcase_Click(object sender, RoutedEventArgs e)
        {
            DialogText.Text = "Našel jsi ztracený kufřík s důkazy! Případ je vyřešen.";
            _mainWindow.LoadEnd();
        }

        private void Box1_Click(object sender, RoutedEventArgs e)
        {
            DialogText.Text = "Jen stará zaprášená krabice.";
        }

        private void Box2_Click(object sender, RoutedEventArgs e)
        {
            DialogText.Text = "Tady nic důležitého není.";
        }
    }
}
