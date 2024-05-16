using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace C
{
    internal class DictionaryUtility
    {
        internal static void ShowDictionary(Dictionary<string, string> dictionary)
        {
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Utility.WriteMessage($"Country: {item.Key} - {item.Value}");
            }
        }

        internal static bool FindKey_v0(Dictionary<string, string> dictionary, string key)
        {
            return dictionary.ContainsKey(key);
        }

        // outra versão do FindKey a informar a key e o value do país que já existe
        internal static bool FindKey(Dictionary<string, string> dictionary, string key)
        {
            // return dictionary.TryGetValue(key, out string value);
            bool result; 
            result = dictionary.TryGetValue(key, out string value); // not found = null
            return result;
        }

        internal static void InsertDictionaryEntry(Dictionary<string, string> dictionary, string key, string value)
        {
            dictionary.Add(key, value);
        }
    }
}
