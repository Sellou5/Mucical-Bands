using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Syndication;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Bands
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class YoutubePage : Page
    {
        public YoutubePage()
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
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
            {
                Info = e.Parameter as BandsInfo;
                BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + Info.backg));
                bc.ImageSource = bi;
                string chn = Info.w1;
                if (InternetConnection.IsConnectedToInternet())
                {
                    youtubechanel(chn);
                }
                else
                {
                    MessageDialog msg = new MessageDialog("please check your internet connection");
                    await msg.ShowAsync();
                }
            }
        }
        protected async void youtubechanel(string channl)
        {
            string chn = channl;
            
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    //Choose the gap of the videos list
                    //Index
                    int index = 1;
                    //The number of videos you would like to get (from 1 to 50)
                    int maxResults = 50;

                    //To get more than 50 videos, just use pagination and change the index :
                    //int index = 51;

                    //Channel Videos
                    ChannelVideosListView.Visibility = Visibility.Collapsed;
                    ChannelProgressProgressRing.Visibility = Visibility.Visible;

                    //Here is the name of the Channel
                    string youtubeChannel = chn;
                    //+ "/uploads?alt=rss&v=2&orderby=published&start-index=" + index + "&max-results=" + maxResults
                    var channelVideos = await GetYoutubeChannel("https://www.youtube.com/feeds/videos.xml?channel_id=" + youtubeChannel + "&orderby=published&start-index=" + index + "&max-results=" + maxResults);
                    ChannelVideosListView.ItemsSource = channelVideos;

                    ChannelVideosListView.Visibility = Visibility.Visible;
                    ChannelProgressProgressRing.Visibility = Visibility.Collapsed;
                    /////////

                    
                }
                else
                {
                    MessageDialog message = new MessageDialog("You're not connected to Internet!");
                    await message.ShowAsync();
                }
            }
            catch { }
        }
        private  void ChannelVideosListViewItemClick(object sender, ItemClickEventArgs e)
        {
            YoutubeVideo video = e.ClickedItem as YoutubeVideo;
            string id = video.Id;
            Frame.Navigate(typeof(vidpage), id);
        }
        /// <summary>
        /// Method to get the vdieos from the Youtube Channel
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<List<YoutubeVideo>> GetYoutubeChannel(string url)
        {
            try
            {
                SyndicationClient client = new SyndicationClient();
                SyndicationFeed feed = await client.RetrieveFeedAsync(new Uri(url));

                List<YoutubeVideo> videosList = new List<YoutubeVideo>();
                YoutubeVideo video;
                foreach (SyndicationItem item in feed.Items)
                {
                    video = new YoutubeVideo();

                    video.YoutubeLink = item.Links[0].Uri;
                    string a = video.YoutubeLink.ToString().Remove(0, 31);
                    video.Id = a.Substring(0, 11);
                    video.Title = item.Title.Text;
                    video.PubDate = item.PublishedDate.DateTime;

                    video.Thumbnail = YouTube.GetThumbnailUri(video.Id, YouTubeThumbnailSize.Medium);

                    videosList.Add(video);
                }

                return videosList;
            }
            catch
            {
                return null;
            }
        }

    }
}
