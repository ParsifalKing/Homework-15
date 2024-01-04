using task_1;


var car = new Car(0);

System.Console.Write("Enter amount of gasoline : ");

car.Refuel(Convert.ToInt32(System.Console.ReadLine()));
car.Drive();

