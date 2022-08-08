Console.WriteLine("Enter some number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (i <= n) {
    if (i%2 == 0) {
        Console.WriteLine(i);
        i++;
    }
  
 else {
    i++;
  }
}