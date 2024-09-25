using System;

class StringClass
{
    private char[] _data; // Масив символів для зберігання рядка
    public int Length { get; private set; } // Довжина рядка

    // Конструктор за замовчуванням
    public StringClass()
    {
        _data = new char[0];
        Length = 0;
    }

    // Конструктор з рядком
    public StringClass(string str)
    {
        Length = str.Length;
        _data = new char[Length];
        for (int i = 0; i < Length; i++)
            _data[i] = str[i];
    }

    // Конструктор копіювання
    public StringClass(StringClass other)
    {
        Length = other.Length;
        _data = new char[Length];
        Array.Copy(other._data, _data, Length);
    }

    // Перевантаження оператора конкатенації
    public static StringClass operator +(StringClass s1, StringClass s2)
    {
        StringClass result = new StringClass();
        result.Length = s1.Length + s2.Length;
        result._data = new char[result.Length];

        Array.Copy(s1._data, result._data, s1.Length);
        Array.Copy(s2._data, 0, result._data, s1.Length, s2.Length);

        return result;
    }

    // Перевантаження оператора вилучення символу з позиції
    public char this[int index]
    {
        get
        {
            if (index < 0 || index >= Length)
                throw new IndexOutOfRangeException("Index out of range.");
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= Length)
                throw new IndexOutOfRangeException("Index out of range.");
            _data[index] = value;
        }
    }

    // Перевантаження оператора порівняння
    public static bool operator ==(StringClass s1, StringClass s2)
    {
        if (ReferenceEquals(s1, s2)) return true; // Якщо два посилання однакові
        if (s1 is null || s2 is null) return false; // Перевірка на null
        if (s1.Length != s2.Length) return false;

        for (int i = 0; i < s1.Length; i++)
            if (s1[i] != s2[i])
                return false;

        return true;
    }

    public static bool operator !=(StringClass s1, StringClass s2)
    {
        return !(s1 == s2);
    }

    // Метод для виведення рядка
    public override string ToString()
    {
        return new string(_data);
    }

    public override int GetHashCode() => ToString().GetHashCode();
    public override bool Equals(object obj) => this == (StringClass)obj;
}

// Клас для сортування рядків
class StringSorter
{
    public static void Sort(StringClass[] strings)
    {
        Array.Sort(strings, (s1, s2) => s1.ToString().CompareTo(s2.ToString()));
    }
}

// Основна програма
class task03
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення масиву рядків
        StringClass[] strings = new StringClass[]
        {
            new StringClass("Banana"),
            new StringClass("Apple"),
            new StringClass("Orange"),
            new StringClass("Grapes"),
            new StringClass("Peach")
        };

        // Сортування рядків за алфавітом
        StringSorter.Sort(strings);

        // Виведення відсортованих рядків
        Console.WriteLine("Sorted strings:");
        foreach (var str in strings)
        {
            Console.WriteLine(str);
        }

        // Тестування перевантаження операторів
        StringClass str1 = new StringClass("Hello");
        StringClass str2 = new StringClass(" World");
        StringClass str3 = str1 + str2; // Конкатенація

        Console.WriteLine($"Concatenated string: {str3}");
        Console.WriteLine($"Character at index 1: {str3[1]}"); // Вилучення символу
        Console.WriteLine($"Are str1 and str2 equal? {str1 == str2}"); // Порівняння

        // Використання конструктора копіювання
        StringClass str4 = new StringClass(str3);
        Console.WriteLine($"Copied string: {str4}");

        Console.ReadKey();
    }
}
