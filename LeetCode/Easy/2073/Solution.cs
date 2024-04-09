namespace LeetCode.Easy._2073
{
	public class Solution
	{
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int tempo = 0;
            bool incompleto = true;

            while (incompleto)
            {
                for(int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] <= 0)
                        continue;
                    else
                    {
                        tempo++;
                        tickets[i]--;

                        if (tickets[k] == 0)
                        {
                            incompleto = false;
                            break;
                        }
                            
                    }
                }
            }

            return tempo;
        }
    }
}