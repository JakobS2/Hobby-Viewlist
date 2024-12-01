using Hobby_Viewlist.VM;
using System.Windows;

namespace Hobby_Viewlist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HobbyVM viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new HobbyVM();
            DataContext = viewModel;
        }
    }
}