﻿using System;
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
using Windows.Storage;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkID=390556 上有介绍

namespace Closet
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ChooseSex : Page
    {
        private static bool IsMan = true;
        private ApplicationDataContainer appDC;

        /// <summary>
        /// UserSex值为true时性别为男，false为女
        /// </summary>
        private const string UserSex = "UserSex";
        public ChooseSex()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。
        /// 此参数通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void womanBorder_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SolidColorBrush scb=new SolidColorBrush(Windows.UI.Colors.LightGoldenrodYellow);
            this.womanBorder.BorderBrush = scb;
            scb = new SolidColorBrush();
            this.manBorder.BorderBrush = scb;
            IsMan = false;
        }

        private void manBorder_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SolidColorBrush scb = new SolidColorBrush(Windows.UI.Colors.LightGoldenrodYellow);
            this.manBorder.BorderBrush = scb;
            scb = new SolidColorBrush();
            this.womanBorder.BorderBrush = scb;
            IsMan = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appDC = ApplicationData.Current.LocalSettings;
            appDC.Values[UserSex] = IsMan;
        }
    }
}
