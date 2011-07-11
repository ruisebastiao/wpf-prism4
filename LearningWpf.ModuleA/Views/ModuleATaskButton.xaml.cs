using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using LearningWpf.ModuleA.ViewModels;

namespace LearningWpf.ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ModuleATaskButton.xaml
    /// </summary>
    [ViewSortHint("01")]
    public partial class ModuleATaskButton : UserControl
    {
        public ModuleATaskButton(ModuleATaskButtonViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
