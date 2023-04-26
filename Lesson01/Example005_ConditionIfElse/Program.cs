Console.WriteLine("Input your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ura, this is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username + "!");
}