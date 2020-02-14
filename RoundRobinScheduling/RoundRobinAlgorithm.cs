namespace Tournament.Scheduling
{
    using System.Linq;
    using System.Threading.Tasks;

    public class RoundRobinAlgorithm
    {
        public int[][][] GetCalculatedSchedule(int participants)
        {
            int oddShift = participants % 2;
            int rounds =  participants - 1 + oddShift;
            int halfSize = participants / 2;
            int[] numbers = Enumerable.Range(1, participants).ToArray();
            int[][][] schedule = new int[rounds][][];
            for (int i = 0; i < rounds; i++)
            {
                schedule[i] = new int[halfSize][];
                for (int j = 0; j < schedule[i].Length; j++)
                {
                    schedule[i][j] = new int[2];
                }
            }

            Parallel.Invoke(FillOddRoundsWhite, FillEvenRoundsBlack, FillEvenRoundsWhite, FillOddRoundsBlack);
            return schedule;

            void FillOddRoundsWhite()
            {
                for (int round = 1, counter = 1; round <= rounds; round += 2, counter++)
                {
                    for (int j = counter, index = 0; j < halfSize + counter; j++, index++)
                    {
                        int number = numbers[(j - 1 + oddShift) % numbers.Length];
                        schedule[round - 1][index][0] = number;
                    }
                }
            }

            void FillEvenRoundsBlack()
            {
                for (int round = 2, counter = 2; round <= rounds; round += 2, counter++)
                {
                    for (int j = halfSize + counter - 1, index = 0; j >= counter; j--, index++)
                    {
                        int number = numbers[(j - 1) % numbers.Length];
                        schedule[round - 1][index][1] = number;
                    }
                }
            }

            void FillEvenRoundsWhite()
            {
                int count = numbers.Length - 1 + oddShift;
                for (int round = rounds - 1, counter = 0; round > 0; round -= 2, counter--)
                {
                    if (oddShift == 0)
                    {
                        schedule[round - 1][0][0] = numbers.Last();
                    }

                    for (int j = counter, index = 1 - oddShift; j < halfSize + counter - 1 + oddShift; j++, index++)
                    {
                        int number = numbers[(j + count) % count];
                        schedule[round - 1][index][0] = number;
                    }
                }
            }

            void FillOddRoundsBlack()
            {
                int count = numbers.Length - 1 + oddShift;
                for (int round = rounds, counter = -1; round > 0; round -= 2, counter--)
                {
                    if (oddShift == 0)
                    {
                        schedule[round - 1][0][1] = numbers.Last();
                    }

                    for (int j = halfSize + counter - 1 + oddShift, index = 1 - oddShift; j > counter; j--, index++)
                    {
                        int number = numbers[(j + count) % count];
                        schedule[round - 1][index][1] = number;
                    }
                }
            }
        }
    }
}