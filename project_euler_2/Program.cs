static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }


int limit = 4000000;
int sumEven = 0;
int n = 0;

 while (Fibonacci(n) <= limit)
        {
            if (Fibonacci(n) % 2 == 0)
                sumEven += Fibonacci(n);
            n++;
        }

Console.WriteLine("Die Summe der geraden Zahlen in der Fibonacci-Folge unter " + limit + " ist: " + sumEven);