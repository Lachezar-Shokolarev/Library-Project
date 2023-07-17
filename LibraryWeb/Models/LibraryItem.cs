using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class LibraryItem
    {
        public int InventoryNumber { get; set; }
        public Title Title { get; set; }
        public string CurrentCondition { get; set; }
        public string Medium { get; set; }
        public string StorageLocation { get; set; }

        public LibraryItem()
        {
            // Empty constructor
        }

        public LibraryItem(int inventoryNumber, Title title, string currentCondition, string medium, string storageLocation)
        {
            InventoryNumber = inventoryNumber;
            Title = title;
            CurrentCondition = currentCondition;
            Medium = medium;
            StorageLocation = storageLocation;
        }
    }
}
