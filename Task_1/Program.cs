// //Console.WriteLine("Hello, World!");

// // int value = 100;
// // Console.WriteLine (value);

// // double a = 5.55;
// // char b = '!';
// // bool c = true;
// // Console.WriteLine (a);
// // Console.WriteLine (b);
// // Console.WriteLine (c);


// Console.Write("Input first number; ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input seconde number; ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a>b)
// {
//     System.Console.WriteLine(a);
// }
// else 
// {
//     System.Console.WriteLine(b);
// }

Console.Write("Input first number; ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number; ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number; ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max<b)
  {
    max = b;
  }
if (max<c)
{
  max = c;
}
Console.WriteLine(max);
