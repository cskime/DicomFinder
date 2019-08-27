using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using DicomFInder.Extensions;

namespace DicomFInder.Dataset
{
    public class MCS
    {
        private Dictionary<string, string> dataset = new Dictionary<string, string>();
        public MCS(FileInfo file)
        {
            string id, name, date;
            parse(file, out id, out name, out date);
            setMCSInfo(id, name, date, file.FullName, file.Length.ToString());
        }

        private void setMCSInfo(string id, string name, string date, string filepath, string filesize)
        {
            dataset[Columns.name.ToString()] = name;
            dataset[Columns.ID.ToString()] = id;
            dataset[Columns.birth.ToString()] = date;
            dataset[Columns.mcspath.ToString()] = filepath;
            dataset[Columns.filesize.ToString()] = filesize;
        }

        private void parse(FileInfo file, out string id, out string name, out string date)
        {
            string filename = Path.GetFileNameWithoutExtension(file.Name);
            string regex_name = @"[^0-9\-]+(\s|_)?[^0-9\-]+(\s|_)?[^0-9]*";
            string regex_number = "[0-9]{8,}";

            string parseName = Regex.Match(filename, regex_name).Value.Trim();
            name = parseName.Length.Equals(0) ? string.Empty : parseName.decode("ISO-8859-1", 51949);

            string parseNumber = Regex.Match(name, regex_number).Value;
            date = parseNumber.Length.Equals(14) ? parseNumber.Substring(0, 8) : string.Empty;
            id = parseNumber.Length.Equals(9) ? parseNumber : string.Empty;
        }

        public Dictionary<string, string> getDataset()
        {
            return dataset;
        }

        public string getData(string key)
        {
            string value;
            if (dataset.TryGetValue(key, out value))
                return value;
            else
                return null;
        }
    }
}
