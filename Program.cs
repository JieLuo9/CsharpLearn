using System.Runtime.Intrinsics.Arm;
using System.ComponentModel.Design.Serialization;
using System.Linq.Expressions;
using System.Text;
using System.Collections;

// string[] names = { "Bob", "Otto", "Kavin" };
// foreach (string name in names)
// {
//   System.Console.WriteLine(name);
// }


// System.Console.WriteLine("this is IEnumerator.");
// IEnumerator e = names.GetEnumerator();
// while (e.MoveNext())
// {
//   string name = (string)e.Current;
//   System.Console.WriteLine(name);
// }

System.Console.Write("Please input a number: ");
string? input = Console.ReadLine();

try
{
  int number = int.Parse(input);
  System.Console.WriteLine($"your input number is {number}");
}
catch (System.FormatException) when (input.Contains("$"))
{
  System.Console.WriteLine("input contains invaild char.");
}

catch (System.OverflowException)
{
  System.Console.WriteLine("your input too big or too small.");
}

catch (System.Exception e)
{
  System.Console.WriteLine($"{e.GetType()}: {e.Message}");
  throw;
}
