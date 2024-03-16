C:\IGZ\Proyectos\Personal\toastify2024\Toastify\bin\AnyCPU\Debug\Windows\net472
C:\IGZ\Proyectos\Personal\toastify2024\Toastify\bin\AnyCPU\Release\Windows\net472


* No lanza Spotify
C:\Users\manuel.martinvivaldi\AppData\Local\Microsoft\WindowsApps + Spotify.exe
%LOCALAPPDATA%\Microsoft\WindowsApps + Spotify.exe
C:\Program Files\WindowsApps\SpotifyAB.SpotifyMusic_1.233.1039.0_x64__zpdnekdrzrea0\Spotify.exe


??? Github
??? Github release (about)
??? Logs
C:\Users\manuel.martinvivaldi\AppData\Local\Toastify
C:\IGZ\Proyectos\Personal\toastify2024\Toastify\bin\AnyCPU\Debug\Windows\net472\log.log

??? Update libs


* Instalador
C:\IGZ\Proyectos\Personal\toastify2024\Toastify\bin\AnyCPU\Release\Windows\net472\ToastifyInstaller.exe
Install plugin
	https://nsis.sourceforge.io/NSISpcre_plug-in at C:\Program Files (x86)\NSIS\Plugins\x86-unicode
KillProc (rename)
DotNetChecker (unicode)
ShellLink
ShellExecAsUser



* Actualizar version:
	.\update-version.cmd




# Toastify

A fork of the original [aleab/Toastify](https://github.com/aleab/toastify) project, which has been archived by the owner on Feb 2, 2023. This fork is intended to keep the project alive and maintained, and maybe add new features and improvements.


[![Codacy grade](https://api.codacy.com/project/badge/Grade/dcbbd6b1f6cf45658a0f9232a5f35706)][aleab/toastify@codacy]
[![GitHub last commit (master)](https://img.shields.io/github/last-commit/aleab/toastify/master.svg?label=Last%20Commit&maxAge=60)][commits]
[![GitHub release](https://img.shields.io/github/release/aleab/toastify.svg?label=Release&maxAge=60)][release-latest]
[![Github license](https://img.shields.io/badge/License-GPL%20v2-blue.svg?maxAge=86400)][license]
[![Gitter](https://badges.gitter.im/aleab/toastify.svg)][aleab/toastify@gitter]

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
* .NET Framework 4.7.2 or greater
* Spotify

## Requirement for Visual Studio Code

C@ Dev Kit extension for Visual Studio Code: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp
.NET SDK 8.0.201: https://aka.ms/dotnet/download
.NET Framework 4.7.2 Developer Pack https://aka.ms/msbuild/developerpacks
  Toastify.csproj
.NET Framework 4.5.2 Developer Pack https://aka.ms/msbuild/developerpacks
  Toastify.Installer.csproj
  Toastify.Updater.csproj
git submodule update --init --recursive

## Building

Executing task: dotnet: build 



## Notices
* Toastify is **not** a Spotify **replacement**. You need both running at the same time.
* **Windows 10**: In the latest versions of Windows, SmartScreen will probably prevent the installer from starting, because it is not signed.  
  You have two options: either *Don't run* the installer and forget about Toastify, or click on *More info* and *Run anyway*.  
  Whatever is your choice, I strongly advise you to **not** disable Windows SmartScreen — its warnings are meaningful.  

  If you have any concerns, feel free to take a look at the code (it's free :wink:) and ask questions in the [issues][issues] section.
* If you are updating from the original version of Toastify (v1.8.3), be sure to uninstall it completely before installing this version. You should also remove any file from the following directories, if they exist:
  - *"%LocalAppData%\Toastify"* (for example: *"C:\Users\\{UserName}\AppData\Local\Toastify"*)
  - *"%AppData%\Toastify"* (for example: *"C:\Users\\{UserName}\AppData\Roaming\Toastify"*)

## Information for contributors
* The language version used to build the project is C# 7
* The solution requires Visual Studio 2017 (or Visual Studio Code, alternatively)
* Dependencies are not included. Use of NuGet is highly recommended.
* The repository has a git submodule; use `git submodule update --init --recursive` to initialize it.


## License
This software is licensed under the GNU GPL-2.0; the complete license text can be found [here][license].  
This repository is a fork of [aleab/toastify](https://github.com/aleab/toastify) that has been archived by the owner on Feb 2, 2023. See also the [original project](https://github.com/nachmore/toastify) this repository is a fork of, and its old [codeplex page][toastify@codeplex].

This project uses third-party libraries; their verbatim licenses can be found [here][license-3rdparty].


[//]: # (Links)

[toastify-showcase]: <https://raw.githubusercontent.com/aleab/toastify/gh-pages/img/toastify-showcase.png>
[license]: </LICENSE>
[license-3rdparty]: </LICENSE-3RD-PARTY>

[release-latest]: <https://github.com/IGZmanuelMartinVivaldi/toastify/releases/latest>
[commits]: <https://github.com/IGZmanuelMartinVivaldi/toastify/commits/master>
[issues]: <https://github.com/IGZmanuelMartinVivaldi/toastify/issues>

[aleab/toastify@github]: <https://github.com/aleab/toastify/>
[aleab/toastify@codacy]: <https://www.codacy.com/app/aleab/toastify>
[aleab/toastify@gitter]: <https://gitter.im/aleab-toastify>
[SpotifyAPI-NET]: <https://github.com/JohnnyCrazy/SpotifyAPI-NET>
[toastify@codeplex]: <http://toastify.codeplex.com/>
