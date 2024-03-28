using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpharjoitukset3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class harjoitus3_3_1 : Page
    {
        Image Calm = new Image();
        Image Lame = new Image();
        Image Wind = new Image();
        Image Strong = new Image();
        Image Crazy = new Image();


        BitmapImage calm = new BitmapImage();
        BitmapImage lame = new BitmapImage();
        BitmapImage wind = new BitmapImage();
        BitmapImage strong = new BitmapImage();
        BitmapImage crazy = new BitmapImage();


        public harjoitus3_3_1()
        {
            this.InitializeComponent();
            slider.Value = 0;

            calm.UriSource = new Uri("ms-appx:///Assets/tree0-5.png");

            lame.UriSource = new Uri("ms-appx:///Assets/tree6-11.png");

            wind.UriSource = new Uri("ms-appx:///Assets/tree12-17.png");

            strong.UriSource = new Uri("ms-appx:///Assets/tree18-23.png");

            crazy.UriSource = new Uri("ms-appx:///Assets/tree24-30.png");

            describingImage.Source = calm as ImageSource;

        }


        public void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            radialGauge.Value = slider.Value;
            if (slider.Value <= 5)
            {
                describingImage.Source = calm as ImageSource;
            }
            else if (slider.Value <= 11)
            {
                describingImage.Source = lame as ImageSource;
            }
            else if (slider.Value <= 17)
            {
                describingImage.Source = wind as ImageSource;
            }
            else if (slider.Value <= 23)
            {
                describingImage.Source = strong as ImageSource;
            }
            else
            {
                describingImage.Source = crazy as ImageSource;
            }
        }
    }
}