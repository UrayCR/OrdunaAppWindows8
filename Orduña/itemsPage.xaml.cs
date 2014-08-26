using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Orduña
{
    public sealed partial class itemsPage : Orduña.Common.LayoutAwarePage
    {
        public itemsPage()
        {
            this.InitializeComponent();
        }		
		private  void naturaleza(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(naturaleza));
   		}		
		private void dondeComer(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(dondeComer));
   		}		
		private void dondeDormir(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(dondeDormir));
   		}		
		private void fiestas(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(fiestas));
   		}		
		private void nuestrosProductos(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(nuestrosProductos));
   		}		
		private  void imagenes(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(imagenes));
   		}
        private async void mapa(object sender, RoutedEventArgs e)
        {
            string myBingMapsUri = "bingmaps:?cp=Orduña";
			await Windows.System.Launcher.LaunchUriAsync(new Uri(myBingMapsUri));
        }		
		private async void video(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("ms-appx:///Orduña.mp4");
            var file = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(uri);
            await Windows.System.Launcher.LaunchFileAsync(file);
        }	
		private async void folleto(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("ms-appx:///Orduña.pdf");
            var file = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(uri);
            await Windows.System.Launcher.LaunchFileAsync(file);
        }		
		private void enlaces(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(enlaces));
        }		
		private  void comoLlegar(object sender, TappedRoutedEventArgs e)
   		{
			this.Frame.Navigate(typeof(comoLlegar));
   		}	
    }
}
