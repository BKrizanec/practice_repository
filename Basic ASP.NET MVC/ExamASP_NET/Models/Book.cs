namespace ExamASP_NET.Models;

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public int YearOfRelease { get; set; }
    public string Genre { get; set; }
}