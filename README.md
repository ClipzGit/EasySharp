# EasySharp
Standard C# functions made Easy.
This is a class Lib that can be used by those who would like to write to the console or store data faster eliminating headache causing tasks by the Standard **Console** functions. 

## Features 
### Title 
> `EasySharp.Title` | Set the title or loop 3 other titles

> Parameters : text (string), loop_titles (bool), title_one (string), title_two (string), title_three (string)

**Example:**
```
// Normal Title
EasySharp.Title("Hello World!"); 

// Looping Titles
EasySharp.Title("Hello World", true, "First Loop", "Second Loop", "Third Loop")
```

***
### WriteLine
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

***
### WriteColoredLine
> `EasySharp.WriteColoredLine` | Write a colored line with text color and option for underlined effect

> Parameters : text (string), color (ConsoleColor), underlined (bool), underline_icon (char)

**Example:**
```
// With Colored Text
EasySharp.WriteColoredLine("Hello World", ConsoleColor.Blue, false);

// With Colored Text + Underline
EasySharp.WriteColoredLine("Hello World", ConsoleColor.Blue, true);
```

***
### WriteBackgroundLine
> `EasySharp.WriteBackgroundLine` | Write a colored line with background color and option for underlined effect

> Parameters : text (string), color (ConsoleColor), underlined (bool), underline_icon (char)

**Example:**
```
// With Colored Text
EasySharp.WriteBackgroundLine("Hello World", ConsoleColor.Blue, false);

// With Colored Text + Underline
EasySharp.WriteBackgroundLine("Hello World", ConsoleColor.Blue, true);
```

***
### CustomLine
> `EasySharp.CustomLine` | Write a colored line with background color and option for underlined effect

> Parameters : text (string), text_color (ConsoleColor), bg_color (ConsoleColor), underlined (bool), underline_icon (char)

**Example:**
```
// With Colored Text
EasySharp.WriteCustomLine("Yellow pink", ConsoleColor.Yellow, ConsoleColor.Magenta, false);

// With Colored Text + Underline
EasySharp.WriteCustomLine("Yellow pink", ConsoleColor.Yellow, ConsoleColor.Magenta, true);
```


***
### DrawMenu
> `EasySharp.DrawMenu` | Draw a menu using an array
string[] menu_items, ConsoleColor text_color

> Parameters : menu_items (string[]), text_color (ConsoleColor)

**Example:**
```
EasySharp.DrawMenu(new string[] { "Item 1", "Item 2" }, ConsoleColor.Cyan);

```
