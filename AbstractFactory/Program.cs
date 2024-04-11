// See https://aka.ms/new-console-template for more information
using AbstractFactory.Example01;
using AbstractFactory.Example01.Factories;
using AbstractFactory.Example02;
using AbstractFactory.Example02.Factories;

//Example 01
IThemeFactory themeFactory = new WindowsFactory();

IButton button = themeFactory.CreateButton();
button.Render();
IDropDown dropDown = themeFactory.CreateDropDown();
dropDown.Render();
ITextBox textBox = themeFactory.CreateTextBox();
textBox.Render();

//Example 02
//IPaymentGatewayFactory paymentGatewayFactory = new StripeFactory();
//var paymentService = new PaymentService(paymentGatewayFactory);
//paymentService.MakePayment();
