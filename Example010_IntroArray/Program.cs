// 

int Max(int arg1, int arg2, int arg3)
{
    int resunlt = arg1;
    if(arg2 > resunlt) resunlt = arg2;
    if(arg3 > resunlt) resunlt = arg3;
    return resunlt;
}
//              0  1  2  3 4   5  6  7  8 
int[] array = {11,211,31,41,15,61,17,18,19};

int resunlt = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(resunlt);