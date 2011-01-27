SOURCES = \
	localytics.cs

all: monotouch-localytics.dll
debug: monotouch-localytics-debug.dll	

monotouch-localytics.dll: $(SOURCES)
	/Developer/MonoTouch/usr/bin/btouch -out=monotouch-localytics.dll localytics.cs
monotouch-localytics-debug.dll: $(SOURCES)
	/Developer/MonoTouch/usr/bin/btouch -v --debug -outdir=/tmp -out=monotouch-localytics.dll localytics.cs
