using System.IO;

namespace ManyNodeTestGenerator
{
    class FileGenerator
    {
        private const string openTag = "<%";
        private const string closeTag = "%>";
        private const string namespaceTag = "namespace";
        private const string classNameTag = "className";

        internal static void GenerateFile(
            string namespaceFile,
            string namespaceText,
            string classNameText,
            string saveLocation)
        {
            string outputFileText = File.ReadAllText(namespaceFile);
            string fullNamespaceTag = openTag + namespaceTag + closeTag;
            string fullClassNameTag = openTag + classNameTag + closeTag;

            outputFileText = outputFileText.Replace(fullNamespaceTag, namespaceText);
            outputFileText = outputFileText.Replace(fullClassNameTag, classNameText);

            File.WriteAllText(saveLocation, outputFileText);
        }
    }
}
