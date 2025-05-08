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
        private string _currentLangCode = "ar";
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
            if (parent.Tag != null && !(parent is TextBox) && !(parent is Guna.UI2.WinForms.Guna2TextBox))
            {
                parent.Text = Translate(scope, parent.Tag.ToString());
            }

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is DataGridView dataGridView)
                {
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        if (column.Tag != null)
                        {
                            string translated = Translate(scope, column.Tag.ToString());
                            column.HeaderText = translated;

                            if (column is DataGridViewButtonColumn buttonColumn)
                            {
                                buttonColumn.Text = translated;
                            }
                        }
                    }
                }
                else if (ctrl is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    if (txt.Tag != null)
                        txt.PlaceholderText = Translate(scope, txt.Tag.ToString());
                }
                else if (ctrl is ITranslatable translatable)
                {
                    Apply(translatable);
                }

                // recursive call
                ApplyToControls(ctrl, scope);
            }
        }

        public void ApplyOnce(ITranslatable translatable)
        {
            Apply(translatable);
            translatable.ApplyTranslation();
        }
        public string CurrentLanguage => _currentLangCode;
    }
}
