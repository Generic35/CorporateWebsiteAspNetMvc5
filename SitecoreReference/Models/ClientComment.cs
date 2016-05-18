using Newtonsoft.Json;

namespace SitecoreReference.Models
{
    public class ClientComment
    {

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Role { get; set; }


        public virtual string ImageUrl { get; set; }


        public virtual string Comment { get; set; }
    }
}