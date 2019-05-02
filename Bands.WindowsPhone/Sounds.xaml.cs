using SoundCloudeStreaming;
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
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.Media;
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
    public sealed partial class Sounds : Page
    {
        public Sounds()
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


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as BandsInfo;
            string id = e.Parameter.ToString();
            if (InternetConnection.IsConnectedToInternet())
            {
                await PlayTrack(id);
            }
            else
            {
                MessageDialog msg = new MessageDialog("please check your internet connection");
                await msg.ShowAsync();
            }
        }
        async Task PlayTrack(string id)
        {
            string trackId = id;
            string clientId = "9167b74269389887f71ac75091d06fe7";
            var response = await SoundCloudeStreaming.Helper.Http.GetHttpRequestAsync(new Uri("http://api.soundcloud.com/tracks/" + trackId + ".json?client_id=" + clientId));
            var track = new SoundCloudTrack(JsonObject.Parse(response));
            track.stream_url += "?client_id=" + clientId;
            Track.Source = new Uri(track.stream_url);
        }
    }
}
