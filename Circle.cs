namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Circle : IHasArea
    {
        private readonly decimal radius;

        public Circle(decimal radius)
        {
            this.radius = radius;
            Name = "Circle";
        }
        public string Name{get;}

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * radius * radius;
        }
    }


}