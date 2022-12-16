using AbstractFactoryPattern;
using System;

IAbstractFactory factory1 = new ConcreteFactory1();
var productA1 = factory1.CreateProductA();
var productB1 = factory1.CreateProductB();

Console.WriteLine(productA1.GetName()); // Output: "Product A1"
Console.WriteLine(productB1.GetName()); // Output: "Product B1"
Console.WriteLine("\n");

IAbstractFactory factory2 = new ConcreteFactory2();
var productA2 = factory2.CreateProductA();
var productB2 = factory2.CreateProductB();

Console.WriteLine(productA2.GetName()); // Output: "Product A2"
Console.WriteLine(productB2.GetName()); // Output: "Product B2"