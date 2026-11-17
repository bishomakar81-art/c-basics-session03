using System.Text;

Console.WriteLine("Hello, World!");

#region Q1
string title = "clean code ";
string upperTitle = title.ToUpper();
Console.WriteLine(upperTitle);
Console.WriteLine(title);
#endregion

#region Q2
string book01 = "clean code";
string book02 = "clean code";
bool isSameReference = object.ReferenceEquals(book01, book02);
Console.WriteLine(isSameReference);
#endregion

#region Q3,Q4
StringBuilder sb = new StringBuilder();
sb.Append("book list");
sb.Append("  - Updated");

Console.WriteLine(sb.ToString());

sb.Replace("book list", "library");
Console.WriteLine(sb.ToString());

#endregion


#region Q5

string title01 = "clean code";
int pages = 464;
Console.WriteLine("Book :" + title01 + " pages :" + pages);
#endregion

#region Q6
Console.WriteLine($"Book: {title01}, Pages: {pages}");
#endregion

#region Q7
string result = string.Format("Book: {0}, Pages: {1}", title01, pages);
Console.WriteLine(result);
#endregion

#region Q8

int pages02 = 464;
if (pages02 >= 300)
{
    Console.WriteLine("long book");
}

else
{
    Console.WriteLine("short book");
}
#endregion

#region Q9
int pages03 = 464;
bool isAvailable = true;
if (pages03 > 300 && isAvailable)
{
    Console.WriteLine(" you can borrow this book");
}
else
{
    Console.WriteLine("you cannot borrow this book");
}
#endregion


#region Q10
string title02 = "Refactoring";
switch (title02)
{
    case "clean code":
        Console.WriteLine("great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("NICE PICK!");
        break;
    default:
        Console.WriteLine("NEVER HEARD OF IT!");
        break;
}
#endregion



#region Q11

string[] bookTitles = { "clean code", "The Pragmatic Programmer ", "Refactoring" };

for (int i = 0; i < bookTitles.Length; i++)
{
    Console.WriteLine(bookTitles[i]);
}
#endregion



#region Q12

int index = 0;
while(index< bookTitles.Length)
{
    Console.WriteLine(bookTitles[index]);
    index++;
}

#endregion

#region Q13

int count = 0;
do
{
    Console.WriteLine("checking book");
    count++;
} while (count < 3);

#endregion

#region Q14
foreach (string book in bookTitles)
{
    Console.WriteLine(book);
}
#endregion

#region Q15

foreach (string book in bookTitles)
{
    if (book == "Refactoring")
    {
        
        break;
    }
    Console.WriteLine(book);
}
#endregion

#region Q16
foreach (string book in bookTitles)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }
    Console.WriteLine(book);
}
#endregion

#region Q17
 
void printFirstBook(string[] books)
{
    if (books.Length==0)
    {
        return;
    }
     Console.WriteLine(books[0]);
}
#endregion