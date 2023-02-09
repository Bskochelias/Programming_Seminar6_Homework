// Показать двумерный массив размером m×n заполненный вещественными числами
// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// В матрице чисел найти сумму элементов главной диагонали

//Функция ввода и проверка является ли числом
int Proverca_chisla(string text)
{ 
  System.Console.Write(text);
  int num;
  while (true)
    if (int.TryParse(Console.ReadLine(), out num))
        return num;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Некоректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
}

//Создание двухмерного массива с случайными числами
int [,] CreateMass(int strok,int stolbetsov,int min,int max)
{
  int[,] arra = new int[strok,stolbetsov];
  for(int i=0;i<arra.GetLength(0);i++)
    for(int j =0;j<arra.GetLength(1);j++)
      arra[i,j] = new Random().Next(min,max);
  return arra;
}

//Печать двухмерного массива
void PrintMas(int [,]arra)
{
  for(int i=0;i<arra.GetLength(0);i++)
  {
    for(int j =0;j<arra.GetLength(1);j++)
    System.Console.Write($"{arra[i,j]} ");
  System.Console.WriteLine();
  }
}

int otvet1 = 0;
string? otvet2;
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Показать двумерный массив размером m×n заполненный вещественными числами");
    Console.WriteLine("2. Задать двумерный массив следующим правилом: Aₘₙ = m+n");
    Console.WriteLine("3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
    Console.WriteLine("4. В матрице чисел найти сумму элементов главной диагонали");
    Console.WriteLine(" ");
    otvet1 = Proverca_chisla("Ваш ответ: ");

    if (otvet1 > 5 ^ otvet1 < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet1 > 5 ^ otvet1 < 1);

  Console.Clear();

//Начало тела задач

//1. Показать двумерный массив размером m×n заполненный вещественными числами
if (otvet1==1)
{
  int m = Proverca_chisla("Введите строки: ");
  int n = Proverca_chisla("Введите столбцы: ");
  int min = Proverca_chisla("Введите минмальное значения рандома: ");
  int max = Proverca_chisla("Введите максимальное значения рандома: ");

  int[,]arra = CreateMass(m,n,min,max);
  
  System.Console.WriteLine("Получился следующий массив:");
  PrintMas(arra);
}

//2. Задать двумерный массив следующим правилом: Aₘₙ = m+n
if (otvet1==2)
{
  int m = Proverca_chisla("Введите строки: ");
  int n = Proverca_chisla("Введите столбцы: ");

  int[,] arra = new int[m,n];
  for(int i=0;i<arra.GetLength(0);i++)
    for(int j =0;j<arra.GetLength(1);j++)
      arra[i,j] = i+j;

  System.Console.WriteLine("Получился следующий массив:");
  PrintMas(arra);
}

//3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
if (otvet1==3)
{
  int m = Proverca_chisla("Введите строки: ");
  int n = Proverca_chisla("Введите столбцы: ");
  int min = Proverca_chisla("Введите минмальное значения рандома: ");
  int max = Proverca_chisla("Введите максимальное значения рандома: ");

  int[,]arra = CreateMass(m,n,min,max);

  System.Console.WriteLine();
  System.Console.WriteLine("Начальный массив:");
  PrintMas(arra);
  System.Console.WriteLine();

  for(int i=0;i<arra.GetLength(0);i++)
    for(int j =0;j<arra.GetLength(1);j++)
      if (i%2==0&&j%2==0) {arra[i,j] *= arra[i,j];}

  System.Console.WriteLine("Получился следующий массив:");
  PrintMas(arra);
}

//Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();