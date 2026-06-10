using System.Windows;
using DetektivniHra.Game;
using DetektivniHra.Scenes;

namespace DetektivniHra
{
    public partial class MainWindow : Window
    {
        public GameState GameState { get; set; } = new GameState();

        public MainWindow()
        {
            InitializeComponent();
            LoadStart(); // důležité
        }

        public void LoadStart()
        {
            MainContainer.Children.Clear();
            MainContainer.Children.Add(new StartView(this));
        }

        public void LoadStreet()
        {
            MainContainer.Children.Clear();
            MainContainer.Children.Add(new StreetView(this));
        }

        public void LoadApartment()
        {
            MainContainer.Children.Clear();
            MainContainer.Children.Add(new ApartmentView(this));
        }

        public void LoadWarehouse()
        {
            MainContainer.Children.Clear();
            MainContainer.Children.Add(new WarehouseView(this));
        }

        public void LoadEnd()
        {
            MainContainer.Children.Clear();
            MainContainer.Children.Add(new EndView(this));
        }
    }
}