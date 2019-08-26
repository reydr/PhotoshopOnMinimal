


namespace Desktop_PhotoshopOnMin.Data
{
    public class Picture : System.ICloneable
    {
        public uint Width { get; set; }
        public uint Height { get; set; }

        public Pixel[,] Pixels { get; set; }

        public object Clone()
        {
            Pixel[,] ClonePixels = new Pixel[Width, Height];
            for (uint x = 0; x < Width; x++)
            {
                for (uint y = 0; y < Height; y++)
                {
                    ClonePixels[x, y] = (Pixel)Pixels[x, y].Clone();
                }
            }

            return new Picture() { Width = this.Width, Height = this.Height, Pixels = ClonePixels };
        }
    }
}
