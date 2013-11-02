using System;
using System.Windows;
using System.Windows.Navigation;

namespace FluidDialogWizard
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenDialogButton_Click(object sender, RoutedEventArgs e)
        {
            // if you want the popup to stretch across the entire width of the screen,
            //  like Win8 then bind PopupContentContainer Width property to {Binding ActualWidth, ElementName=Popup}

            double positioningX = (Application.Current.Host.Content.ActualWidth / 2) - (PopupContentContainer.Width / 2);
            double positioningY = (Application.Current.Host.Content.ActualHeight / 2) - (PopupContentContainer.Height / 2);

            if (positioningX > 0)
                this.Popup.HorizontalOffset = positioningX;

            if (positioningY > 0)
                this.Popup.VerticalOffset = positioningY;

            //this.ContentFrame.Navigate(new Uri("/Views/Page0.xaml", UriKind.Relative));
            this.Popup.IsOpen = true;
            VisualStateManager.GoToState(this, "Open", true);
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Popup.IsOpen = false;
            VisualStateManager.GoToState(this, "Closed", false);
        }

        private void OneButton_OnClick(object sender, RoutedEventArgs e)
        {
            //VisualStateManager.GoToState(this, "Open", true);
            //this.ContentFrame.Navigate(new Uri("/Views/Page1.xaml", UriKind.Relative));
        }

        private void TwoButton_OnClick(object sender, RoutedEventArgs e)
        {
            //this.ContentFrame.Navigate(new Uri("/Views/Page2.xaml", UriKind.Relative));
        }

        private void ThreeButton_OnClick(object sender, RoutedEventArgs e)
        {
            //this.ContentFrame.Navigate(new Uri("/Views/Page3.xaml", UriKind.Relative));
        }
    }
}
