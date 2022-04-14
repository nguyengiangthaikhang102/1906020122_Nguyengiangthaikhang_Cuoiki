namespace TetrisApi.Dtos 
{
    public class TetrisItemCreatedDto
    {
        public string UserName {get ; set;}

        public int Score {get; set;}
        public DateTime LastTimePlay {get ; set;}
    }
}