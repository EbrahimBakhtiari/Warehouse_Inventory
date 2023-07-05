using Infrastructure.Services;

var passwordHasher = new PasswordHasher();
string password = "testPassword123";

string hashedPassword = passwordHasher.HashPassword(password);
bool isPasswordVerified = passwordHasher.VerifyPassword(hashedPassword, password);

Console.WriteLine($"Hashed password: {hashedPassword}");
Console.WriteLine($"Is password verified: {isPasswordVerified}");
Console.ReadKey();