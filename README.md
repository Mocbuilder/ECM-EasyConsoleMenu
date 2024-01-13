# ECM - EasyConsoleMenu
This is the sourcecode for the ECM - Easy Menu System NuGet Package, which helps with creating an easy Menu in your console application.

# Usage
To use ECM install the NuGet-Package and make sure their is a ```using ECMPackage;``` added in your using-directives.
To start make a new instance of ECM in your class, like this: ```static ECM ecm = new ECM();```
ECM is based on a combination of a Ditionary called ECMActions and a List called ECMItems.

### Adding Option Names
The List handles the strings of names that will be displayed to the user, and add names with ```ecm.ECMItems.Add("YourOptionName");```
Unfortunately C# does not provide an easy way to add multiple entrys to a List at once, so you will either have to make multiple ```ecm.ECMItems.Add("YourOptionName");``` calls in your code, or find another workaround that works for you.

### Adding Option Functionality
The program automatically displays an Index before the Option Names, like this:
```
1. First Option Name
2. Second Option Name
3. Option Name
Your choice:
```
The user enters a number, and a method is executed. You set the method according to the input, like this: ```ecm.ECMActions.Add(1, Option1);```
```1``` can be any number, it is what the user needs to input to activate the method ```Option1``` in my example, but it is corresponding to any name of a method or action in your code.
To display the menu, call the method ```ECMDisplay```