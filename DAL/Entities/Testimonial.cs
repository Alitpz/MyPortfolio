namespace MyPortfolio.DAL.Entities
{
    public class Testimonial
    {
        public int TestimonialId{ get; set; }

         public string  NameSurname { get; set; }

        public string  Title { get; set; }

        public int Description { get; set; }

        public int ImageUrl { get; set; } 
    }
}
