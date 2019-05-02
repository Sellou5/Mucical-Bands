using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Bands
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecPage : Page
    {
        public SecPage()
        {
            this.InitializeComponent();

            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }
        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame != null && rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
                e.Handled = true;
            }
        }

        public BandsInfo Info { get; set; }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
            {
                Info = e.Parameter as BandsInfo;
                BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + Info.backg));
                Thebg.ImageSource = bi;
                TheName.Text = Info.Name;
            }
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            Frame.Navigate(typeof(YoutubePage),Info);
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(YoutubePage), Info);
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Albums), Info);
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Albums), Info);
        }
    }
}
