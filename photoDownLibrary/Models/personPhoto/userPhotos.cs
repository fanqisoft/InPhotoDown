using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoDownLibrary.Models
{
    public class userPhotos
    {
        public string id { get; set; }
        public List<photo> photos { get; set; }
        public string user_id { get; set; }
        public video video { get; set; }
    }
}
