# LMUTools

A little project to make myself easy to use Le Mans ultimate
- Replay: 
browse, load replay files, combined with result xml file to jump to a driver on a certain moment in the session. Use the right/left mouse button in the listview to select and jump to the moment on track for that driver.
speed controller

We use the rest API of Le Mans Ultimate.
Made with Visual Studio Community 2022.
You'll probably need to install .NET Desktop Runtime 8 (https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

![image](https://github.com/JeGoBE8900/LMUTools/assets/168869412/e9301375-88a6-45d2-b46c-584aa5927d77)

Latest change:
- A bigfix reported by a user (0.1.0)
- Added possibility to load tracelog file for penalty, track limit, ... events (0.1.0)
- Made the tool work with LMU release of 10/6/2025 - 0.9.

What is not (yet) implemented:
- Changing views is possible, but use keymaps for zoom in/out (cockpit, swingman, trackside, ...)

Known issues:
- Can causes freezes while driving and the tool is polling the rest API

To support this tool, https://www.paypal.com/donate/?hosted_button_id=XKHD6S28ZUPKC
