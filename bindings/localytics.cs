//
//  MonoTouch bindings for Localytics version 2.5 for iOS 5
//  use with libLocalytics.a  
//
//  MIT X11 licensed
//
// Copyright © 2011 Kevin McMahon (http://twitter.com/klmcmahon)
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
		[Static][Export ("sharedLocalyticsSession")]
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

		//- (void)tagEvent:(NSString *)event attributes:(NSDictionary *)attributes reportAttributes:(NSDictionary *)reportAttributes;
		[Export ("tagEvent:attributes:reportAttributes:")]
		void TagEvent (string tagEvent, NSDictionary attributes, NSDictionary reportAttributes);

		//- (void)tagScreen:(NSString *)screen;
		[Export ("tagScreen:")]
		void TagScreen (string screen);

		//- (void)upload;
		[Export ("upload")]
		void Upload ();

		//- (void)setCustomDimension:(int)dimension value:(NSString *)value;
		[Export ("setCustomDimension:value:")]
		void SetCustomDimension (int dimension, string value);
		
		//@property BOOL isSessionOpen;
		[Export ("isSessionOpen")]
 		bool IsSessionOpen { get; set; }

		//@property BOOL hasInitialized;		
		[Export ("hasInitialized")]
 		bool HasInitialized { get; set; }

		//@property float backgroundSessionTimeout;
		[Export ("backgroundSessionTimeout")]
		float BackgroundSessionTimeout { get; set; }

	}

	[BaseType (typeof (NSObject))]
	interface UploaderThread {

		//+ (UploaderThread *)sharedUploaderThread;
		[Static, Export ("sharedUploaderThread")]
		UploaderThread SharedUploaderThread { get; }

		//- (void)uploaderThreadwithApplicationKey:(NSString *)localyticsApplicationKey;
		[Export ("uploaderThreadwithApplicationKey:")]
		void UploaderThreadwithApplicationKey (string localyticsApplicationKey);

		//@property (nonatomic, retain) NSURLConnection *uploadConnection;
		[Export ("uploadConnection", ArgumentSemantic.Retain)]
		NSUrlConnection UploadConnection { get; set;  }

		//@property BOOL isUploading;
		[Export ("isUploading")]
 		bool IsUploading { get; set; }
	}
}
