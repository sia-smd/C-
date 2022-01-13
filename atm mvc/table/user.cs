using System.ComponentModel.DataAnnotations;
namespace atm_mvc
{
    public class user 
    {
        [Key]
        public int Userid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Numericid { get; set; }
        public string Mobile { get; set; }

    }


}