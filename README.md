console-toast-8
===============
An application for displaying widnows 8 notifications from the command line.

- Supports:
    - All templates
    - Custom shortcut icon (instead of the default which appears on the toast)
    - Silent toasts

A list of templates can be found [here](http://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.notifications.toasttemplatetype).
Images must be <200kb and <1024px square.
Shortcut icons are suggested to be 32x32 for 100% DPI, as larger sizes do not scale down well.
    
Switches are listed in Program.cs. The app_id switch value is used to name the shortcut which will appear on the user's Start screen containing an icon.

The only external reference you need is the [Windows API Code Pack](http://archive.msdn.microsoft.com/WindowsAPICodePack). Note you may need to extract the exe manually.

License
=======
Public domain, do whatever you want.