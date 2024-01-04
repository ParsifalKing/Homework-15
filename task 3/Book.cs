namespace task_3;
class Book : AbstractBook, Borrowable
{
    public string Title { get; set; }
    public string Author { get; set; }


    public void Read()
    {
        System.Console.Write("The book is being read ");
    }
    public void Borrow()
    {
        System.Console.Write("The book has been borrowed ");
    }
    public void ReturnBook()
    {
        System.Console.Write("The book has been returned after 1 month ");
    }


}
