using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicomFInder.Extensions
{
    public static class MyExtension
    {
        public static string decode(this string name, string codeName, int codePage)
        {
            // 한글 디코딩
            Encoding iso = Encoding.GetEncoding(codeName);                  // "ISO-8859-1"
            Decoder euckr = Encoding.GetEncoding(codePage).GetDecoder();    // 51949
            byte[] isoByte = iso.GetBytes(name);
            char[] decodename;
            int charCount = euckr.GetCharCount(isoByte, 0, isoByte.Length);
            decodename = new char[charCount];
            int charDecodedCount = euckr.GetChars(isoByte, 0, isoByte.Length, decodename, 0);
            return new string(decodename);
        }

        public static IEnumerable<KeyValuePair<string, string>> ForEach(this IEnumerable<KeyValuePair<string, string>> keyValuePair) 
        {
            foreach (var kvp in keyValuePair)
            {

            }

            return keyValuePair;
        }
    }
}
