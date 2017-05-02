using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BerryAutoService.Models
{
    public class Auto
    {
        [Key]
        public int CarID { get; set; }
        [Required]
        public MerkAuto Merk { get; set; }
        [Required]
        public TypeAuto type { get; set; }
        [Required]
        [Display(Name = "Bouw jaar")]
        public string Bouwjaar { get; set; }
        [Required]
        public string Prijs { get; set; }
        [Required]
        public string Kilometerstand { get; set; }
        [Required]
        public BrandstofAuto Brandstof { get; set; }
        [Required]
        public TransmissieAuto Transmissie { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime APKverloopdatum { get; set; }
        [Required]
        [Display(Name = "Btw ja of nee")]
        public bool BtwJaNee { get; set; }
        [Required]
        public virtual ICollection<File> Files { get; set; }

        [Display(Name = "Extra informatie")]
        public string ExtraInformatie { get; set; }
    }

    public enum MerkAuto
    {
        Audi,
        Toyota,
        Volvo,
        BMW,
        Mercedes,
        Honda,
        Hyundai,
        Ford,
        Fiat,
        Opel,
        Seat,
        Lamborghini,
        Ferrari,
        Bugatti
    }

    public enum TypeAuto
    {
        Sedan,
        Sport,
        Old,
        Family

    }

    public enum BrandstofAuto
    {
        Benzine,
        Diesel,
        Electric
    }

    public enum TransmissieAuto
    {
        Automatic,
        manual
    }
}
