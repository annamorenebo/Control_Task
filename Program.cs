
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







