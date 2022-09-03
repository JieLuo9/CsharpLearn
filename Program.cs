using System.Runtime.Intrinsics.Arm;
using System.ComponentModel.Design.Serialization;
using System.Linq.Expressions;
using System.Text;
using System.Collections;

string[] names = { "Bob", "Otto", "Kavin" };
foreach (string name in names)
{
  System.Console.WriteLine(name);
}


System.Console.WriteLine("this is IEnumerator.");
IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
  string name = (string)e.Current;
  System.Console.WriteLine(name);
}

