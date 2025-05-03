using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public class ScopedTranslator
    {
        private string _currentLangCode = "en";
        private Dictionary<string, Dictionary<string, string>> _allTranslations = new Dictionary<string, Dictionary<string, string>>();
        private List<ITranslatable> _subscribers = new List<ITranslatable>();

        public static ScopedTranslator Instance { get; } = new ScopedTranslator();

        private ScopedTranslator() => LoadLanguage(_currentLangCode);

        public void SetLanguage(string langCode)
        {
            _currentLangCode = langCode;
            LoadLanguage(langCode);
            ApplyToAll();
        }

        public void Register(ITranslatable translatable)
        {
            if (!_subscribers.Contains(translatable))
                _subscribers.Add(translatable);
        }

        public void Unregister(ITranslatable translatable)
        {
            _subscribers.Remove(translatable);
        }

        public string Translate(string scope, string key)
        {
            if (_allTranslations.TryGetValue(scope, out var dict) &&
                dict.TryGetValue(key, out var val))
                return val;

            return key;
        }

        private void LoadLanguage(string langCode)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\.."));
            var path = Path.Combine(projectRoot, "Languages", $"{langCode}.json");

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                _allTranslations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            }
            else
            {
                _allTranslations = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        private void ApplyToAll()
        {
            foreach (var subscriber in _subscribers)
            {
                Apply(subscriber);
                subscriber.ApplyTranslation();
            }
        }

        private void Apply(ITranslatable item)
        {
            ApplyToControls(item.RootControl, item.Scope);
        }

        private void ApplyToControls(Control parent, string scope)
        {
            if (parent.Tag != null)
                parent.Text = Translate(scope, parent.Tag.ToString());

            foreach (Control ctrl in parent.Controls)
            {
                ApplyToControls(ctrl, scope);
            }
        }

        public string CurrentLanguage => _currentLangCode;
    }
}
