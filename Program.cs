
//метод считывает данные 
string? ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}
//метод печатает массив
void Print1DArr(string[] arr)
     {   Console.Write("[ ");
         for (int i = 0; i < arr.Length-1; i++)
         {  
            
             Console.Write(arr[i]+" , ");
         }
         Console.WriteLine( arr[arr.Length - 1]+ "]");
     } 

// разделяет строку на элементы массива c помощью функции Split 
//и формиру итоговый массив.
string[] OutStringArr(string inpString)
{
    string[] arr = inpString.Split(",");
    int count=0;
    int j=0;
    string[] OutArr=new string[arr.Length];
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i].Length<=3)
        {
            OutArr[j++]=arr[i];
            count++;
        }

    }
    Array.Resize(ref OutArr,count);
    return OutArr;
}



string inpString = ReadData("Введите строки через запятую: ");
Print1DArr(OutStringArr(inpString));





