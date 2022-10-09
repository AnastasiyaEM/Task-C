// Показать кубы чисел, заканчивающихся на четную цифру


int A =1;
int B = 4;
int count = 0;
int C = 1;
int stepen = 3;
int new_numberA = 0;

while ( count < stepen)
{
    C = C * A;
    A++;
    C = C % 10;
    new_numberA = C % 2 == 0;
    Console.WriteLine ($"Число {A} заканчивается на четную цифру в кубе {new_numberA}");
}