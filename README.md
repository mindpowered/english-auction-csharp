
englishauction
==============
Online auctions with ascending price and time limit

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [About](#about)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)
* [Licensing](#licensing)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/english-auction-csharp](https://github.com/mindpowered/english-auction-csharp)
- Documentation: [https://mindpowered.github.io/english-auction-csharp](https://mindpowered.github.io/english-auction-csharp)

# About
An English auction is the most common form of auction. When an auction opens, the price starts low and increases as buyers bid for the item. Live auctions usually end when there is no new highest bid for a period of time. For online auctions, an end time is usually set. To prevent items selling for a loss, sometimes the seller will place a reserve. A reserve is the least amount to sell the item for, although the auction may start at a lower price. Another common feature of online auctions is the ability to pay a set price to win and end the auction.

This package aims to provide functionality of online English auctions.

# Requirements
## To import pre-compiled library
- nuget

## To build from source
- Visual Studio Build Tools
- Haxe 4.1.1
- Neko
- hxcs Haxelib
- nuget


Third-party dependencies may have additional requirements.

# Installation

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.englishauction" Version="0.0.64" />
```


# Usage

```csharp
global::mindpowered.englishauction.EnglishAuction ea = new global::mindpowered.englishauction.EnglishAuction();
ea.GetOpenAuctions(0, 10, "start", true);

```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.

# Licensing
This package is released under the MIT License.



[bugs]: https://github.com/mindpowered/english-auction-csharp/issues
[contact]: https://mindpowered.dev/support/?ref=english-auction-csharp/
[docs]: https://mindpowered.github.io/english-auction-csharp/
[licensing]: https://mindpowered.dev/?ref=english-auction-csharp
[purchase]: https://mindpowered.dev/purchase/
