// See https://aka.ms/new-console-template for more information

using HW_15;
using static System.Console;

ThreadOutput threadOutput = new ThreadOutput();

WriteLine("Before thread");

threadOutput.WriteInThread("Hi", 2000);

WriteLine("After thread");