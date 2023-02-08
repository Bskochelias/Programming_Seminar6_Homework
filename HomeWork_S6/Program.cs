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
    Console.WriteLine("2. НЗадать двумерный массив следующим правилом: Aₘₙ = m+n");
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