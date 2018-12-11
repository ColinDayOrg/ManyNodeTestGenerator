using System.IO;

namespace ManyNodeTestGenerator
{
    class FileGenerator
    {
        internal static void GenerateFile(
            string filename,
            string saveLocation)
        {
            string inputText = File.ReadAllText(filename);
            File.WriteAllText(saveLocation, inputText);
        }
    }
}
