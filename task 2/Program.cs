
using task_2;

var dog = new Dog();
System.Console.Write("Enter dog's name : ");
dog.Name = System.Console.ReadLine();


System.Console.WriteLine(dog.GetName());
dog.Eat();


