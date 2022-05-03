// Двумерные массивы
// [,] matrix = new int[5,8]; // где 5 - это строки, а 8 - столбцы


/*
string[,] table = new string [2,5];
              // string.Empty - по умолчанию строки пустые
              // table [0,0]  table [0,1]  table [0,2]  table [0,3]  table [0,4]
              // table [1,0]  table [1,1]  table [1,2]  table [1,3]  table [1,4]

table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)     // строки
{
    for (int columns = 0; columns < 5; columns++)     // столбцы
     {
        System.Console.WriteLine($"-{table[rows, columns]}-");
     }
}
*/
//===============================================================
// то же самое что и сверху но с цифрами

/*
int [,] matrix = new int[3, 4];

for (int rows = 0; rows < matrix.GetLength(0); rows++)  // GetLength(0) - автоматически считывает длину
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++) // GetLength(0) - автоматически считывает длину
    {
        System.Console.Write($" {matrix[rows, columns]} ");
    }
System.Console.WriteLine();
}
*/
//========================================================
// превращаем программу выше в метод


// функция/метод которая выводит матрицу на экран
void PrintArray (int[,] matr)
{

    for (int rows = 0; rows < matr.GetLength(0); rows++)  // GetLength(0) - автоматически считывает длину
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // GetLength(0) - автоматически считывает длину
        {
            System.Console.Write($" {matr[rows, columns]} ");
        }
    System.Console.WriteLine();
    }
}

// функция/метод которая заполняет матрицу случайными числами
void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)  // GetLength(0) - автоматически считывает 
    //  и возвращает кол-во строк в массиве
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // GetLength(0) - автоматически 
        //  считывает кол-во столбцов в массиве
        {
            matr[rows, columns] = new Random().Next(1,10);
        }
    }
}

int [,] matrix = new int[3, 4];

PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

