//Вид1 - ничего не возвращают и ничего не принимают


//void Method()
//{
//    Console.WriteLine("Автор...");//тело метода
//}
//Method();//это как вызываются таките методы



//Вид2 - ничего не возвращают но могут принимать агргументы


//void Method2(string mgs)
//{
//    Console.WriteLine(mgs);
//}
//Method2(mgs: "Текст сообщения");//это как вызвать такие методы

//void Method21(string mgs, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(mgs);
//        i++;
//    }
//}
             //Method21(mgs: "Текст", count: 4);//это сколько раз увидеть метод хотим
//Method21(count: 4, mgs: "Новый текст");



//Вид3 - что то возвращают, но ничего не принимают

//int Method3()
//{
//    return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);


//Вид4 - что-то рпинимают и что-то возвращают

//string Method4(int count, string c)
//{
//    int i =0;
//    string result = String.Empty; 
//
//    while (i < count)
//    {
//        result = result + c;
//        i++;
//    }
//    return result;
//}
//
//string res = Method4(10, "asdf");
//Console.WriteLine(res);




//string Method4(int count, string c)
//{
//    
//    string result = String.Empty; 
//    for(int i = 0;i < count;i++)
//    {
//        result = result + c;
//    }
//    return result;
//}
//
//string res = Method4(10, "asdf");
//Console.WriteLine(res);



//Таблица умножения
//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i*j}");
//    }
//    Console.WriteLine();
//}



//=======Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "K",
//а большие "С" заменить маленькими "с".

//Ясна ли задача?
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// S[3]  //r

//string Replace(string text, char ojdValue, char newValue)
//{
//    string result = String.Empty;
//
//    int lenght = text.Length;
//    for (int i = 0; i < lenght; i++)
//    {
//        if(text[i] == ojdValue) result = result+ $"{newValue}";
//        else result = result + $"{text[i]}";
//    }
//
//    return result;
//}
//
//string newText = Replace(text, ' ', '|');
//
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(text, 'к', 'К');
//Console.WriteLine(newText);


int[] arr = {1, 2, 3, 4, 5, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    } 
}

}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);