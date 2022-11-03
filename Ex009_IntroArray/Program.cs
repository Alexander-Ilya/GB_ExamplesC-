int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//int a1 =10, b1=13, c1=15;
//int a2 =10, b2=13, c2=15;
//int a3 =10, b3=13, c3=25;

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int max = Max(
    Max(array[0], array[1], array[2]),
     Max(array[3], array[4], array[5]),
      Max(array[6], array[7], array[8])
      );
Console.WriteLine(max);
