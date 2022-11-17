// string[,] table = new string[2, 5];
// table[1, 2] = "текст";                   //1 строка, 2 столбец
//индексы для строк и для столбцов считаются от нуля!
// table[0, 0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]  столбцы
// table[1, 0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]  столбцы второй строки
//для строк инициализация происходит константой String.Empty

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int column = 0; column < 5; column++)
//     {Console.WriteLine($"-{table[rows, column]}-");
//     }
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10) 
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);