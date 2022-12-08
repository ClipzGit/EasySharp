# EasySharp
Standard C# functions made Easy.
This is a class Lib that can be used by those who would like to write to the console or store data faster eliminating headache causing tasks by the Standard **Console** functions. 

## Features 
> `EasySharp.Title` | Set the title or loop 3 other titles

> Parameters : text (string), loop_titles (bool), title_one (string), title_two (string), title_three (string)

**Example:**
```
// Normal Title
EasySharp.Title("Hello World!"); 

// Looping Titles
EasySharp.Title("Hello World", true, "First Loop", "Second Loop", "Third Loop")
```

> `EasySharp.WriteLine` | Write basic line or 'true' for underlined effect (Default underlined icon is "=")

> Parameters : text (string), underlined (bool), underline_icon (char)

**Example:**
```
// Without Underline
EasySharp.WriteLine("Hello World");

// With Underline
EasySharp.WriteLine("Hello World", true);

// With Underline + Custom Underline Icon
EasySharp.WriteLine("Hello World", true, '-');
```


> `EasySharp.WriteColoredLine` | Write a colored line with text color and option for underlined effect

> Parameters : text (string), color (ConsoleColor), underlined (bool), underline_icon (char)

**Example:**
```
// With Colored Text
EasySharp.WriteColoredLine("Hello World", ConsoleColor.Blue, false);

// With Colored Text + Underline
EasySharp.WriteColoredLine("Hello World", ConsoleColor.Blue, true);
```
