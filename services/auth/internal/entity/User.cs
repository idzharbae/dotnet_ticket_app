using System.Text.RegularExpressions;

using System;

namespace AuthApp.Internal.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email {get; set; }
        public string FullName {get; set;}
        public string Password {get; set;}

        public bool ValidateEmail() {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return RegexMatch(this.Email, pattern);
        }
        public bool ValidatePassword() {
            string pattern = @"^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]))";
            return RegexMatch(this.Password, pattern);
        }
        bool RegexMatch(string input, string pattern) {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            return match.Success;
        }
    }
}