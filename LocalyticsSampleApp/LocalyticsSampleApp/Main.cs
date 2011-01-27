
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Localytics;

namespace LocalyticsSampleApp
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}
	
	/// EXTREMELY IMPORTANT: You must include a subclass of these classes
	/// due to a known issue in MonoTouch as of 3.2.4.  The issue is expected
	/// to be resolved in the next major release of MonoTouch.
	class SubLocalyticsSession : LocalyticsSession {}
	class SubUploaderThread : UploaderThread {}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		string YOUR_LOCALYTICS_APP_KEY = "";
		
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			if(string.IsNullOrEmpty(YOUR_LOCALYTICS_APP_KEY))
				throw new ArgumentException("You must provide a valid Localytics app key. Get one "+
				                            "at http://www.localytics.com");
			// If you have defined a view, add it here:
			// window.AddSubview (navigationController.View);
			window.MakeKeyAndVisible ();

			Localytics.LocalyticsSession.SharedLocalyticsSession.StartSession(YOUR_LOCALYTICS_APP_KEY);
			Localytics.LocalyticsSession.SharedLocalyticsSession.Open();
			
			button.TouchDown += (o,e) => {
				Console.WriteLine("Touch Me Hit");
				Localytics.LocalyticsSession.SharedLocalyticsSession.TagEvent("SampleApp Button Touch");
			};
			
			upload.TouchDown += (o,e) => {
				Console.WriteLine("Trigger Upload Hit");
				Localytics.LocalyticsSession.SharedLocalyticsSession.Upload();
			};
			return true;
		}

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}

		public override void WillEnterForeground (UIApplication application)
		{
			Localytics.LocalyticsSession.SharedLocalyticsSession.Resume();
			Localytics.LocalyticsSession.SharedLocalyticsSession.Upload();
		}
		
		public override void DidEnterBackground (UIApplication application)
		{
			CloseLocalyticsSession();
		}
		
		public override void WillTerminate (UIApplication application)
		{
			CloseLocalyticsSession();
		}
		
		void CloseLocalyticsSession()
		{
			Localytics.LocalyticsSession.SharedLocalyticsSession.Close();
			Localytics.LocalyticsSession.SharedLocalyticsSession.Upload();
		}
	}
}