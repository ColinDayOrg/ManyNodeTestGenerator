using System.Windows;

namespace ManyNodeTestGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileGenerator.GenerateFile(
                @"D:\GitRepos\ManyNodeTest\Generator\ManyNodeTestGenerator\Assets\SingleNodeBaseFile.cs",
                @"D:\GitRepos\ManyNodeTest\ZTNodes\ZTNodes\Nodes_0001.cs");
        }
    }
}
