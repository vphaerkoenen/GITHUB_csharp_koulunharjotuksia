using Microsoft.Toolkit.Uwp.UI.Animations;
using Microsoft.Toolkit.Uwp.UI.Animations.Expressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpharjoitukset3.Views
{
       
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class harjoitus3_3_3 : Page
    {
      

        public harjoitus3_3_3()
        {
            this.InitializeComponent();
                      
        }
       //seuraavat funktiot joko pienentävät tai suurentavat
       //neliön kokoa
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var visual = ElementCompositionPreview.GetElementVisual(rectangle);
            visual.Scale = new Vector3(visual.Scale.X + 0.1f, visual.Scale.Y + 0.1f, visual.Scale.Z);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var visual = ElementCompositionPreview.GetElementVisual(rectangle);
            visual.Scale = new Vector3(visual.Scale.X - 0.1f, visual.Scale.Y - 0.1f, visual.Scale.Z);
            
        }
    }
}
