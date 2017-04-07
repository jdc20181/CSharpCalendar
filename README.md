# CSharpCalendarControl
The VBNetCalendar for C# users

# NOT Ready for use

I am coverting this directly from the Original code. Which was in vb.net some things aren't convertable, so it will take extra time to add. 

# License 

Licensed under [MIT](https://github.com/jdc20181/CSharpCalendar/blob/master/LICENSE)

Please review license file before using, you need to include the license and my name in a abouts/credits page in your application. 


# Setup

To make it work you need this on Form Load, please add the controlname accodingly.

`CalV1X.ReloadCal(Date.Today, Date.Today.Day);`


# Code Conversion - CSharp OverView

Currently I am manually sifting through the wreckage of a bad conversion. I do not know C# entirely so it is taking a little time to do what is neccessary to make it work properly. 

Meanwhile, you can still use the VB.net version, just use the DLL in the latest release. 

Initializing was edited above that code also didn't convert right, and so the code that is there now, works fine. 

You can make use of the converted code in the `source` folder, however, there is the work that I need to do that isn't there yet. 

The biggest change was a removal of a statement. That statement ignored errors and went on, which isn't supported in C# the orignal code author, did this, and I didn't change but a tiny 1% of the code during the intial release process. 


# VB.NET Version 

This is My project, the orignal Code is in vb.net, and isn't my code, I only have adapted it, and am modifying it as it progresses. 

See the [VBNetCalendar](https://github.com/jdc20181/VBNetCalendar) Respo for more info.
