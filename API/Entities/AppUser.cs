namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }  //public b/c we want entity framework to use them
        public string UserName { get; set; }

    }
}