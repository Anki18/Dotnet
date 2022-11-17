// See https://aka.ms/new-console-template for more information
using Factory_Design_Pattern;

var factory = new Factory();
var acc = factory.GetAccount("Saving");
acc.ShowBalance();
var acc1 = factory.GetAccount("Current");
acc1.ShowBalance();