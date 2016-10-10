using System.Windows;

namespace CodeGuru_WPF_ValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsReady { get; set; }

        public MainWindow()
        {
            IsReady = true;

            InitializeComponent();
        }
    }
}
