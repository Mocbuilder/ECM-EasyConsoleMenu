# ECM - EasyConsoleMenu
This is the sourcecode for the ECM - Easy Menu System NuGet Package, which helps with creating an easy Menu in your console application.

## Usage
To use ECM install the NuGet-Package and nake sure their is a ```using ECMPackage;``` added in your using-directives.
ECM is based on a combination of a Ditionary called ECMActions and a List called ECMItems. The List handles the strings of names that will be displayed to the user, and add names with ```ecm.ECMItems.Add("YourOptionName");```