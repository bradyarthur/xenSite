// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of UserRepository
        UserRepository userRepository = new UserRepository();

        // Inject UserRepository into UserService
        UserService userService = new UserService(userRepository);

        // Use UserService to get user full name
        int userId = 1;
        string fullName = userService.GetUserFullName(userId);
        Console.WriteLine($"User Full Name: {fullName}");
    }
}
