namespace Onețiu_Denisa_Carmen_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public ICollection<Authors>? Author { get; set; }
    }
}
