# CalKul
An RPN calculator written in C#. For the moment only handles doubles, strings, booleans and a few operators.

## Why?
For now? Just for fun. Also to have a simple calculator with some RPN/RPL capacity in PowerShell or Bash.

## Tips and tricks
Write simple RPL programs by enclosing the program with `§`. (This works the same as the << >> characters in Hp calculators.)

Store programs in variables by using `"programname" sto`. Like this:

    § 100 < if "Sad" else "Great" end §
    "trmpf" sto
    20 trmfp        [output -> Sad]
    120 trmpf       [output -> Great]

The calculator has, besides the maths, some fun operaors/functions like `rand, date, beep, wait, if-then-else-end` and `setconfig`. More to come. It also has variables (that you can store programs, bools, strings and doubles in for the moment) but these are not persisted between sessions.

### Config settings
* windowwidth (default: 40)
* windowheight (default: 20)
* showdatatypes (default: 1 -> on)
* showlinenumbers (default: 1 -> on)
* stackrows (default: 10)

## Todo
* [x] Move from supporting only double to supporting objects on stack
* [x] Add tan, rand, ==, <, >
* [ ] Add asin, acos, atan, 1/x, !, ln, e^x, 10^x and log
* [ ] Add more RPL words for stack manipulation
* [ ] Add more RPL words for conditionals
* [ ] Do crazy stuff with URLs
* [ ] Test other user interface?
* [x] Add variables
* [ ] Add variable persistence

## Ideas for the future
Lots. No promises though.
* Sound
* wget/curl like functionality
* Supporting HTTP verbs
* Supporting images
* DSL?
* Bash/PowerShell command support
* Supporting all kinds of .NET types for Windows instrumentation and other craziness
