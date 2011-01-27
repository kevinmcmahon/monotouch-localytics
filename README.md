Monotouch bindings for the Localytics iOS SDK
===========================================

You can get the Localytics iOS code from their [website](http://wiki.localytics.com/doku.php?id=iphone_ios4_integration).

Adding this lib to your project
-------------------------------

- Copy libLocalytics.a to the root of your proj
- In your MonoTouch project options > iPhone Build
    - Set Linker behavior to "Link SDK assemblies only"
    - Set the Extra arguments in all iPhone Build configurations to:

          -v -gcc_flags "-L${ProjectDir} -lLocalytics-fat -framework CoreGraphics -force_load ${ProjectDir}/libLocalytics-fat.a"
      
      This includes build configs for Debug and Release versions of iPhone and iPhoneSimulator configs.