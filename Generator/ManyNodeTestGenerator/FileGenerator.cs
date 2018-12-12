using System.IO;

namespace ManyNodeTestGenerator
{
    class FileGenerator
    {
        // General tag items
        private const string openTag = "<%";
        private const string closeTag = "%>";

        // Class tag items
        private const string namespaceTag = "namespace";
        private const string nodeDefinitionsTag = "nodeDefinitions";

        // Node definition items
        private const string nodeNameTag = "nodeName";
        private const string classNameTag = "className";
        private const string numNodesTag = "numNodes";
        private const string nodeNumTag = "nodeNum";

        internal static void GenerateFile(
            string namespaceFile,
            string nodeFile,
            string namespaceText,
            string classNameText,
            int numNodes,
            string nodeNameText,
            string saveLocation)
        {
            // Limit the numNodes value to be between 1 and 10000 (inclusive)
            if (numNodes < 1)
                numNodes = 1;
            if (numNodes > 10000)
                numNodes = 10000;

            string outputFileText = File.ReadAllText(namespaceFile);

            // Set file namespace
            outputFileText = outputFileText.Replace(createTag(namespaceTag), namespaceText);

            // Add requested nodes
            outputFileText = outputFileText.Replace(
                createTag(nodeDefinitionsTag), 
                GenerateNodeDefinitions(
                    nodeFile,
                    classNameText,
                    numNodes));

            File.WriteAllText(saveLocation, outputFileText);
        }

        internal static string GenerateNodeDefinitions(
            string nodeFile,
            string classNameText,
            int numNodes)
        {
            string nodeText = File.ReadAllText(nodeFile);

            // Set the node name into the template text
            nodeText = nodeText.Replace(createTag(classNameTag), classNameText);

            // Add the requested number of node definitions
            string outputNodeText = "";
            for (var index = 0; index < numNodes; ++index)
            {
                outputNodeText += GenerateNodeDefinition(nodeText, index);
                if (index < numNodes - 1)
                    outputNodeText += "\r\n";
            }

            return outputNodeText;
        }

        internal static string GenerateNodeDefinition(
            string nodeText,
            int nodeNum)
        {
            // Add the node number as text to the node definition in the format of 0000 to 9999 (zero-based)
            return nodeText.Replace(createTag(nodeNumTag), nodeNum.ToString("D4"));
        }

        internal static string createTag(string tagText)
        {
            return openTag + tagText + closeTag;
        }
    }
}
