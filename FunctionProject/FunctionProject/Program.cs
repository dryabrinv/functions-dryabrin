// Сумма двух чисел
int Sum(int first, int second) 
{
    return first + second; 
}

// Площадь круга
float AreaCircle(float radius)
{
    return radius * radius * float.Pi; 
}

// Длина строки
int StringLength(string str)
{
    return str.Length; 
}

// Максимальное значение в массиве
int MaxValueArray(int[] array)
{
    return array.Max();
}

// Факториал числа
int Factorial(int value) 
{
    int factorial = 1;
    for (int i = 0; i < value; i++)
    {
        factorial *= (i + 1);
    }
    return factorial;
}

// Является ли слово палиндромом
bool IsPalindrome(string str)
{
    string pStr = str.ToLower();

    for (int i = 0; i < str.Length; i++)
    {
        if (pStr[i] != pStr[(str.Length - 1) - i])
        {
            return false;
        }
    }
    return true;
}

// Объекдинение массивов
int[] MergeArrays(int[] array1, int[] array2)
{
    return array1.Concat(array2).ToArray();
}

// Является ли число простым
bool IsPrime(int num)
{
    if (num <= 1)
    {
        return false;
    }

    for (int i = 2; i <= num - 1; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}

// Возвращает обратную строку
string ReverseString(string str)
{
    char[] charStr = str.ToCharArray();
    Array.Reverse(charStr);
    return new string(charStr);
}

// Сумма всех значение в массиве
int SumArrayValues(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}
