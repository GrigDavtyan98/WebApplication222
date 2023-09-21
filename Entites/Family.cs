using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication222.Entites
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public FamilyPersonStatusEnum PersonStatus { get; set; }
        [ForeignKey("Animal")]
        public int AnimalId { get; set; }
        
        public Animal Animal { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }


        public Person Person { get; set; }

    }
}
