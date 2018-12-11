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

        private string classTemplate = @"D:\GitRepos\ManyNodeTest\Generator\ManyNodeTestGenerator\Assets\ClassTemplate.cs";
        private string namespaceText = "ZTNodes";
        private string classnameText = "NodeType";
        private string outputFile = @"D:\GitRepos\ManyNodeTest\ZTNodes\ZTNodes\Nodes_0001.cs";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileGenerator.GenerateFile(
                classTemplate,
                namespaceText,
                classnameText,
                outputFile);
        }
    }
}
