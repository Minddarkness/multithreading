// See https://aka.ms/new-console-template for more information

using HW_15;

ThreadOutput threadOutput = new ThreadOutput();

threadOutput.WriteInThread("Hi", 2000);
threadOutput.WriteInThread("Hi here", 100);
threadOutput.WriteInThread("Hello", 1000);

