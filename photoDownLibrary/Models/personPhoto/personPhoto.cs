using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoDownLibrary.Models
{
    /// <summary>
    /// 相册子实体类
    /// </summary>
    public class personPhoto
    {
        public string code { get; set; }
        public personData data { get; set; }
        public bool succ { get; set; }
        public string timestamp { get; set; }
    }
}
