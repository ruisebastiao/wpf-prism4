using Microsoft.Windows.Controls.Ribbon;
using LearningWpf.ViewModels;

namespace LearningWpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : RibbonWindow
    {
        public Shell()
        {
            InitializeComponent();
            this.DataContext = new ShellViewModel();
        }
    }
}
