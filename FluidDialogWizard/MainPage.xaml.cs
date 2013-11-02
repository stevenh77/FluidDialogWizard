using System.Windows;

namespace FluidDialogWizard
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenCloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            // if you want the popup to stretch across the entire width of the screen,
            //  like Win8 then bind PopupContentContainer Width property to {Binding ActualWidth, ElementName=Popup}

            double positioningX = (Application.Current.Host.Content.ActualWidth / 2) - (PopupContentContainer.Width / 2);
            double positioningY = (Application.Current.Host.Content.ActualHeight / 2) - (PopupContentContainer.Height / 2);

            if (positioningX > 0)
                this.Popup.HorizontalOffset = positioningX;

            if (positioningY > 0)
                this.Popup.VerticalOffset = positioningY;

            this.Popup.IsOpen = !this.Popup.IsOpen;
        }
    }
}
