using Orduña.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Orduña
{
    sealed partial class app : Application
    {	
		private bool m_settingsReady=false;
        public app()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }
        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
			if (!this.m_settingsReady)
        	{				
           		SettingsPane.GetForCurrentView().CommandsRequested += OnCommandsRequested;
           		this.m_settingsReady = true;
        	}			
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
            {
                rootFrame = new Frame();                         
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");
                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                    }
                }
                Window.Current.Content = rootFrame;
            }
            if (rootFrame.Content == null)
            {
                if (!rootFrame.Navigate(typeof(itemsPage), "AllGroups"))
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            Window.Current.Activate();
        }
		void OnCommandsRequested(SettingsPane settingsPane, SettingsPaneCommandsRequestedEventArgs eventArgs)
		{
    		UICommandInvokedHandler handler = new UICommandInvokedHandler(OnSettingsCommand);
    		// Opcion
    		SettingsCommand emailCommand = 
        	new SettingsCommand("email", "Email", handler);
    		eventArgs.Request.ApplicationCommands.Add(emailCommand);
			// Opcion
    		SettingsCommand twitterCommand = 
        	new SettingsCommand("twitter", "Twitter", handler);
    		eventArgs.Request.ApplicationCommands.Add(twitterCommand);
		}	
		async void OnSettingsCommand(IUICommand command)
		{  		 	
    		SettingsCommand settingsCommand = (SettingsCommand)command;
    		switch ((string)settingsCommand.Id)
    		{			
        		case "twitter":
            		// Twitter          		
            		await Launcher.LaunchUriAsync(new Uri(
                	"https://twitter.com/UrayCR"));
            	break;				
				case "email":                    
            		// Email					
            		await Launcher.LaunchUriAsync(new Uri(
                	"mailto:uraycalvo@yahoo.es"));
            		break;		
    		}
		}		
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }
    }
}
