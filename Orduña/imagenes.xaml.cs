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
    public sealed partial class imagenes : Orduña.Common.LayoutAwarePage
    {
        public imagenes()
        {
            this.InitializeComponent();
        }
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
