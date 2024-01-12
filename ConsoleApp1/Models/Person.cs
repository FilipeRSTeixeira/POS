namespace ConsoleApp1.Models
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int AddressId { get; set; }
        public Adress Adress { get; set; }
        public string NIF { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate => DateTime.Now;
        public DateTime ModifiedDate = DateTime.Now;
    }
}