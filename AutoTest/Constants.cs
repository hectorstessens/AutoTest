namespace AutoTest
{
    public static class Constants
    {
        public enum Images
        {
            Circle,
            Triangule,
            Star,
            Square
        }

        public static Dictionary<string, int> KeyPressImages = new Dictionary<string, int>()
        {
            { "7", 1 },
            { "8", 2 },
            { "4" , 3},
            { "5" , 4 },
        };

        public static Dictionary<Images, int> NumberImages = new Dictionary<Images, int>()
        {
            { Images.Star, 1 },
            { Images.Circle, 2 },
            { Images.Triangule , 3},
            { Images.Square , 4 },
        };
    }
}
