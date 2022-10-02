// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число n: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int newnumber = (number / 100 * 10 + number % 10); 
    
    Console.Write("Полученное число:  ");
    Console.WriteLine (newnumber);

}
else
{
    Console.Write("Число не трехзначное");
}