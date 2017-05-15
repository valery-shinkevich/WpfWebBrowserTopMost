using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfBrowserTopMost
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Visit(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.Navigate(new Uri(UrTextBox.Text));
            }
            catch 
            {
                UrTextBox.Text = "Ошибка в Url";
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            if (!MyWebBrowser.CanGoBack)
                return;
            MyWebBrowser.GoBack();
        }

        private void Forward(object sender, RoutedEventArgs e)
        {
            if (!MyWebBrowser.CanGoForward)
                return;
            MyWebBrowser.GoForward();
        }

        private void wb_Navigated(object sender, NavigationEventArgs e)
        {
            HistoryBox.Items.Add(MyWebBrowser.Source);
            UrTextBox.Text = MyWebBrowser.Source.ToString();
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyWebBrowser.Navigate(HistoryBox.SelectedItem.ToString());
        }

        private void ShowHide_OnClick(object sender, RoutedEventArgs e)
        {
            if (WrapPanel1.Visibility == Visibility.Visible)
            {
                WrapPanel1.Visibility = Visibility.Collapsed;
                WindowStyle = WindowStyle.None;
            }
            else
            {
                WrapPanel1.Visibility = Visibility.Visible;
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
        }
    }
}