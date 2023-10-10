
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a password that is at least 8 characters long and has: \n 1. At least one upper case letter \n 2. At least one lower case letter \n 3. At least one number  \n 4. At least one special character. ");
        string password = Console.ReadLine();
        bool hasUppercaseLetters = false;
        bool hasLowercaseLetters = false;
        bool has8Letters=false;
        bool hasDigit = false;
        bool hasSpecialCharacter = false;
        bool isThePasswordStrong = false;
        while (!isThePasswordStrong)
        {
            foreach (char c in password)
            {
                if (password.Length >= 8)
                {
                    has8Letters = true; 
                }
                if (c >= 'A' && c <= 'Z')
                {
                    hasUppercaseLetters = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    hasLowercaseLetters = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    hasDigit = true;
                }
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    hasSpecialCharacter = true;
                }
                isThePasswordStrong = hasDigit && hasLowercaseLetters && hasUppercaseLetters && hasSpecialCharacter && has8Letters;
            }
            if (isThePasswordStrong)
            {
                Console.WriteLine("Your password meets the requirements");
                break;
            }
            else
            {
                if (has8Letters != true)
                {
                    Console.WriteLine("Your password needs to have at least 8 symbols");                }
                if (hasUppercaseLetters == false)
                {
                    Console.WriteLine("Your password needs to have at least one upper case letter"); 
                }
                 if (hasLowercaseLetters == false)
                {
                    Console.WriteLine("Your password needs to have at least one lower case letter");
                }
                 if (hasDigit==false)
                {
                    Console.WriteLine("Your password needs to have at least one digit");
                }
                 if (hasSpecialCharacter==false)
                {
                    Console.WriteLine("Your password needs to have at least one special character");
                }
                Console.WriteLine("Please try again with a stornger one:");
                password = Console.ReadLine();
            }
        }
    }

    
       

    
}
