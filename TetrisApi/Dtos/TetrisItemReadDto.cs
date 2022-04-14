using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace  TetrisApi.Dtos 
{
    public class TetrisDtos
    {
        [Required]
        public int Id{get;set;}
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public DateTime LastTimePlay {get; set;}

    }
}
