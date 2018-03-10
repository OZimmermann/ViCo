# ViCo
Interactive Media Design Project by Isabel Gaubatz, Romina Marsico, Olga Zimmermann
Hochschule Darmstadt
Fachbereich Media </br>

## Helpful Links

### How to Git in Unity

https://robots.thoughtbot.com/how-to-git-with-unity
For development you need to install this: https://git-lfs.github.com/ </br>

### HoloLens Emulator

https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools
https://developer.microsoft.com/en-us/windows/mixed-reality/using_the_hololens_emulator </br>

### Windows Mixed Reality Tutorials

https://developer.microsoft.com/en-us/windows/mixed-reality/holograms_100
https://developer.microsoft.com/en-us/windows/mixed-reality/holograms_101 </br>

### Holotoolkit

This project is using an old version (Holotoolkit) of MixedRealityToolkit-Unity
https://github.com/Microsoft/MixedRealityToolkit-Unity

## Requirements

- Windows 10 including Fall Creators Update
- Unity (we used Version 2017.3.1)
- Visual Studio
- HoloLens Device or HoloLens Emulator
- if you're using HoloLens Emulator you also need a microphone (e.g headset, webcam)

## Build (Windows 10 OS only!)

- build project with following settings
	- switch platform to **Universal Windows Platform**
	- set SDK to **Universal 10** or later
	- set Target Device to **HoloLens**
	- set Build Type to **D3D**
	- check **Unity C# Projects**
- by clicking on **Build** you'll build a Visual Studio Solution

## Deploy on HoloLens via USB

- open Visual Studio Solution
- set build mode to **Release, x86, Device**
- open Debug Menu and **start without debugging**

Application will start automatically.

## Deploy on HoloLens Emulator 

**Read helpful links for installing hololens emulator**

- open Visual Studio Solution
- set build mode to **Release, x86, HoloLens Emulator**
- open Debug Menu and **start without debugging**

Deploy takes some time. HoloLens emulator and application will start automatically.
