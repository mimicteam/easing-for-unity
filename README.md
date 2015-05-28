# Easing for Unity

A dead simple single-class implementation of [Robert Penner's](http://robertpenner.com/easing/) easing functions for the Unity Engine. 

## Usage

All easing code is in [Easing.cs](Assets\\Easing.cs), so feel free to just copy paste this file into your project. 

You can call easing functions by name or by enum.

We're using enums over delegates because Unity serialization supports enums, so you can expose them in the editor and save them as part of a scene.

Enjoy!

## License

Open source under the [MIT and BSD Licenses](LICENSE.md).
