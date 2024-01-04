namespace task_3;

public abstract class AbstractBook : Readable
{

    string title;
    string author;

    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string author)
    {
        this.author = author;
    }

    void Read()
    {
        System.Console.WriteLine("The book is being read");
    }




}
