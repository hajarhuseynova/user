
while (true)
{
    Console.WriteLine("Please,enter the username:");
    string UserName = Console.ReadLine();
    Console.WriteLine("Please,enter the user's password");
    string Password = Console.ReadLine();

    User User = new User(UserName, Password);

    if (User.UserName != null && User.Password != null)
    {
        Console.WriteLine("You can access your profile");
        break;
    }
    else
    {
        Console.WriteLine("You can not access your profile,because you have a problem with your username or password");
    }
}
