# ECM - EasyConsoleMenu
This is the sourcecode for the ECM - Easy Menu System NuGet Package, which helps with creating an easy Menu in your console application.
Also included is an ```Example.cs``` that showcases how to use the package in a project.

## Usage
To use ECM install the NuGet-Package and make sure their is a ```using ECMPackage;``` added in your using-directives.
To start make a new instance of ECM in your class, like this: ```static ECM ecm = new ECM();```
The menu is running in a while-loop, so it will always show once a function is finished and the program is still running.
Color and other formatting are applied from the overarching console (your code).

### Adding Options
To add options to the menu, define the input needed from the user and the function to be called by it use ```ecm.Items.Add(new ECMItem(1, "First Option", Option1));```

```ecm``` is the name of you gave the instance of ECM you defined in your class (see above).

```.Items``` is the list that stores every option and its corresponding information.

```.Add()``` keyword to add a new entry to a list

```(new ECMItem())``` defines a new instance of an ECMItem, an option and its corresponding information

```(1, *, *)``` is the number the user needs to input in order to invoke the option. It should be corresponding to its position in the list, so the firs item should be 1, because its going to be titled as ```1. ``` by the menu, second as 2, since its going to be ```2. ``` and so on.

```(*,"First Option",*)``` is any string you want as a name to be displayed in the menu.

```(*,*, Option1)``` is the name of the function you want to call when the option is invoked.
