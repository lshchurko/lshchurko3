static void IntializeArray(int[] array,int cofficient)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i;
        for (int power=1;power<=cofficient;power++)
        {
            array[i]=(int)Math.Pow(i,power);
        }
    }
}

static float avgCalculation(int[] arrayAvg)
{
    float avgs = 0;
    for (int e = 0; e < arrayAvg.Length; e++)
    {
        avgs  += arrayAvg[e];
    }
    avgs = avgs / arrayAvg.Length;
    return avgs;
}
 
for(int z = 1; z<=3;z++)
{ 
    int[] arrayF=new int[10];
    IntializeArray(arrayF, z);
    Console.WriteLine("Average array{0}  {1}", z, avgCalculation(arrayF));
}
