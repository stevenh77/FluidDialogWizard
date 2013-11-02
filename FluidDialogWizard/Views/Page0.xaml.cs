using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FluidDialogWizard.Views
{
    public partial class Page0 : Page
    {
        public Page0()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "StepOne", true);
            this.NavigationService.Navigate(new Uri("/Views/Page1.xaml", UriKind.Relative));
        }
    }
}
