// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;
using SwapMouseButtons;

Console.Title = "Mouse Button Swapper";

var swapper = new Swapper();
var result = swapper.Swap();
var output = result
	? "Buttons set to normal"
	: "Buttons set to swapped (left hand)";
Console.WriteLine(output);

Thread.Sleep(3000);