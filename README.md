# Wordle-Solver

A C# application for solving wordle puzzles, adapted from my previous console based python application.

To download and use the program, you'll only need to download 'Wordle Solve.exe'

I first adapted my previous python code to work as a console application in C#. Once everything was working identically to the previous application, I begun to design a UI using WinForms and adapt the console application code to suit a WinForms application.

The UI is designed from scratch in WinForms, which is a huge improvement over the original console based program. I also implemented a custom header, which allows the window to be closed, minimised and dragged, as well as implementing a toggleable 'lock' which keeps the window displayed on top.

There are a few places where I'd like to improve the code, such as the 'UpdateGrid' method which contains a lot of repetition, but overall it's much more presentable than the previous console versions.
