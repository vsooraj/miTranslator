using System;
using System.Collections.Generic;

namespace Ivedix.miTranslator.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Key> Keys { get; set; }

        public Category()
        {
            DateCreated = DateTime.Now;
        }
    }
}
