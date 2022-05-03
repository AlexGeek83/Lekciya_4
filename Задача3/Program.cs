// палец вверх

int[,] pic = new int [20,20];

void PrintImage (int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)  // GetLength(0) - автоматически считывает 
    //  и возвращает кол-во строк в массиве
    {
        for (int j = 0; j < image.GetLength(1); j++) // GetLength(0) - автоматически 
        //  считывает кол-во столбцов в массиве
        {
         // System.Console.Write($" {matr[i, j]} ");
        if(image[i,j] == 0 ) Console.Write($" ");
        else Console.Write($"+");
        }


    }
}

PrintImage(pic);

