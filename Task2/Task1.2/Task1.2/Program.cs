using Task1_2;
int number;
bool isParceSuccessOne;
do
{
    Console.Write("Ведите целочисленное число: ");
    isParceSuccessOne = int.TryParse(Console.ReadLine(), out number);
}
while (!isParceSuccessOne);

Console.WriteLine($"{IntExtensions.ToString(number)}");
