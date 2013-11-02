using System.Windows;
using System.Windows.Controls;
namespace FluidDialogWizard
{
    public class ModernTabControlUi : TabControl
    {
        private ContentPresenter content;

        public ModernTabControlUi()
        {
            this.SelectionChanged += ModernTabControlUI_SelectionChanged;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            content = GetTemplateChild("ContentTop") as ContentPresenter;

            RunAnimation();
        }

        private void RunAnimation()
        {
            // force content back to having negative offset
            VisualStateManager.GoToState(this, "Normal", true);

            // slide in content
            VisualStateManager.GoToState(this, "Transition", true);
        }

        private void ModernTabControlUI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.content == null) return;

            RunAnimation();
        }
    }
}