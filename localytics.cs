//
//  MonoTouch bindings for Localytics version 1.7 for iOS 4
//  use with libLocalytics.a  
//
//  Localytics iOS 4 Integration information:
//  http://wiki.localytics.com/doku.php?id=iphone_ios4_integration
//
//  MIT X11 licensed
//
// Copyright 2011 Kevin McMahon (http://twitter.com/klmcmahon)
// 

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Localytics
{
	[BaseType (typeof (NSObject))]
	interface LocalyticsSession {

		//+ (LocalyticsSession *)sharedLocalyticsSession;
		[Static, Export ("sharedLocalyticsSession")]
		LocalyticsSession SharedLocalyticsSession { get; }

		//- (void)LocalyticsSession:(NSString *)appKey;
		[Export ("LocalyticsSession:")]
		void InitializeLocalyticsSession (string appKey);

		//- (void)startSession:(NSString *)appKey;
		[Export ("startSession:")]
		void StartSession (string appKey);

		//- (void)setOptIn:(BOOL)optedIn;
		[Export ("setOptIn:")]
		void SetOptIn (bool optedIn);

		//- (BOOL)isOptedIn;
		[Export ("isOptedIn")]
		bool IsOptedIn { get; }

		//- (void)open;
		[Export ("open")]
		void Open ();

		//- (void)resume;
		[Export ("resume")]
		void Resume ();

		//- (void)close;
		[Export ("close")]
		void Close ();

		//- (void)tagEvent:(NSString *)event;
		[Export ("tagEvent:")]
		void TagEvent (string tagEvent);

		//- (void)tagEvent:(NSString *)event attributes:(NSDictionary *)attributes;
		[Export ("tagEvent:attributes:")]
		void TagEvent (string tagEvent, NSDictionary attributes);

		//- (void)upload;
		[Export ("upload")]
		void Upload ();
		
		//@property BOOL isSessionOpen;
		[Export ("isSessionOpen")]
		bool IsSessionOpen { get; set;  }

		//@property BOOL hasInitialized;		
		[Export ("hasInitialized")]
		bool HasInitialized{ get; set;  }

		//@property float backgroundSessionTimeout;
		[Export ("backgroundSessionTimeout")]
		float BackgroundSessionTimeout { get; set;  }
	}

	[BaseType (typeof (NSObject))]
	interface UploaderThread {

		//+ (UploaderThread *)sharedUploaderThread;
		[Static, Export ("sharedUploaderThread")]
		UploaderThread SharedUploaderThread { get; }

		//- (void)UploaderThread:(NSString *)localyticsFilePath;
		[Export ("UploaderThread:")]
		void InitializeUploaderThread (string localyticsFilePath);
		
		//@property (nonatomic, retain) NSURLConnection *uploadConnection;
		[Export ("uploadConnection", ArgumentSemantic.Retain)]
		NSUrlConnection UploadConnection { get; set;  }

		//@property (nonatomic, retain) NSString *localyticsFilePath;
		[Export ("localyticsFilePath", ArgumentSemantic.Retain)]
		string LocalyticsFilePath { get; set;  }
		
		//@property BOOL isUploading;
		[Export ("isUploading")]
		bool IsUploading { get; set; }
	}
}
