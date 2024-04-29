using Composite.Example01;
using Composite.Example02;
using Composite.Example03;
using System.Reflection;

//Example 01
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

//Example03
//Create products
var laptop = new Product("Laptop", 1000);
var phone = new Product("Phone", 500);

// Create bundle of products
var bundleProductos = new Bundle();
bundleProductos.Add(laptop);
bundleProductos.Add(phone);

// Create another product
var mouse = new Product("Mouse", 20);

// Create bubdle of bundles
var bundleBundles = new Bundle();
bundleBundles.Add(bundleProductos); // Add the bundle of products
bundleBundles.Add(mouse); // Add anothe product directly

// Show bundle price of bundles
bundleBundles.ShowPrice();

