// рекурсия на примере факториала

/*
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($" {i}! = {Factorial(i)}");
}

*/

//==========================================================
// на примере Фибоначчи

// f(1)
// f(2)
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n==1 || n==2) return 1;  // если n=1 или n=2 то возвращаем 1
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
  System.Console.WriteLine(Fibonacci(i));  
}



