using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AlhamdApplication
{
    public class ScopedTranslator
    {
        private Dictionary<string, string> _scopedTranslations;

        public ScopedTranslator(string scope, string langCode)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\.."));

            var path = Path.Combine(projectRoot, "Languages", $"{langCode}.json");

            if (File.Exists(path))
            {
                var fullJson = File.ReadAllText(path);

                var fullDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(fullJson);

                if (fullDict != null && fullDict.ContainsKey(scope))
                    _scopedTranslations = fullDict[scope];
                else
                    _scopedTranslations = new Dictionary<string, string>();
            }
            else
            {
                _scopedTranslations = new Dictionary<string, string>();
            }
        }

        public string T(string key)
        {
            return _scopedTranslations.TryGetValue(key, out var val) ? val : key;
        }

        public void Apply(Control parent)
        {
            if (parent.Tag != null)
                parent.Text = T(parent.Tag.ToString());

            foreach (Control ctrl in parent.Controls)
            {
                Apply(ctrl);
            }
        }
    }

}
