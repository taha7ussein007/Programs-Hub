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
using Programs_Hub.ViewModel;
using Programs_Hub.Model;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;
using Windows.Storage;
using Windows.ApplicationModel.Store;
using Programs_Hub.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Programs_Hub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ApplicationDataContainer _roamingNumberOfVisit = ApplicationData.Current.RoamingSettings;
        ApplicationDataContainer _localNumberOfVisit = ApplicationData.Current.LocalSettings;
        ApplicationDataContainer _roamingData = ApplicationData.Current.RoamingSettings;
        ApplicationDataContainer _localData = ApplicationData.Current.LocalSettings;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        Data2 MyData2 = new Data2();

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public MainPage()
        {
            this.InitializeComponent();
            MyData2.Data_in();
            //myGridView.ItemsSource = MyData2.myList2;
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }


        private void aboutp_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about_page));
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + CurrentApp.AppId));
        }



        GridView myGridView;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            // myGridView = FindChildControl<GridView>(section_3, "progg") as GridView;
        }

        #region Unused
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Assign a collection of bindable groups to this.DefaultViewModel["Groups"]
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }


        //public NavigationHelper NavigationHelper
        //{
        //    get { return this.navigationHelper; }
        //}


        #endregion



        private void progg_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as prog1;
            var key = m.ID;
            this.Frame.Navigate(typeof(wecond), key);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(wecond));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////


        //Step 1
        private DependencyObject FindChildControl<T>(DependencyObject control, string ctrlName)
        {
            int childNumber = VisualTreeHelper.GetChildrenCount(control);
            for (int i = 0; i < childNumber; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(control, i);
                FrameworkElement fe = child as FrameworkElement;
                // Not a framework element or is null
                if (fe == null) return null;

                if (child is T && fe.Name == ctrlName)
                {
                    // Found the control so return
                    return child;
                }
                else
                {
                    // Not found it - search children
                    DependencyObject nextLevel = FindChildControl<T>(child, ctrlName);
                    if (nextLevel != null)
                        return nextLevel;
                }
            }
            return null;
        }

        private void progg_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView = FindChildControl<GridView>(section_3, "progg") as GridView;
            myGridView.ItemsSource = MyData2.myList2;
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1GW7N72");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1eQ3iQ3");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {

            var uri = new Uri("http://bit.ly/1daNBmX");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);

        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/1w64VQo");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://bit.ly/18ub3Xx");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

    }
}
