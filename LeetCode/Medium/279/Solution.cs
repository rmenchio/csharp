namespace LeetCode.Medium._279
{
    // 1 4 9 16 25
    public class Solution
    {
        public int NumSquares(int n)
        {
            if (n == 0) return 0;

            // Inicializa uma fila para a busca em largura
            Queue<int> queue = new Queue<int>();

            // Adiciona o número inicial na fila
            queue.Enqueue(n);

            // Inicializa um conjunto para armazenar os números visitados
            HashSet<int> visited = new HashSet<int>();

            // Inicializa o nível da busca
            int level = 0;

            while (queue.Count > 0)
            {
                // Incrementa o nível
                level++;

                // Obtém o tamanho atual da fila
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    // Remove o número da fila
                    int current = queue.Dequeue();

                    // Tenta subtrair todos os quadrados perfeitos menores ou iguais a 'current'
                    for (int j = 1; j * j <= current; j++)
                    {
                        int diff = current - j * j;

                        // Se a diferença for 0, significa que encontramos a soma de quadrados
                        if (diff == 0)
                            return level;

                        // Se a diferença não estiver no conjunto de visitados, adicionamos à fila
                        if (!visited.Contains(diff))
                        {
                            queue.Enqueue(diff);
                            visited.Add(diff);
                        }
                    }
                }
            }

            return -1; // Não deveria chegar aqui
        }
    }
}