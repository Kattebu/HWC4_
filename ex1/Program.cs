// Ex1 задача25: Написать цикл, котор прин на вх два числа (АиВ) и возв число А в натур степ В
Console.WriteLine("Введите число A: ");
int firstNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int secondNumber=Convert.ToInt32(Console.ReadLine());
int result=1;
for(int i=0;i<secondNumber;i++)
{
    result*=firstNumber; 
}
Console.WriteLine("Число А, возведенное в степень В = " + result);