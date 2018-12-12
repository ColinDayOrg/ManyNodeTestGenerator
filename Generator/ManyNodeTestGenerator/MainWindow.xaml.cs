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

        private const string templatePath = @"D:\GitRepos\ManyNodeTest\Generator\ManyNodeTestGenerator\Assets\";
        private const string classTemplate = templatePath + @"ClassTemplate.cs";
        private const string nodeTemplate = templatePath + @"NodeTemplate.cs";
        private const string namespaceText = "ZTNodes";
        private const string classnameText = "NodeType";
        private int numNodes = 9999;
        private const string nodeNameText = "NodeType";

        private const string outputFile = @"D:\GitRepos\ManyNodeTest\ZTNodes\ZTNodes\Nodes_0001.cs";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileGenerator.GenerateFile(
                classTemplate,
                nodeTemplate,
                namespaceText,
                classnameText,
                numNodes,
                nodeNameText,
                outputFile);
        }
    }
}
