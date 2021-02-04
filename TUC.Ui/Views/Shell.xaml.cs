using System.Windows;
using System.Windows.Input;

namespace TUC.ui
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell
    {
        public Shell(ShellViewModel shellViewModel)
        {
            this.DataContext = shellViewModel;
            InitializeComponent();
            SizeChanged += PreventMaximise;
        }

        private void PreventMaximise(object sender, SizeChangedEventArgs e)
        {
            if(WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }
}
