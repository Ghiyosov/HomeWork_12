using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

System.Console.WriteLine("---------------1");
List<string> list = new List<string>(){"banana","apple","kivi","orange","apple"};
System.Console.WriteLine(list.LastIndexOf("apple"));


System.Console.WriteLine("---------------2");
List<string> list1 = new List<string>(){"banana","apple","tamatos","kivi","orange","apple"};
System.Console.WriteLine(list1.SequenceEqual(list));

System.Console.WriteLine("---------------3");
list1.Reverse();
foreach (var item in list1)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("---------------4");
void Prog(List<string> list)
{
    if (list.Count>0) System.Console.WriteLine(true);
    else System.Console.WriteLine(false);
}
var list3 = new List<string>();
Prog(list3);
Prog(list1); 
System.Console.WriteLine("---------------5");
foreach (var item in list.GetRange(1,3))
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("---------------6");
var list4 = new List<int>(){9,8,7,6,5,4,3,2,1};
list4.Sort();
foreach (var item in list4)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("---------------7");
list1.Clear();
foreach (var item in list1)
{
    System.Console.WriteLine(item);
}
Prog(list1); 

System.Console.WriteLine("---------------8");
System.Console.WriteLine(list4.Max());
System.Console.WriteLine(list4.Min());

System.Console.WriteLine("---------------9");
list4.RemoveAll(p=>p<5);
foreach (var item in list4)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("---------------10");
Random.Shared.Shuffle(CollectionsMarshal.AsSpan(list4));
foreach (var item in list4)
{
    System.Console.WriteLine(item);
}


