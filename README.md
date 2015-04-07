# AdDuplexUnitySample
Sample Unity3d 5 project and its Windows Phone 8 build using AdDuplex Interstitial Ads. 

For more information refer to [blog.adduplex.com](blog.adduplex.com "blog.adduplex.com")

Unity3d project is using a public static Interop class to make bridge between Unity3d scripts and generated code. It contains a Unity2d project and a Windows Phone 8 project built from it.

The Unity2d game consists of a Controller scrip that is attached to the camera and a static Interop class. Controller waits for a mouse (or touch when on appropriate device) to raise a ShowInterstitial event in the Interop class. Windows Phone 8 build is edited to subscribe to that event (along with LoadInterstitial) and show an interstitial ad when it is raised(refer to [https://adduplex.zendesk.com/hc/en-us/articles/202434291-Windows-Phone-Silverlight-AdDuplex-Interstitial-Ad-Installation-and-Usage](https://adduplex.zendesk.com/hc/en-us/articles/202434291-Windows-Phone-Silverlight-AdDuplex-Interstitial-Ad-Installation-and-Usage "Windows Phone Silverlight AdDuplex Interstitial Ad Installation and Usage") for more information)

