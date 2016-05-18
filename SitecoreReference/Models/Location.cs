using Newtonsoft.Json;

namespace SitecoreReference.Models
{
    public class Location
    {

        public virtual int Id { get; set; }

        public virtual string Street { get; set; }

        public virtual string City { get; set; }

        public virtual string State { get; set; }

        public virtual string Zip { get; set; }

        public virtual string Phone { get; set; }
 
        public virtual string Email { get; set; }
    }
}