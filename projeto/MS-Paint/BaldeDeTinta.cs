namespace MS_Paint
{
    public static class Tela
    {
        public static void RenderizarTela(char[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static char[,] ResetarTela()
        {
            return new char[4, 6]
            {
                { '.', '#', '#', '#', '.', '.'},
                { '.', '#', '.', '.', '#', '.'},
                { '.', '#', '#', '#', '.', '.'},
                { '.', '#', '.', '.', '.', '.'}
            };
        }
    }
    public class Pixel
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public static class BaldeDeTinta
    {
        public static void PintarPixel(char[,] arr, Pixel pixel, char cor)
        {
            var prevCor = arr[pixel.X, pixel.Y];

            if (prevCor == cor) return;

            PintarPixelUtil(arr, pixel, prevCor, cor);

            Tela.RenderizarTela(arr);
        }

        public static void PintarPixelUtil(char[,] arr, Pixel pixel, char prevCor, char cor)
        {
            if (pixel.X < 0 || pixel.X >= 4 || pixel.Y < 0 || pixel.Y >= 6) return;
            if (arr[pixel.X, pixel.Y] != prevCor)  return;

            arr[pixel.X, pixel.Y] = cor;

            PintarPixelUtil(arr, new Pixel(pixel.X + 1, pixel.Y), prevCor, cor);
            PintarPixelUtil(arr, new Pixel(pixel.X - 1, pixel.Y), prevCor, cor);
            PintarPixelUtil(arr, new Pixel(pixel.X, pixel.Y + 1), prevCor, cor);
            PintarPixelUtil(arr, new Pixel(pixel.X, pixel.Y - 1), prevCor, cor);
        }
    }
}
