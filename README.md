
englishauction
==============

Contents
========

* [About](#about)
* [Requirements](#requirements)
* [Installation](#installation)
* [Configuration](#configuration)
* [Usage](#usage)
* [Licensing](#licensing)
* [Support](#support)

# About
A Timed Auction library starting at a low price and increasing until the auction ends.

# Requirements
Visual Studio Build Tools
Haxe 4.1.1
Neko
hxcs Haxelib
nuget


Third-party dependencies may have additional requirements.

# Installation
nuget ...


# Configuration
You must configure the storage and retrieval of auctions and bids. Before we can make use of englishauction's functions, we have to create Callback functions for englishauction to use whenever it needs to use any persistent data regarding auctions and bids. A common way of storing persistent data is using SQL. Each setup function bridges the gap between your auction data and the englishauction package's functionality.

# Usage
You are using C#


More examples to come

# Licensing
Additional [licensing options][licensing] are available.

# Support
For bug fixes, please raise an issue in the [Issue Tracker][bugs].

For feature requests, and general support, please [Contact us][contact].



[bugs]: https://github.com/mindpowered/english-auction-csharp/issues
[contact]: https://mindpowered.dev/support.html?ref=english-auction-csharp/
[docs]: https://mindpowered.github.io/english-auction-csharp/
[licensing]: https://mindpowered.dev/?ref=english-auction-csharp
