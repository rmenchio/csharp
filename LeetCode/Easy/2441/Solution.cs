namespace LeetCode.Easy._2441
{
    public class Solution
    {
        public int FindMaxK(int[] nums)
        {
            List<int> lista = new(nums);

            var positivos = lista.Where(i => i > 0).ToList();
            var negativos = lista.Where(i => i < 0).ToList();

            negativos.Sort();

            positivos.Sort();
            positivos.Reverse();

            foreach(int i in negativos)
            {
                foreach(int j in positivos)
                {
                    if (Math.Abs(i) == j)
                        return j;

                    if (Math.Abs(i) > j)
                        break;
                }
            }

            return -1;
        }
    }
}