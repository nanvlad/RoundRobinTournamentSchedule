namespace Tournament.Scheduling.Test
{
    using System.Collections;
    using System.Collections.Generic;

    public class RoundRobinScheduleExamples : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                5,
                new int[5][][]
                {
                    new int[][] { new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 5, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 3, 1 }, new[] { 4, 5 } },
                    new int[][] { new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 4, 2 }, new[] { 5, 1 } },
                }
            },
            new object[]
            {
                8,
                new int[7][][]
                {
                    new int[][] { new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 } },
                    new int[][] { new[] { 8, 5 }, new[] { 6, 4 }, new[] { 7, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 2, 8 }, new[] { 3, 1 }, new[] { 4, 7 }, new[] { 5, 6 } },
                    new int[][] { new[] { 8, 6 }, new[] { 7, 5 }, new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 3, 8 }, new[] { 4, 2 }, new[] { 5, 1 }, new[] { 6, 7 } },
                    new int[][] { new[] { 8, 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 4, 8 }, new[] { 5, 3 }, new[] { 6, 2 }, new[] { 7, 1 } },
                }
            },
            new object[]
            {
                9,
                new int[9][][]
                {
                    new int[][] { new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 }, new[] { 5, 6 } },
                    new int[][] { new[] { 7, 5 }, new[] { 8, 4 }, new[] { 9, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 3, 1 }, new[] { 4, 9 }, new[] { 5, 8 }, new[] { 6, 7 } },
                    new int[][] { new[] { 8, 6 }, new[] { 9, 5 }, new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 4, 2 }, new[] { 5, 1 }, new[] { 6, 9 }, new[] { 7, 8 } },
                    new int[][] { new[] { 9, 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 5, 3 }, new[] { 6, 2 }, new[] { 7, 1 }, new[] { 8, 9 } },
                    new int[][] { new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 } },
                    new int[][] { new[] { 6, 4 }, new[] { 7, 3 }, new[] { 8, 2 }, new[] { 9, 1 } },
                }
            },
            new object[]
            {
                12,
                new int[11][][]
                {
                    new int[][] { new[] { 1, 12 }, new[] { 2, 11 }, new[] { 3, 10 }, new[] { 4, 9 }, new[] { 5, 8 }, new[] { 6, 7 } },
                    new int[][] { new[] { 12, 7 }, new[] { 8, 6 }, new[] { 9, 5 }, new[] { 10, 4 }, new[] { 11, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 2, 12 }, new[] { 3, 1 }, new[] { 4, 11 }, new[] { 5, 10 }, new[] { 6, 9 }, new[] { 7, 8 } },
                    new int[][] { new[] { 12, 8 }, new[] { 9, 7 }, new[] { 10, 6 }, new[] { 11, 5 }, new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 3, 12 }, new[] { 4, 2 }, new[] { 5, 1 }, new[] { 6, 11 }, new[] { 7, 10 }, new[] { 8, 9 } },
                    new int[][] { new[] { 12, 9 }, new[] { 10, 8 }, new[] { 11, 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 4, 12 }, new[] { 5, 3 }, new[] { 6, 2 }, new[] { 7, 1 }, new[] { 8, 11 }, new[] { 9, 10 } },
                    new int[][] { new[] { 12, 10 }, new[] { 11, 9 }, new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 } },
                    new int[][] { new[] { 5, 12 }, new[] { 6, 4 }, new[] { 7, 3 }, new[] { 8, 2 }, new[] { 9, 1 }, new[] { 10, 11 } },
                    new int[][] { new[] { 12, 11 }, new[] { 1, 10 }, new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 }, new[] { 5, 6 } },
                    new int[][] { new[] { 6, 12 }, new[] { 7, 5 }, new[] { 8, 4 }, new[] { 9, 3 }, new[] { 10, 2 }, new[] { 11, 1 } },
                }
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}