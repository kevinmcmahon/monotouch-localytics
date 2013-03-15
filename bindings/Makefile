XBUILD=/usr/bin/xcodebuild
PROJECT_ROOT=../Localytics-v2.16.1-src/Localytics
PROJECT=$(PROJECT_ROOT)/Localytics.xcodeproj
TARGET=Localytics
BUILD_FLAGS=-unsafe -target:library -nowarn:436 -nowarn:219
BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs

all: monotouch-localytics.dll

debug: monotouch-localytics-debug.dll	

libLocalytics-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/libLocalytics.a $@

libLocalytics-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/libLocalytics.a $@

libLocalytics-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/libLocalytics.a $@

libLocalytics-fat.a: libLocalytics-i386.a libLocalytics-armv7.a libLocalytics-armv7s.a
	lipo -create -output $@ $^

monotouch-localytics.dll: localytics.cs AssemblyInfo.cs libLocalytics-fat.a
	$(BTOUCH) --out=$@ -e localytics.cs AssemblyInfo.cs --link-with=libLocalytics-fat.a,libLocalytics-fat.a

monotouch-localytics-debug.dll: localytics.cs AssemblyInfo.cs libLocalytics-fat.a
	/Developer/MonoTouch/usr/bin/btouch -v --debug -outdir=/tmp -e localytics.cs AssemblyInfo.cs --out=$@ --link-with=libLocalytics-fat.a,libLocalytics-fat.a

clean:
	-rm -f *.a *.dll
