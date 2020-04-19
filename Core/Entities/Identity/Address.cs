
namespace Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        
        public string Zipcode { get; set; }

        /*Seguir esta convencion de "AppUserId" hace que entity framework sepa la relacion de estas entidades (one-to-one)*/
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}