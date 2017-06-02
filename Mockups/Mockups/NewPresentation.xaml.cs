using System.Windows;

namespace Mockups
{
    /// <summary>
    /// Interaction logic for NewPresentation.xaml
    /// </summary>
    public partial class NewPresentation : Window
    {
        public NewPresentation()
        {
            InitializeComponent();
        }

        private void Escape_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
