using Bands.Common;
using BMC.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Bands
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Albums : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public BandsInfo Info { get; set; }
        public Albums()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
            {
                Info = e.Parameter as BandsInfo;
                BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + Info.backg));
                image.ImageSource = bi;
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

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

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
