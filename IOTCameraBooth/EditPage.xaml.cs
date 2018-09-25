﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IOTCameraBooth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditPage : Page
    {
        public EditPage()
        {
            this.InitializeComponent();
            getTakenImage();
        }

        public async void getTakenImage()
        {
            StorageFile file = await MainPage.storageFolder.GetFileAsync(MainPage.globalObject.getCurrentFile());
            imgViewer.Source = new BitmapImage(new Uri(file.Path));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainPage.globalObject.setCurrentFile(null);
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UploadProgressPage));
        }
    }
}
