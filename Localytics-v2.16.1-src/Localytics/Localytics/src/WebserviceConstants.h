//  WebserviceConstants.h
//  Copyright (C) 2013 Char Software Inc., DBA Localytics
//
//  This code is provided under the Localytics Modified BSD License.
//  A copy of this license has been distributed in a file called LICENSE
//  with this source code.
//
// Please visit www.localytics.com for more information.

// The constants which are used to make up the JSON blob
// To save disk space and network bandwidth all the keywords have been
// abbreviated and are exploded by the server.

/*****************
 * Upload Header *
 *****************/
#define HEADER_CLIENT_TIME      @"x-upload-time"
#define HEADER_INSTALL_ID       @"x-install-id"
#define HEADER_CLIENT_VERSION   @"x-client-version"

/*********************
 * Shared Attributes *
 *********************/
#define PARAM_UUID                  @"u"        // UUID for JSON document
#define PARAM_DATA_TYPE             @"dt"       // Data Type
#define PARAM_CLIENT_TIME           @"ct"       // Client Time, seconds from Unix epoch (int)
#define PARAM_LATITUDE              @"lat"      // Latitude - if available
#define PARAM_LONGITUDE             @"lon"      // Longitude - if available
#define PARAM_SESSION_UUID          @"su"       // UUID for an existing session
#define PARAM_NEW_SESSION_UUID      @"u"        // UUID for a new session
#define PARAM_ATTRIBUTES            @"attrs"    // Attributes (dictionary)
#define PARAM_SESSION_ELAPSE_TIME   @"sl"       // Number of seconds since the previous session start

/***************
 * Blob Header *
 ***************/

// PARAM_UUID
// PARAM_DATA_TYPE => "h" for Header
// PARAM_ATTRIBUTES => dictionary containing Header Common Attributes
#define PARAM_PERSISTED_AT          @"pa"       // Persistent Storage Created At. A timestamp created when the app was
                                                // first launched and the persistent storage was created. Stores as
                                                // seconds from Unix epoch. (int)
#define PARAM_SEQUENCE_NUMBER       @"seq"      // Sequence number - an increasing count for each blob, stored in the
                                                // persistent store Consistent across app starts. (int)

/****************************
 * Header Common Attributes *
 ****************************/

// PARAM_DATA_TYPE
#define PARAM_APP_KEY               @"au"		// Localytics Application ID
#define PARAM_DEVICE_UUID_HASHED    @"udid"     // Hashed version of the UUID
#define PARAM_DEVICE_ADID           @"adid"     // Advertising Identifier
#define PARAM_INSTALL_ID            @"iu"       // Install ID
#define PARAM_JAILBROKEN            @"j"        // Jailbroken (boolean)
#define PARAM_LIBRARY_VERSION       @"lv"		// Client Version
#define PARAM_APP_VERSION           @"av"       // Application Version
#define PARAM_DEVICE_PLATFORM       @"dp"		// Device Platform
#define PARAM_LOCALE_LANGUAGE       @"dll"		// Locale Language
#define PARAM_LOCALE_COUNTRY        @"dlc"		// Locale Country
#define PARAM_DEVICE_COUNTRY        @"dc"       // Device Country (iso code)
#define PARAM_DEVICE_MODEL          @"dmo"      // Device Model
#define PARAM_DEVICE_OS_VERSION     @"dov"      // Device OS Version
#define PARAM_NETWORK_CARRIER       @"nca"      // Network Carrier
#define PARAM_OPT_VALUE             @"out"      // Opt Out (boolean)
#define PARAM_DEVICE_MEMORY         @"dmem"     // Device Memory
#define PARAM_IDENTIFIERS           @"ids"      // Identifiers (dictionary)
#define PARAM_BIRTH_TIME            @"b"        // Birth time (Since epoch)
#define PARAM_TIMEZONE_OFFSET		@"tz"       // Device offset from GMT in seconds

/*****************
 * Session Start *
 *****************/

// PARAM_UUID
// PARAM_DATA_TYPE => "s" for Start
// PARAM_CLIENT_TIME
#define PARAM_SESSION_NUMBER        @"nth"      // This is the nth session on the device, 1-indexed (int)

/****************
 * Session Stop *
 ****************/

// PARAM_UUID
// PARAM_DATA_TYPE => "c" for Close
// PARAM_CLIENT_TIME
// PARAM_LATITUDE
// PARAM_LONGITUDE
// PARAM_SESSION_UUID => UUID of session being closed
#define PARAM_SESSION_ACTIVE        @"cta"      // Active time in seconds (time app was active)
#define PARAM_SESSION_TOTAL         @"ctl"      // Total session length
#define PARAM_SESSION_SCREENFLOW    @"fl"       // Screens encountered during this session, in order

/*********************
 * Application Event *
 *********************/

// PARAM_UUID
// PARAM_DATA_TYPE => "e" for Event
// PARAM_CLIENT_TIME
// PARAM_LATITUDE
// PARAM_LONGITUDE
// PARAM_SESSION_UUID => UUID of session event occured in
// PARAM_ATTRIBUTES => dictionary containing attributes for this event as key-value string pairs
#define PARAM_EVENT_NAME            @"n"        // Event Name, (eg. 'Button Click')
#define PARAM_REPORT_ATTRIBUTES     @"rattrs"   // Attributes used in custom reports
#define PARAM_VALUE_NAME            @"v"        // Added customer value for an event, such as revenue

/********************
 * Application flow *
 ********************/

// PARAM_UUID
// PARAM_DATA_TYPE => "f" for Flow
// PARAM_CLIENT_TIME
#define PARAM_SESSION_START         @"ss"   // Start time for the current session.
#define PARAM_NEW_FLOW_EVENTS       @"nw"   // Events and screens encountered during this session that have NOT been staged for upload.
#define PARAM_OLD_FLOW_EVENTS       @"od"   // Events and screens encountered during this session that HAVE been staged for upload.

/************************
 * Partner attributions *
 ***********************/
#define FB_ATTRIBUTION              @"fb_attrib_first"          // Facebook attribution cookie
#define FB_ATTRIBUTION_TIME         @"fb_attrib_first_date"     // Time original attribution cookie was collected
#define FB_ATTRIBUTION_CURRENT      @"fb_attrib_current"        // Facebook attribution cookie
#define FB_ATTRIBUTION_CURRENT_TIME @"fb_attrib_current_date"   // Time original attribution cookie was collected
#define FB_DEVICE_ID                @"dpid"                     // Device unique identifiers
#define FB_DEVICE_ID_TYPE           @"dpid_type"                // Either UDID or ADID (advertisingIdentifier)
#define FB_INSTALL_ID               @"install_id"               // Device install ID



