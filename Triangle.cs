namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Triangle : IHasArea
    {
        private readonly decimal baseLength;
        private readonly decimal height;

        public Triangle(decimal baseLength, decimal height)
        {
            this.baseLength = baseLength;
            this.height = height;
            Name = "Triangle";
        }
        public decimal CalculateArea()
        {
            return .5M * baseLength * height;
        }

        public string Name { get; }
    }
}