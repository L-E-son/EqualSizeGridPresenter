using Mockups.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Mockups.DataStore
{
    public class TemplateGroup
    {
        private static readonly Random _random = new Random();
        private readonly string _groupName;
        public string GroupName => _groupName;

        private ObservableCollection<TemplatePreview> _previews = new ObservableCollection<TemplatePreview>()
        {
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/7hcl07ysmd1y.jpg", UriKind.Relative))),
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/cqic7kmoo3uy.jpg", UriKind.Relative))),
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/SHyuD6e.jpg", UriKind.Relative))),
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/vn7gpbosm9rx.jpg", UriKind.Relative))),
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/wAhk2Qz.jpg", UriKind.Relative))),
           new TemplatePreview(new BitmapImage(new Uri(@"Resources/X0dUkZ5.jpg", UriKind.Relative)))
        };

        public ObservableCollection<TemplatePreview> Previews => _previews;

        public TemplateGroup()
        {
            var next = _random.Next(1, 25);

            _groupName = string.Format("Template Group {0}", next);
            var arr = _previews.ToArray();

            for (int i = 0; i <= next; i++)
            {
                var rnd = _random.Next(0, arr.Count() - 1);
                _previews.Add(arr[rnd]);
            }

            _previews.Shuffle();
        }
    }
}
