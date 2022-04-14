using Microsoft.EntityFrameworkCore;
namespace TetrisApi.Models
{
    public class TetrisItem
    {
        public int Id {get ; set;}
        public string UserName {get ; set;}

        public int Score {get; set;}
        public DateTime LastTimePlay {get ; set;}
    }
}