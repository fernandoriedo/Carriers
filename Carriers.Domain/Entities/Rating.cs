namespace Carriers.Domain.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string Comment { get; set; }
        public int Note { get; set; }
        public bool Available { get; set; }
        public int CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
