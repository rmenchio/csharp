namespace LeetCode.Easy._1700
{
    // 1,1,1 (estudantes)
    // 0,1,1 (sanduiches)
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> estudantes = new(students);
            Stack<int> sanduiches = new(sandwiches.Reverse());

            var tamanhoInicial = students.Length * students.Length;

            for (int i = 0; i < tamanhoInicial; i++)
            {
                if (sanduiches.Count.Equals(0))
                    break;

                if (estudantes.Peek().Equals(sanduiches.Peek()))
                {
                    estudantes.Dequeue();
                    sanduiches.Pop();
                }
                else
                {
                    estudantes.Enqueue(estudantes.Dequeue());
                }
            }

            return estudantes.Count;
        }
    }
}