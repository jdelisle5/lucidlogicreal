namespace LucidLogic.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string HTML { get; set; }

        public string GoogleDocUnqiueID { get; set;}
        
        //Principal Entity
        public int BlogId { get; set; }
        public Blog Blog {get; set;}

    }
}