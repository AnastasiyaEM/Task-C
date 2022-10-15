// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.



int size = 10;
int[] array = new int[size]; 

void FillArray(int[] array, int min, int max) 
{ 
    for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(min, max); 
} 

void PrintArray (int[] array) 
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++) Console.Write(array[i] + ", "); 
    Console.WriteLine(array[array.Length - 1] + "}"); 
} 


 FillArray(array, 0, 12); 
 Console.Write($"Сформированный массив: "); 
  
 
 PrintArray(array); 
 Console.WriteLine(); 
 
 
for (int i = 0; i < size/2; i++) 
{ 
    int multiplication = 0; 
    multiplication = array[i] * array[array.Length - i - 1]; 
    Console.WriteLine($"Element {array[i]} * {array[array.Length - i - 1]} = {multiplication}"); 
}