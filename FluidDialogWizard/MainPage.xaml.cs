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
            double positioningY = 50;

            if (positioningX > 0)
                this.Popup.HorizontalOffset = positioningX;

            this.Popup.VerticalOffset = positioningY;

            this.Popup.IsOpen = true;
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            CloseDialog();
        }

        private void CloseDialog()
        {
            this.ModernTabControlUi.SelectedIndex = 0;
            this.Popup.IsOpen = false;
            VisualStateManager.GoToState(this, "Closed", false);
        }

        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.ModernTabControlUi.SelectedIndex = 1;
            VisualStateManager.GoToState(this, "Open", true);
            SetButtons();
        }
        
        private void OneButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.ModernTabControlUi.SelectedIndex = 1;
            SetButtons();
        }

        private void TwoButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.ModernTabControlUi.SelectedIndex = 2;
            SetButtons();
        }

        private void ThreeButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.ModernTabControlUi.SelectedIndex = 3;
            VisualStateManager.GoToState(this, "Closed", true);
        }

        private void FinishButton_OnClick(object sender, RoutedEventArgs e)
        {
            CloseDialog();
        }
        
        private void SetButtons()
        {
            switch (this.ModernTabControlUi.SelectedIndex)
            {
                case 1:
                    this.OneButton.IsEnabled = false;
                    this.TwoButton.IsEnabled = true;
                    this.ThreeButton.IsEnabled = true;
                    break;

                case 2:
                    this.OneButton.IsEnabled = true;
                    this.TwoButton.IsEnabled = false;
                    this.ThreeButton.IsEnabled = true;
                    break;

                default:
                    this.OneButton.IsEnabled = true;
                    this.TwoButton.IsEnabled = true;
                    this.ThreeButton.IsEnabled = true;
                    break;
            }
        }
    }
}