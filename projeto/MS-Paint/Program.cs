using MS_Paint;

char[,] arr = new char[4,6]
{
    { '.', '#', '#', '#', '.', '.'},
    { '.', '#', '.', '.', '#', '.'},
    { '.', '#', '#', '#', '.', '.'},
    { '.', '#', '.', '.', '.', '.'}
};

Console.WriteLine("Tela inicial");
Tela.RenderizarTela(arr);
Console.WriteLine();

Console.WriteLine("Pixel(0, 1) e nova cor 'o'");
BaldeDeTinta.PintarPixel(arr, new Pixel(0, 1), 'o');
arr = Tela.ResetarTela();
Console.WriteLine();

Console.WriteLine("Pixel (1,3) e nova cor 'o'");
BaldeDeTinta.PintarPixel(arr, new Pixel(1, 3), 'o');
arr = Tela.ResetarTela();
Console.WriteLine();

Console.WriteLine("Pixel (1,3) e nova cor '#'");
BaldeDeTinta.PintarPixel(arr, new Pixel(1, 3), '#');

Console.ReadLine();
