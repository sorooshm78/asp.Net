namespace OdeToFood.Core
{
    public enum CuisineType
    {
        None,
        Iran,
        Italian,
        Mexican,
        Indian

    }
    public class Restaurant
    {
        public CuisineType Cuisine { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
