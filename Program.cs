namespace LayeredArchitecture
{
    // Presentation Layer (UI)
    public class Program
    {
        static void Main()
        {
            UserService userService = new UserService();
            Console.WriteLine("Enter username:");
            string? username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string? password = Console.ReadLine();
            bool isAuthenticated = userService.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                Console.WriteLine("Authentication successful!");
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }

            Console.ReadLine();
        }
    }

    // Business Logic Layer
    public class UserService
    {
        private UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool AuthenticateUser(string? username, string? password)
        {
            User? user = userRepository.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                return true;
            }

            return false;
        }
    }

    // Data Access Layer
    public class UserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>()
        {
            new User("admin", "admin123"),
            new User("user1", "password1"),
            new User("user2", "password2")
        };
        }

        public User? GetUserByUsername(string? username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }
    }

    // Domain Model
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}