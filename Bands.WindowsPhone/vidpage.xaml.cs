using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Bands
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class vidpage : Page
    {
        public vidpage()
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
        public BandsInfo info { get; set; }

        private void OnMediaOpened(object sender, RoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
            ProgressProgressBar.Visibility = Visibility.Collapsed;
        }
        private void OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
        }
        private void Previousbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = -2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position -= TimeSpan.FromMilliseconds(800);
        }
        private void Pausebtn_Click(object sender, RoutedEventArgs e)
        {
            if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Playing)
            {
                YouTubePlayerMediaElement.Pause();
                Pausebtn.Icon = new SymbolIcon(Symbol.Play);

            }
            else if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Paused)
            {
                Pausebtn.Icon = new SymbolIcon(Symbol.Pause);
                YouTubePlayerMediaElement.Play();
            }

        }
        private void Seekbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = 2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position += TimeSpan.FromMilliseconds(800);
        }

        
        private void YouTubePlayer_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            // YouTubePlayer.IsFullWindow= YouTubePlayer. ;
            if (YouTubePlayerMediaElement.IsFullWindow == true)
            {
                YouTubePlayerMediaElement.IsFullWindow = false;
                Expand.Icon = new SymbolIcon(Symbol.FullScreen);
            }
            else
            {
                YouTubePlayerMediaElement.IsFullWindow = true;
                Expand.Icon = new SymbolIcon(Symbol.BackToWindow);

            }
        }
        private void YouTubePlayer_DoubleTapped(object sender, RoutedEventArgs e)
        {
            // YouTubePlayer.IsFullWindow= YouTubePlayer. ;
            if (YouTubePlayerMediaElement.IsFullWindow == true)
            {
                YouTubePlayerMediaElement.IsFullWindow = false;
                Expand.Icon = new SymbolIcon(Symbol.FullScreen);
            }
            else
            {
                YouTubePlayerMediaElement.IsFullWindow = true;
                Expand.Icon = new SymbolIcon(Symbol.BackToWindow);

            }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
            {
                string Vid = e.Parameter as string;
                try
                {
                    ProgressProgressBar.IsEnabled = true;
                    var uri = await YouTube.GetVideoUriAsync(Vid, YouTubeQuality.Quality720P);
                    if (uri != null)
                    {
                        YouTubePlayerMediaElement.Source = uri.Uri;
                        YouTubePlayerMediaElement.Play();
                    }
                    else
                    {
                        Debugger.Break(); // TODO: Show error message (no video uri found)
                        ProgressProgressBar.IsEnabled = false;
                    }
                }
                catch (Exception exception)
                {
                    // TODO: Add exception handling
                    Debugger.Break();
                    ProgressProgressBar.IsEnabled = false;
                };
            }
        }
    }
}
