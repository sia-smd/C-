using System.ComponentModel.DataAnnotations;
namespace atm_mvc
{
    public class account 
    {
        [Key]
        public int Account_Id { get; set; }
        public string Account_number { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public int Credit { get; set; }

    }


}