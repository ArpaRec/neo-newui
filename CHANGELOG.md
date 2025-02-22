# GameVault App Changelog

## 1.8.0
Recommended Gamevault Server Version: `v10.0.0`
### Changes
-Installation tab has been integrated into the Library tab
-Graphic overhaul of the Library
-Graphic overhaul of the GameView
-New user interface for Game Settings and User Settings
-All text icons have been replaced with graphic icons
-Added optional User Message to the Crash Report Window
-Added Game Launch Parameter
-Games can now be started and downloaded from the Library and the GameView
-Progresses from other users are displayed in the GameView

## 1.7.3
Recommended Gamevault Server Version: `v9.0.0`
### Changes
- Switched to non-deprecated APIs
- Bug fix: Rare case in the time tracker where a game was not recognized as a game

## 1.7.2
### Changes
- Bug fix: The installer executable selection list gave an error if there was an executable file with the same name in one of the subfolders

## 1.7.1
### Changes
- Current server version is now displayed in the Admin Console. Additionally a message is displayed when the server is outdated
- Bug fix: Error when selecting script as installer in the Download Tab
- Bug fix: Current selected executable turned Blank after open the executable dropdown in the Installation Tab

## 1.7.0
### Changes
- Added support for more executable files in the download tab
- When you remove the download, the installation folder will be deleted automatically if it is empty
- Added Refresh button to Admin Console
- Added desktop shortcut creation button to install tab
- Added Databse Backup-Restore functionality to the admin console
- Bug fix: Auto extraction sometimes failed
- Bug fix: The executable selection sometimes did not respond correctly to the mouse input
- Bug fix: The One Instance functionality was incorrectly executed after the update check
- Bug fix: Problems in the installation Tab when uninstall->reinstall Games
- Bug fix: New users do not show on the community tab without client restart
- Bug fix: Last selected user is not refreshed, when entering the community tab
- Bug fix: Added a few more safeties in the offline cache

## 1.6.2
### Changes
- Bug fix: Update Notification for non Microsoft Store Version was shown in the Microsoft Store Version
- Bug fix: Error while setting the installation path to Clipboard

## 1.6.1
### Changes
- Admins can delete user progress
- Bug fix: Setup games were not uninstalled correctly
- Bug fix: Users could start a download in offline mode
- Bug fix: When changing the role of a user, the user was deactivated
- Bug fix: Progress for deleted games are now displayed. Also added validation for this in the game view

## 1.6.0
### Changes
- Faster Rawg search in the game view
- More detailed error messages when downloading
- Added support for more executable files
- Added get random game button to library
- Added new Exception Window where you can choose whether to send a crash report or not
- Show certain data in the gameview only if they are available
- Update Notification for new Versions in the non Microsoft Store Releases
- Check for offline cache integrity
- Uninstall games
- Bug fix: Crash if you navigate to Settings/Data and never downloaded a game before
- Bug fix: Image was requested although an invalid image id was specified
- Bug fix: Game Title was also not displayed when the Release Date was not set
- Bug fix: Could not navigate to errorlog on Microsoft Store version

## 1.5.0
### Changes
- Reorganized settings tab
- "Auto-Extract Downloaded Games" option added to settings
- Image cache and offline cache size is displayed in settings
- Added Logout option to settings
- Added Download Limit to settings
- Added re-index button to Admin Console
- Email, First Name, and Last Name are not mandatory for registration anymore
- Download progress is now displayed in the taskbar
- It is now possible to upload images from the client 

## 1.4.1
### Changes
- Bug fix: Image optimization was skipped if it was not a Microsoft store version
- Bug fix: System tray icon was still visible after closing the application until hovering over it with the mouse
- Bug fix: Incompatible request header for download in server version 3. Fallback included for downloading regardless.

## 1.4.0
### Changes
- In case of an unhandled exception, you can now navigate directly to the error logs
- In the admin console, you can now jump directly to the profiles
- Support single file binary
- The selectable executables are now trimmed in the installation tab
- Enter key on forms now submits forms
- Bug fix: Dealing with undetected game types in the installation process
- Bug fix: A long error message in the download tab, no longer rescales the individual elements
- Bug fix: Download speed not shown, when it's KB/s and below 

## 1.3.0
### Changes
- Installation pipeline implemented. The UI for the download tab has been completely overhauled. GameVault is now able to extract downloaded game archives and perform the installation process depending on the game type.
- Added new game types filter in the library
- Bug fix: The box images were cut off in the Library tab. The format has now been changed to 2:3, so that you can always see the whole image.
- Bug fix: The box image titles in the library tab now have a wrap, so that even longer titles are readable
- The "App is still running in the system tray" message will now only be displayed once per installation
- Other UI changes especially in terms of spacing and round corners
- Bug fix: When re-loading a user in the community tab, the filter was not sorting the progresses correctly afterwards

## 1.2.1
### Changes
- Autostart fix (For self build and Microsoft Store)

## 1.2.0
### Changes
- Renamed Crackpipe to Gamevault
- Automatic migration of existing data

## 1.1.0
### Changes
- Show asterisks in registration password fields instead of clear text
- Notify user, when app is still running in the system tray
- Show mapped RAWG Game Title as Tooltip when you hover over game name on game view
- Make Images optional for registration
- Rework Playtime UI in Game View
- Auto load library as default in the settings

## 1.0.1
### Changes
- Bug fix: When registering a new user, the message "Each field must be filled" was displayed, although all fields were set.

## 1.0.0
### Changes
- Initial Release
