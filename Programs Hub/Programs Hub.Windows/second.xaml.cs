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
using Windows.UI.Xaml.Navigation;
using Programs_Hub.Model;
using Windows.UI.Xaml.Media.Imaging;
using Programs_Hub.Common;
using System.Diagnostics;
using MyToolkit.Multimedia;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Programs_Hub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class second : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        Data2 n = new Data2();

        int check;


        public second()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            n.Data_in();


        }





        private void Previousbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = -2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position -= TimeSpan.FromMilliseconds(800);
        }

        private void Seekbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = 2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position += TimeSpan.FromMilliseconds(800);
        }
        /// <summary>
        /// set the initail youtube video
        /// 
        /// </summary>
        //will not be neaded In The AppFactory App

        #region Youtube Videos
        private void OnMediaOpened(object sender, RoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
            ProgressProgressBar.Visibility = Visibility.Collapsed;
        }

        private void OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
        }


        protected async void youtubevideo(string id)
        {
            try
            {


                ProgressProgressBar.IsEnabled = true;
                var uri = await YouTube.GetVideoUriAsync(id, YouTubeQuality.Quality720P);

                // “JPF_iD1IXyc” video id from youtube video link
                if (uri != null)
                {

                    YouTubePlayerMediaElement.Source = uri.Uri;
                    YouTubePlayerMediaElement.Play();
                    // YouTubePlayerMediaElement.Source = uri.Uri;
                    // YouTubePlayerMediaElement.Play();
                }
                else
                {
                    Debugger.Break();
                    // TODO: Show error message (no video uri found)
                    ProgressProgressBar.IsEnabled = false;
                }
            }
            catch (Exception exception)
            {
                // TODO: Add exception handling
                Debugger.Break();
                ProgressProgressBar.IsEnabled = false;
            }
        }

        private void YouTubePlayer_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            // YouTubePlayer.IsFullWindow= YouTubePlayer. ;
            if (YouTubePlayerMediaElement.IsFullWindow == true)
            {
                YouTubePlayerMediaElement.IsFullWindow = false;
                // Expand.Icon = new SymbolIcon(Symbol.FullScreen);
            }
            else
            {
                YouTubePlayerMediaElement.IsFullWindow = true;
                //Expand.Icon = new SymbolIcon(Symbol.BackToWindow);

            }
        }

        private void Pausebtn_Click(object sender, RoutedEventArgs e)
        {
            if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Playing)
            {
                YouTubePlayerMediaElement.Pause();
                //Pausebtn.Icon = new SymbolIcon(Symbol.Play);

            }
            else if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Paused)
            {
                //Pausebtn.Icon = new SymbolIcon(Symbol.Pause);
                YouTubePlayerMediaElement.Play();
            }

        }
        #endregion


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
           
                if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
                {
                    int key = int.Parse(e.Parameter.ToString());
                    pName.Text = n.myList2[key].PName;
                    desc.Text = n.myList2[key].desc;
                    name.Text = n.myList2[key].PName;
                    mini.Text = n.myList2[key].mini_desc;
                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n.myList2[key].PImage));
                    pic.Source = bi;

                    ////////////////////////////////////////////////

                    youtubevideo(n.myList2[key].link);

                    check = n.myList2[key].ID;
                   
                }
            
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

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }


        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }


        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        #endregion

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //int keyLink = int.Parse(e.ToString());
            //var uri = new Uri(n.myList2[keyLink].link);
            //IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://cnet.co/1BShZOM");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {

            var uri = new Uri("http://bit.ly/1g4u0at");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1HrlgW1");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1LRJc4w");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1e5KfCR");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_6(object sender, TappedRoutedEventArgs e)
        {

            var uri = new Uri("http://bit.ly/1HjwYln");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

       


        public void nav(int r) {

            if (r == 0)
            {
                var uri = new Uri("http://bit.ly/18ub3Xx");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }

            if (r == 1)
            {
                var uri = new Uri("http://bit.ly/1eQ3iQ3");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }

            if (r == 2)
            {
                var uri = new Uri("http://bit.ly/1TP6xtd");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 3)
            {
                var uri = new Uri("http://bit.ly/1HjwYln");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 4)
            {
                var uri = new Uri("http://bit.ly/1daNBmX");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 5)
            {
                var uri = new Uri("http://bit.ly/1uq5zcV");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 6)
            {
                var uri = new Uri("http://bit.ly/1e5KfCR");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 7)
            {
                var uri = new Uri("http://bit.ly/1jWHeUd");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 8)
            {
                var uri = new Uri("http://bit.ly/1LRJc4w");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 9)
            {
                var uri = new Uri("http://bit.ly/1GW7N72");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 10)
            {
                var uri = new Uri("http://bit.ly/1p6Pn8w");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 11)
            {
                var uri = new Uri("http://bit.ly/1g4u0at");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 12)
            {
                var uri = new Uri("http://cnet.co/1BShZOM");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 13)
            {
                var uri = new Uri("http://bit.ly/1HrlgW1");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 14)
            {
                var uri = new Uri("http://bit.ly/1w64VQo");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
            if (r == 15)
            {
                var uri = new Uri("http://bit.ly/1LETR5F");
                IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (check == 0)
                nav(0);
            if (check == 1)
                nav(1);
            if (check == 2)
                nav(2);
            if (check == 3)
                nav(3);
            if (check == 4)
                nav(4);
            if (check == 5)
                nav(5);
            if (check == 6)
                nav(6);
            if (check == 7)
                nav(7);
            if (check == 8)
                nav(8);
            if (check == 9)
                nav(9);
            if (check == 10)
                nav(10);
            if (check == 11)
                nav(11);
            if (check == 12)
                nav(12);
            if (check == 13)
                nav(13);
            if (check == 14)
                nav(14);
            if (check == 15)
                nav(15);
        }

    }
}
