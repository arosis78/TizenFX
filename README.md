# TizenFX

[![License](https://img.shields.io/badge/licence-Apache%202.0-brightgreen.svg?style=flat)](LICENSE)
[![BuildStatus](https://travis-ci.org/Samsung/TizenFX.svg?branch=master)](https://travis-ci.org/Samsung/TizenFX)

TizenFX API, which allows you to access platform-specific features not covered by the generic .NET and Xamarin.Forms features, such as system information and status, battery status, sensor date, and account and connectivity services.

## Contents
> [Branches of TizenFX](#branches)  
> [Quick Start](#quick-start)  
> [Tizen Project](#tizen-project)

## Branches

| branch | API level | platform          | pre-release | stable |
|--------|:---------:|-------------------|-------------|--------|
|master  | 5         | Tizen vNext (5.0) | [![api5_myget](https://img.shields.io/tizen.myget/dotnet/vpre/Tizen.NET.API5.svg)](https://tizen.myget.org/feed/dotnet/package/nuget/Tizen.NET) | |
|API4    | 4         | Tizen 4.0         | [![api4_myget](https://img.shields.io/tizen.myget/dotnet/vpre/Tizen.NET.API4.svg)](https://tizen.myget.org/feed/dotnet/package/nuget/Tizen.NET) | [![api4_nuget](https://img.shields.io/nuget/v/Tizen.NET.svg)](https://www.nuget.org/packages/Tizen.NET/) |

### master
The __master__ branch is the main development branch for the Tizen .NET __API Level 5__.

The following NuGet packages will be published to [Tizen MyGet Gallery](https://tizen.myget.org/gallery/dotnet) every day if there are any changes. (Nightly Build) 
* Tizen.NET-5.0.0-preview#-#####
* Tizen.NET.API5-5.0.0-preview#-#####
* Tizen.NET.Internals-5.0.0.#####

And, This branch is pushed to the [tizen branch](https://git.tizen.org/cgit/platform/core/csapi/tizenfx/?h=tizen) in the tizen gerrit and submmited for the Tizen vNext (5.0) platform.

### API4
The __API4__ branch is the release branch for Tizen .NET __API Level 4__. 

The API Level 4 was __FROZEN__. No new public APIs can be added to this branch, only bug fixes and internal APIs can be added.

The following NuGet packages are published to [Tizen MyGet Gallery](https://tizen.myget.org/gallery/dotnet) on demand.
* Tizen.NET-4.0.1-preview#-#####
* Tizen.NET.API4-4.0.1-preview#-#####
* Tizen.NET.Internals-4.0.1.#####

And, This branch is pushed to the [tizen_4.0 branch](https://git.tizen.org/cgit/platform/core/csapi/tizenfx/?h=tizen_4.0) in the tizen gerrit and submmited for the Tizen 4.0 platform.



## Quick Start
### Getting the sources
```bash
git clone https://github.com/Samsung/TizenFX.git
cd TizenFX
```
### How to build
```bash
./build.sh full
./build.sh pack 
```


## Tizen Project
TizenFX is a part of the [Tizen project](https://www.tizen.org) and has been officially included since [4.0 M2 release](https://www.tizen.org/blogs/tsg/2017/tizen-4.0-m2-source-code-release).  
You can download the latest binaries with TizenFX from the link below :  

| Tizen Version     | Link |
|-------------------|------|
| Tizen 4.0         | http://download.tizen.org/snapshots/tizen/4.0-unified/latest/ |
| Tizen vNext (5.0) | http://download.tizen.org/snapshots/tizen/unified/latest/ |


















