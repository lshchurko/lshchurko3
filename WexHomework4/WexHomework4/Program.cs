

// заполняем массив рандомными числами от -100 до 100
static void IntializeArray(int[] array, int cofficient)
{
    Random rnd = new Random();
   

    for (int step = 0; step < array.Length; step++)
    {
        array[step] = rnd.Next(-100, 100);
        //Console.WriteLine(array[step]);
    }
    
}
//находим экстримумы мин или макс
static int extremumCalculation(int[] arrayExtr,string extremum)
{    
    int extr = arrayExtr[0];
    for (int e = 0; e < arrayExtr.Length; e++)
    {
        if (extremum == "min")
        {
            if (arrayExtr[e]<extr) extr= arrayExtr[e];
        }
        else
        {
            if (arrayExtr[e] > extr) extr = arrayExtr[e];
        }
    }
 
    return extr;
}
//возращает массив после перестановки мин и макс местами
static int[] finalArray(int[] array3,int valueMin,int valueMax)
{
    
    for (int i = 0; i < array3.Length; i++)
    {

        if (array3[i] == valueMin)
        {
            array3[i] = valueMax;

        }
        else if (array3[i] == valueMax)
        {
            array3[i] = valueMin;
        }
    }
    return array3;
}

//находит индексы где расположены все мин или все макс значения

static Array findExtremumPositions(int[] arrays, string extremum2)
 {
    List<int> positionsMinMax = new List<int>();

    for (int ind = 0; ind < arrays.Length; ind++)
    {
        if (arrays[ind] == extremumCalculation(arrays, extremum2))
        {
            positionsMinMax.Add(ind);
        }    
    }
    return positionsMinMax.ToArray();

}
for (int z = 1; z <= 2; z++)
{
    Random rnd2 = new Random();
    int randArrayLength = rnd2.Next(2, 100);
    int[] arrayF = new int[randArrayLength];
    IntializeArray(arrayF, z);
    int minValue = extremumCalculation(arrayF, "min");
    int maxValue = extremumCalculation(arrayF, "max");
    int[] positionsMin = (int[])findExtremumPositions(arrayF, "min");
    int[] positionsMax = (int[])findExtremumPositions(arrayF, "max");
    Console.WriteLine("Min array{0}  {1}", z, minValue);
    for (int r = 0; r < positionsMin.Length; r++)
    {
        Console.WriteLine("Min array{0}  possitions {1}", z, positionsMin[r]);
    }
    Console.WriteLine("Max array{0}  {1}", z, maxValue);
    for (int r2 = 0; r2 < positionsMax.Length; r2++)
    {
        Console.WriteLine("Max array{0}  possitions {1}", z, positionsMax[r2]);
    }
    arrayF = (int[])finalArray(arrayF,minValue,maxValue);
    // ниже узнаем позиции мин и макс значений в обоих массивах после перестановки местами
    int[] positionsMinFinal = (int[])findExtremumPositions(arrayF, "min");
    int[] positionsMaxFinal = (int[])findExtremumPositions(arrayF, "max");
        for (int l = 0; l < positionsMinFinal.Length; l++)
    {
        Console.WriteLine("Min array{0}  Final possitions {1}", z, positionsMinFinal[l]);
    }
    
    for (int l2 = 0; l2 < positionsMaxFinal.Length; l2++)
    {
        Console.WriteLine("Max array{0}  Final possitions {1}", z, positionsMaxFinal[l2]);
    }



}



