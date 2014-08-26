using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Orduña
{
    public sealed partial class comoLlegar : Orduña.Common.LayoutAwarePage
    {
        public comoLlegar()
        {
            this.InitializeComponent();
        }
		private async void bilbao(object sender, RoutedEventArgs e)
        {
           string myBingMapsUri = "bingmaps:?rtp=adr.Bilbao~adr.Orduña";
		   await Windows.System.Launcher.LaunchUriAsync(new Uri(myBingMapsUri));
        }		
		private async void vitoria(object sender, RoutedEventArgs e)
        {
           string myBingMapsUri = "bingmaps:?rtp=adr.Vitoria-~adr.Orduña";
		   await Windows.System.Launcher.LaunchUriAsync(new Uri(myBingMapsUri));
        }		
		private async void sanSebastian(object sender, RoutedEventArgs e)
        {
           string myBingMapsUri = "bingmaps:?rtp=adr.San Sebastian~adr.Orduña";
		   await Windows.System.Launcher.LaunchUriAsync(new Uri(myBingMapsUri));
        }		
		private async void madrid(object sender, RoutedEventArgs e)
        {
           string myBingMapsUri = "bingmaps:?rtp=adr.Madrid~adr.Orduña";
		   await Windows.System.Launcher.LaunchUriAsync(new Uri(myBingMapsUri));
        }
    }
}
