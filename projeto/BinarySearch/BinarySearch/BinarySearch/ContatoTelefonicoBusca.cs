namespace BinarySearch
{
    public static class ContatoTelefonicoBusca
    {
        public static string BuscaTelefone(this List<ContatoTelefonico> lista, string nome)
        {
            int minNum = 0;
            int maxNum = lista.Count - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;

                var result = String.Compare(nome, lista[mid].Nome);

                if (result == 0)
                {
                    return lista[mid].Telefone;
                }
                else if (result < 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return string.Empty;
        }
    }
}