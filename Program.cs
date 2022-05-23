/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

int EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt)
    {
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) )
        {
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.Write("Вы ввели текст, введите пожалуйста число : "); 
    }
    return number;
}

void writeWhatCoord(int i, int j)
{
    if ((j == 0)) Console.Write($"\t X{i+1} : ");
    else if ((j == 1)) Console.Write($"\t Y{i+1} : ");
    else  Console.Write($"\t Z{i+1} : ");
}

int[,] CoordEnter()
{
    int[,] array = new int[2,3];
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Coodinate {i+1} : ");
        for (int j = 0; j < 3; j++)
        {
            writeWhatCoord(i,j);
            array[i,j] = EnterNumberTest();
        }
    }
return array;
}

double lengtCount(int[,] array)
{
    double d = (double)Math.Sqrt(Math.Pow(array[1,0]-array[0,0] , 2)+Math.Pow(array[1,1]-array[0,1] , 2)+Math.Pow(array[1,2]-array[0,2] , 2));
return d;
}

int[,] array = CoordEnter();

Console.WriteLine($"Length = {lengtCount(array):N2}");

Console.ReadLine();