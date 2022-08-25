Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "юлия")
{
    Console.WriteLine("Ура, это же ЮЛИЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
