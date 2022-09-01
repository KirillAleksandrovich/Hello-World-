Console.Clear();
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "викуля")
{
    Console.WriteLine("Ура, это же Викуля!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}