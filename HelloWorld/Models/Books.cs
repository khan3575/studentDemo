using System.Data.Common;
namespace HelloWorld.Models;

public class Books
{
    public int Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public string Author {get; set;} = string.Empty;
    public double Price {get; set;}


}