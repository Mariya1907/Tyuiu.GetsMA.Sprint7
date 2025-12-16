using System.Collections.Generic;
using System.IO;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Lib
{
    public class CsvService_GMA
    {
        public void SaveLines(string path, List<string> lines)
        {
            File.WriteAllLines(path, lines);
        }

        public List<string> LoadLines(string path)
        {
            return new List<string>(File.ReadAllLines(path));
        }
    }
}
