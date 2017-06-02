using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Mockups.DataStore
{
    public class TemplatePreview
    {
        private static readonly Random _random = new Random();

        private readonly BitmapSource _image;
        private readonly string _name;
        private readonly Guid _id;
        public BitmapSource Image => _image;
        public string Name => _name;
        public Guid ID => _id;

        public TemplatePreview(BitmapSource source)
        {
            _image = source;
            _id = new Guid();
            _name = string.Format("Template {0}", _random.Next(1, 50));
        }
    }
}
