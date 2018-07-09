using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Username { get; protected set; }
        public string Fullname { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public DateTime? CreatedAt { get; protected set;}
        public DateTime? UpdateAt { get; protected set;}

        protected User()
        {
        }

        public User(string email, string username,string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Username = username;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
        public void SetUsername(string username)
        {
            if(string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("username can not be emty");
            }
            if(Username == username)
            {
                return;
            }
            Username = username.ToLowerInvariant();
            UpdateAt = DateTime.UtcNow;
        }
        
        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email can not be emty");
            }
            if(Email == email)
            {
                return;
            }
            Email = email.ToLowerInvariant();
            UpdateAt = DateTime.UtcNow;
        }

        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password can not be empty.");
            }
            if(password.Length < 4)
            {
                throw new Exception("Password must be greater than 4.");
                
            }
            if(password.Length > 80)
            {
                throw new Exception("Password must be less than 80.");
                
            }
            if(Password==password)
            {
                return;
            }
            Password = password;
            UpdateAt = DateTime.UtcNow;
        }

    }
}
