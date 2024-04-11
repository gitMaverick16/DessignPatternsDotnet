// See https://aka.ms/new-console-template for more information
using AbstractFactory.Example01;
using AbstractFactory.Example01.Factories;

//Example 01
IThemeFactory themeFactory = new WindowsFactory();

IButton button = themeFactory.CreateButton();
button.Render();
IDropDown dropDown = themeFactory.CreateDropDown();
dropDown.Render();
ITextBox textBox = themeFactory.CreateTextBox();
textBox.Render();
