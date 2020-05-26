using System.Text.RegularExpressions;

using System;

namespace web.Data
{
    public class User
    {
        public string Id { get; set; }  = "";
        public string Email {get; set; } = "";
        public string FullName {get; set;}  = "";
        public string Password {get; set;}  = "";
    }
}