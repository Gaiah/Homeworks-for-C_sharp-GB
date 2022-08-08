Console.WriteLine("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b || a >= c) {
 Console.Write("The max number is: ");
 Console.WriteLine(a);
}

 else if (b >= a || b >= c) {
 Console.Write("The max number is: ");
 Console.WriteLine(b);
}

 else if (c >= a || c >= b) {
 Console.Write("The max number is: ");
 Console.WriteLine(c);
}

else {
 Console.WriteLine("Incorrect number.");
}