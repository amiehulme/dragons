Created in Visual Studio Community 2022
WPF Application, Windows 11
Target Framework: net6.0-windows
Target Runtime: win-x64 

Visual Studio .sln file located in Dragons folder
code files located in Dragons/Dragons folder


RUNNING THE PROGRAM:

I published the .exe file as Framework-Dependent. The Self-Contained publish was generating a file that was over 100MB.

The .exe can be found in the following folder:
release/framework-dependent/Dragons.exe 


NOTES:

For a cleaner UI, I opted to only display the modified ability score values if the value was actually modified. So for Gnome and Human, you will not see any Modified values.


KNOWN ISSUES:

- The Character list does not keep the blue highlight on the selected item when it loses focus. This is apparent when the Play button is pressed, and on initial launch of the application. I attempted creating a custom Style for the ListViewItem but was not able to get it working in time.



FUTURE IMPROVEMENTS:

- Store the Character data in a JSON file, and load it up that way.
- Custom UserControl for character entry, ability score entry 
- Add Tooltips (despite setting one on the Play button, it never shows up. Would want to debug this, and add more tooltips elsewhere)
- Fix Highlight on initial selected entry in Character list