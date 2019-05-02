using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.Web.Http;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using SoundCloudeStreaming;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Bands
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Albums : Page
    {
        public Albums()
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
                Image.ImageSource = bi;
                n1.Text = Info.name1;
                n2.Text = Info.name2;
                n3.Text = Info.name3;
                n4.Text = Info.name4;
                n5.Text = Info.name5;
                n6.Text = Info.name6;
                n7.Text = Info.name7;
                n8.Text = Info.name8;
                n9.Text = Info.name9;
                n10.Text = Info.name10;
            }
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id1;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

            string id = Info.id2;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id3;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id4;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id5;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id6;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id7;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id8;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id9;
            Frame.Navigate(typeof(Sounds), id);
        }

        private void Image_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            string id = Info.id10;
            Frame.Navigate(typeof(Sounds), id);
        }
        
        
    }
}
