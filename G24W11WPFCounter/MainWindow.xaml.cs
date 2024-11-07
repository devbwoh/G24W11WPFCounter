using System.Windows;

namespace G24W11WPFCounter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        protected int Count = 0;

        public MainWindow() {
            InitializeComponent();
        }

        private void OnAdd(object sender, RoutedEventArgs e) {
            //BtnAdd.Content = "눌렸습니다";
            //TxtCount.Text = "눌렸습니다";
            TxtCount.Text = $"{++Count}";
        }

        private void OnSub(object sender, RoutedEventArgs e) {
            if (Count > 0) {
                TxtCount.Text = $"{--Count}";
            }
        }
    }
}