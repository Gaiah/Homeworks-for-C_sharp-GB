Console.WriteLine("Input number A: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input number B: "); 
int b = Convert.ToInt32(Console.ReadLine()); 
int max; 
 
if(a > b) { 
    max = a; 
    Console.WriteLine("The max number is: "); 
    Console.WriteLine(max); 
} 
 
else if(a < b) { 
    max = b; 
    Console.WriteLine("The max number is: "); 
    Console.WriteLine(max); 
} 
 
else (a == b) { 
 Console.WriteLine("These two numbers are equal!"); 
} 