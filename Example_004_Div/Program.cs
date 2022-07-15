Console.Write("Введите Ваше имя ");
string userName = Console.ReadLine()!;
if (userName.ToLower() == "лена")
{
    Console.WriteLine("Привет моя любимая!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);

}