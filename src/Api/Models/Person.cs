namespace Api.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public static Person Create(string name, string email)
            => new Person(name, email);
    }
}