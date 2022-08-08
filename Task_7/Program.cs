Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 99 || num > 999) {
    Console.WriteLine("Incorrect number.");
}

else {
    Console.WriteLine("The last digit of Your number is: ");
    Console.WriteLine(num % 10);
}