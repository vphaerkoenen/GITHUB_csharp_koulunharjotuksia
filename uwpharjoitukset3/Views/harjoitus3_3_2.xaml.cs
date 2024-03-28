using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpharjoitukset3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class harjoitus3_3_2 : Page
    {


        public harjoitus3_3_2()
        {
            this.InitializeComponent();
            shadowPanel.OffsetX = 0;
            shadowPanel.OffsetY = 0;
            slider.Minimum = 0;
            slider.Maximum = 500;
            slider.Value = 0;

        }
        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            shadowPanel.OffsetX = slider.Value;
            shadowPanel.OffsetY = slider.Value;
        }
    }
}
