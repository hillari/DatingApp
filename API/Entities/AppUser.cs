namespace API.Entities
{
    public class AppUser
    {
        public int ID { get; set; }  //public b/c we want entity framework to use them
        public string UserName { get; set; }

    }
}