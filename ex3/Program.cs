// Задача29: прогр,кот задает массив из 8 эл и выв их на экран
int[]GetArray(int size)
{
int[] result =new int[size];
for(int i=0;i<result.Length;i++)
{
    result[i]=new Random().Next(0,100);
}
return result;
}
int[] result=GetArray(8);
Console.WriteLine($"массив: [{String.Join(";",result)}]");