using System;

namespace SharedModels.DTO
{
    public class CreateDeveloperDTO 
    {
        public string Name { get; set; }
        public string HQ { get; set; }
        public DateTime? Founded { get; set; }
        public string Website { get; set; }
    }
}