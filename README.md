# Toastify

This project is a fork of the original [aleab/Toastify](https://github.com/aleab/toastify) project, which has been archived by the owner on Feb 2, 2023. This fork is intended to keep the project alive and functional, and maybe add new features and improvements.

Another updated working version is available from  [IceyFL/Toastify](https://github.com/IceyFL/Fixed-Toastify)


[![GitHub last commit (master)](https://img.shields.io/github/last-commit/IGZmanuelMartinVivaldi/toastify/master.svg?label=Last%20Commit&maxAge=60)][commits]
[![GitHub release](https://img.shields.io/github/release/IGZmanuelMartinVivaldi/toastify.svg?label=Release&maxAge=60)][release-latest]
[![Github license](https://img.shields.io/badge/License-GPL%20v2-blue.svg?maxAge=86400)][license]

![toastify-showcase][toastify-showcase]

Toastify adds global hotkeys and toast notifications to Spotify.

This application uses [SpotifyAPI-NET][SpotifyAPI-NET].

## Features
* Display the current playing track in a customizable toast-style popup
* Global hotkeys for media actions (Play/Pause, Next/Previous track, Mute, Fast Forward, Rewind)
* :heavy_exclamation_mark: Compatible with the Microsoft Store version of Spotify

# THE ORIGINAL PROJECT WAS NO LONGER MAINTAINED
If you are looking for a replacement you can check out these other amazing projects:
- [AudioBand](https://github.com/AudioBand/AudioBand)
- [Lofi](https://github.com/dvx/lofi)

or use Spotify's own overlay on Windows (check out [this article](https://www.alphr.com/spotify-overlay-with-game-windows/)).


## Requirements
* Windows (11, 10, 8/8.1, 7)
* .NET Framework 4.8 or greater
* Spotify 


## Information for contributors
* The language version used to build the project is C# 7
* The solution requires Visual Studio 2022 (Visual Studio 2017 or Visual Studio Code, alternatively)
* Dependencies are not included. Use of NuGet is highly recommended.
* The repository has a git submodule; use `git submodule update --init --recursive` to initialize it.
* Several [NSIS plugins](https://nsis.sourceforge.io/Category:Plugins) are required to create the installer:
	* NSISpcre_plug-in
	* KillProc
	* DotNetChecker
	* ShellLink
	* ShellExecAsUser


## Requirements for Visual Studio 2022
* [.NET Framework 4.8 Developer Pack](https://aka.ms/msbuild/developerpacks)

## Building VS 2022

Updating version: [View/Terminal]
	`.\update-version.ps1`

Compile the project

The executable installer `ToastifyInstaller.exe` is available in the `\bin\AnyCPU\Release` path


## Building VS 2017

Updating version: [View/Other Windows/Package Manager Controller]
	`.\update-version.ps1`

Compile the project

The executable installer `ToastifyInstaller.exe` is available in the `\bin\AnyCPU\Release` path


## Additional requirements for Visual Studio Code (not tested)
[C# Dev Kit extension for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

Executing task: dotnet: build 



## Notices
* Toastify is **not** a Spotify **replacement**. You need both running at the same time.
* **Windows**: In the latest versions of Windows, SmartScreen will probably prevent the installer from starting, because it is not signed.  
  You have two options: either *Don't run* the installer and forget about Toastify, or click on *More info* and *Run anyway*.  
  Whatever is your choice, I strongly advise you to **not** disable Windows SmartScreen — its warnings are meaningful.  

  If you have any concerns, feel free to take a look at the code (it's free :wink:) and ask questions in the [issues][issues] section.
* If you are updating from the original version of Toastify (v1.8.3), be sure to uninstall it completely before installing this version. You should also remove any file from the following directories, if they exist:
  - *"%LocalAppData%\Toastify"* (for example: *"C:\Users\{UserName}\AppData\Local\Toastify"*)
  - *"%AppData%\Toastify"* (for example: *"C:\Users\\UserName}\AppData\Roaming\Toastify"*)

This version of Toastify use the configuration and log files found at these locations:
* Log: 		%LOCALAPPDATA%\Toastify\Toastify.log
* Config: 	%APPDATA%\Toastify\Toastify.cfg


## License
This software is licensed under the GNU GPL-2.0; the complete license text can be found [here][license].  
This repository is a fork of [aleab/toastify](https://github.com/aleab/toastify) that has been archived by the owner on Feb 2, 2023.
See also the [original project](https://github.com/nachmore/toastify) this repository is a fork of.

This project uses third-party libraries; their verbatim licenses can be found [here][license-3rdparty].


[//]: # (Links)

[toastify-showcase]: <https://raw.githubusercontent.com/aleab/toastify/gh-pages/img/toastify-showcase.png>
[license]: </LICENSE>
[license-3rdparty]: </LICENSE-3RD-PARTY>

[release-latest]: <https://github.com/IGZmanuelMartinVivaldi/toastify/releases/latest>
[commits]: <https://github.com/IGZmanuelMartinVivaldi/toastify/commits/master>
[issues]: <https://github.com/IGZmanuelMartinVivaldi/toastify/issues>

[aleab/toastify@github]: <https://github.com/aleab/toastify/>
[SpotifyAPI-NET]: <https://github.com/JohnnyCrazy/SpotifyAPI-NET>
