namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Square : IHasArea
    {
        private decimal length;
        public Square(decimal sideLength)
        {
            length = sideLength;
            Name = "Square";
        }

        public decimal CalculateArea()
        {
            return length * length;
        }

        public string Name { get; }
    }
}