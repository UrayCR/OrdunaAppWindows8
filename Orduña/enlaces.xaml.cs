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
    public sealed partial class enlaces : Orduña.Common.LayoutAwarePage
    {
        public enlaces()
        {
            this.InitializeComponent();
        }
      	private async void ayuntamiento(object sender, TappedRoutedEventArgs e)
   		{
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.urduna.com/es-ES/Paginas/default.aspx"));
   		}		
		private async void paisVasco(object sender, TappedRoutedEventArgs e)
   		{
			await Windows.System.Launcher.LaunchUriAsync(new Uri("http://turismo.euskadi.net/es/"));
   		}		
    }
}
