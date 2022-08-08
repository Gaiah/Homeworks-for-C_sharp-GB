Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
 Console.Write("This number is even: ");
 Console.WriteLine(num);
}

else {
 Console.Write("This number isn't even: ");
 Console.WriteLine(num);
}