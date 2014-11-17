3DS_Banner_Maker
================
Create custom banner and icon files for your 3ds homebrews.
This is an improved version of SnailFace's Banner Maker! It has many usefull changes:
- "py" not found fixed!
- A lot of user friendly popups!
- Auto cleans old files before building!
- Added a Clean.bat file in order to quickly clean!
- It automatically converts outputted files to *.bin!
- All-In-One bat file: you run it and it does everything!

How to use:
===============
-To replace icons: overwrite the .png in the either one of the 'ctpk' folders and click convert.bat to convert the images.
 Make sure image dimensions are the same as the folder indicates.

-To replace the banner: In the cbmd_banner folder, you have to overwrite the 256x128.png file with an image of your choice. 
 Click convert.bat same as before. Transparency is supported.

-To replace the sound effect: Overwrite the example.bcwav file with one of your choice. .wav to bcwav conversion is not supported at this time.

-To change display text and setting flags: edit the variables in AppData.txt. Further instructions are inside this document.

-To convert everything to .bin files: simply click BUILD.bat in the 3DS_Banner_Maker folder. 
 Next place place these two files in your 3DSTemplate resource folder and compile as usual.


Dependencies:
=============
Python 2, PIL Image libray (Python Image Library)
Xcution's CiTRUS application is no longer a dependancy.


Credits:
=============
AlbertoSONIC(me)
Snailface @ Gbatemp.net


License (Snailface)
================
Copyright (c) 2013, Snailface
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice,
  this list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.
* Neither the name of the darm developer(s) nor the names of its
  contributors may be used to endorse or promote products derived from this
  software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
POSSIBILITY OF SUCH DAMAGE.
