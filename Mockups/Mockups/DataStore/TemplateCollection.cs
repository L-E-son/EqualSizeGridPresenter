using Mockups.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockups.DataStore
{
    public static class TemplateCollection
    {
        private static readonly ObservableCollection<TemplateGroup> _allEntries = new ObservableCollection<TemplateGroup>()
        {
            new TemplateGroup(),
            new TemplateGroup(),
            new TemplateGroup(),
            new TemplateGroup(),
            new TemplateGroup(),
            new TemplateGroup()
        };

        public static ObservableCollection<TemplateGroup> AllGroups => _allEntries;
    }
}
