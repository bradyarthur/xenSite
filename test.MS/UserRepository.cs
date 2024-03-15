// UserRepository.cs
public class UserRepository
{
    public User GetUserById(int userId)
    {
        // Logic to retrieve user from the database
        return new User { Id = userId, Name = "John Doe" };
    }
}

// UserService.cs
public class UserService
{
    private readonly UserRepository _userRepository;

    // Constructor injection
    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public string GetUserFullName(int userId)
    {
        User user = _userRepository.GetUserById(userId);
        return user != null ? user.Name : "User not found";
    }
}

// User.cs (model class)
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
