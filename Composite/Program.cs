// See https://aka.ms/new-console-template for more information
//Example 01
using Composite.Example01;
using Composite.Example02;
using System.Reflection;

var file1 = new AppFile("File1");
var file2 = new AppFile("File2");
var file3 = new AppFile("File3");

var folder1 = new Folder("Folder1");
folder1.AddItem(file1);

var folder2 = new Folder("Folder2");
folder2.AddItem(file2);
folder2.AddItem(file3);

var root = new Folder("Root");
root.AddItem(folder1);
root.AddItem(folder2);

root.Display();

//Example02
Employee john = new Employee("Jhon Doe");
Employee jane = new Employee("Jane Doe");

Manager bob = new Manager("Bob Smith");
bob.Add(john);
bob.Add(jane);

Employee tom = new Employee("Tom Johnson");
Manager susan = new Manager("Susan Thompson");
susan.Add(tom);
susan.Add(bob);

susan.Display(1);


