// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int length = 10;
int[] numbers = new int[length];

int FillArray(int length)  //метод, заполняющий массив случайными числами
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        numbers[i] = new Random().Next(-20, 21);
        if (numbers[i] % 2 == 0) count++;
    }
    return count; //возвращает количество четных значений
}

int[] FillEvenArray(int arg, int length)  //метод, создающий массив с четными значениями
{
    int[] evenNumbers = new int[arg];
    for (int i = 0, j = 0; i < length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenNumbers[j] = numbers[i];
            j++;
        }
    }
    return evenNumbers;
}

int count = FillArray(length);
int[] evenNumbers = FillEvenArray(count, length);

// для проверки
// Console.WriteLine(String.Join(' ', numbers));   
// Console.WriteLine(String.Join(' ', evenNumbers));
// Console.WriteLine(lengthEvenNumbers);
