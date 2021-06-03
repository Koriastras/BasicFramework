using System;

namespace BasicFramework.Framework.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string DateOfBirth { get; set; }
        public string CurrentAddress { get; set; }

        public static User GetDefaultUser()
        {
            return new User { FirstName = RandomString(9), LastName = RandomString(8), Email = "koriastras@gmail.com", Mobile = RandomNumber(), CurrentAddress = RandomString(100) };


        }
        internal static string RandomString(int stringLength)
        {
            Random random = new Random();

            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }
            return new string(chars);
        }

        public static string RandomNumber()
        {   
            return DateTime.UtcNow.Ticks.ToString().Substring(8);
        }
    }
}
