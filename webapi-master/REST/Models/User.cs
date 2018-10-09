using System;
using System.Runtime.Serialization;

namespace REST.Models
{
    [DataContract]
    public class User
    {
        [DataMember(Name ="id")]
        public Guid Id { get; set; }
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
        public User(string firstName, string lastName, int age, string gender)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }
    }
}