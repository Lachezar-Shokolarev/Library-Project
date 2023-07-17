using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Section()
        {
            // Empty constructor
        }

        public Section(int sectionId, string name, string description)
        {
            SectionId = sectionId;
            Name = name;
            Description = description;
        }
    }
}
