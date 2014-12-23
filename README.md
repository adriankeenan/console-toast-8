# console-toast-8

An application for displaying Widnows 8 notifications from the command line.

- Supports:
    - All templates supported by the Windows 8 Toast API
    - Custom shortcut icon (instead of the default which appears on the toast)
    - Silent toasts

A list of templates can be found [here](http://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.notifications.toasttemplatetype).

## Caveats

Any application which shows a toast notification in Windows 8 needs to be added to the Start menu, including this process. It may be possible to remove the shortcut after showing the toast thoguh, that functionality is not included in this tool.

## Usage

- Launch the exe at ```console-toast-8\bin\Debug``` or add to your PATH
- Switches
	- Use ``--template`` to specifify a template, then use further switches to specify the data
		- Options
			- ToastImageAndText01
				- line1
				- img
			- ToastImageAndText02
				- title
				- line1
				- img
			- ToastImageAndText03
				- title
				- line1
				- img
			- ToastImageAndText04
				- title
				- line1
				- line2
				- img
			- ToastText01
				- line1
			- ToastText02
				- title
				- line1
			- ToastText03
				- title
				- line1
			- ToastText04
				- title
				- line1
				- line2
		- images for ImageAndTest toasts must be <200kb and <1024px square
	- ```--app_id``` Specifies the name that appears in the start menu
		- default: console-toast-8
	- ```--icon``` Path to a .ico icon to display in the toast
		- Shortcut icons are suggested to be 32x32 for 100% DPI, as larger sizes do not scale down well
	- ```--silent``` Makes the toast silent

## Binary

The binary can by found in bin/debug.

You only need the .exe and .dll files.

## License

Public domain, do whatever you want.