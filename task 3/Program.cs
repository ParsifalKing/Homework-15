using task_3;

var book = new Book();

System.Console.Write("Please enter title of the book : ");
book.SetTitle(System.Console.ReadLine());
System.Console.Write("Please enter author of the book : ");
book.SetAuthor(System.Console.ReadLine());
System.Console.Write("Please enter your name : ");
string myName = System.Console.ReadLine();


System.Console.WriteLine("                     --------------------");



System.Console.Write("The title of the book : ");
System.Console.WriteLine(book.GetTitle());

System.Console.Write("The author's name : ");
System.Console.WriteLine(book.GetAuthor());

book.Borrow();
System.Console.WriteLine($"by {myName}");
book.Read();
System.Console.WriteLine($"by {myName}");
book.ReturnBook();
