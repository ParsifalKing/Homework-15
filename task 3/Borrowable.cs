namespace task_3;

public interface Borrowable
{

    void Borrow()
    {
        System.Console.WriteLine("The book has been borrowed");

    }
    void ReturnBook()
    {
        System.Console.WriteLine("The book has been returned");
    }


}
