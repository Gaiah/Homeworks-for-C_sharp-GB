Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (n < 0) {
    n = n * -1;
}

int count = n * 2 + 1;
n = n * -1;

while (i < count) {
    Console.WriteLine(n);
    n++;
    i++;
}