AutoTick
========

Screenshot

See more in video

## What is it?

PhewTick is an application which rewards users with points for scanning the QR code of another user when meeting them in real life. These points - after having been accumulated - can be exchanged for money that is sent to a PayPal account. On a purely speculative note, I believe that they have incentive to report user location and city data to advertising agencies to provide users with 'relevant' ads; simply passing a small dividend over to the end user.

AutoTick is a bot that scans your friend's QR codes automatically without you having to actually meet them. AutoTick does NOT circumvent any time limits or otherwise exploit the systems to generate you insane amounts of cash. Whatever AutoTick earns can be done by manually scanning your friends' codes, however removing the physical necessity of doing so.

## How are meetups done?

We will have two people in this scenario: 

A: Friend 
B: You

1. Update location of both you and friend to lat/long on map screen
2. Fetch friend data from RESTful APIs, use their token to retrieve QR key. `getData()`
3. POST friend's QR key and YOUR token to PhewTick API. `doScan()`
4. GET server response (shows points earned) and update statistics
5. Sleep for time defined in settings


## What are these 'tails' in your settings pane?

While PhewTick was still operational, they were changing domains and URL locations around with very high frequency to the point where it was better to include a setting to let the user change the URLs whenever PhewTick would rearrange their stuff.

Below, is a PhewTick API URL:

`https://v5api.phewtick.com/users/scan`

*`https://v5api.phewtick.com/` is the domain
* `meets/scan` is the location of the API that recieves scan requests.

### Known PhewTick services:

* `users/position` is used for updating user location. It takes user token, latitude, and longitude as arguments.
* `meets/scan` is used for doing a meetup. It takes the token of the friend scanning the other friend's phone and the other friend's QR key. There are some metrics for position which could be submitted with a scan request, but I do not know what they do
* `meets/qr` is used for generating QR keys if a token is provided.

## Tokens. Huh?

Each PhewTick user is given a secret key. Once you register for PhewTick through Facebook (I do not remember if this is the procedure exactly, do not quote me on registration method), you are assigned one unique token per device used. These tokens stay with the device, but new tokens are generated if devices change.

### Odd occurences

Tokens may or may not deprecate when a new device is 'provisioned'. I do not know why this happens selectively.
Tokens may be changed for you at random. I do not know why this happens either.

### How do I find my token?

There is nowhere within the PhewTick application where you may retrieve your token. In order to do this, you must sniff the connection of the device with something like `mitmproxy`.

#### Using `mitmproxy`

1. Start the mitmproxy daemon by typing `mitmproxy`.
2. Connect your phone/tablet/toaster to the same network as the mitmproxy daemon, and assign the appropriate ports to the device. MAKE SURE THAT YOU IMPORT THE MITMPROXY CERTIFICATES INTO THE DEVICE IN QUESTION OR IT WILL NOT CONNECT.
3. Refresh your QR code and you'll see packets appear that are headed towards the PhewTick API URLs.
4. Open up the detailed view of one of these packets and copy the &token= argument. Yay, token!

#### Not using mitmproxy

* Don't know. Figure out how to use mitmproxy, it's easier.


## This is sweet! Can I use it?

Of course! You are allowed to modify and redistribute this code as long as you give original credit. I hope you learn from this and share it. Knowledge is power. Also, no commercial usage, please!

This software is bound by the Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
