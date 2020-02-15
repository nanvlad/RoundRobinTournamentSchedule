namespace Tournament.Scheduling.Test
{
    using System.Collections;
    using System.Collections.Generic;

    public class RoundRobinNToursScheduleExamples : IEnumerable<object[]>
    {
        private readonly IEnumerable<object[]> _data = new object[][]
        {
            new object[]
            {
                2,
                3,
                new int[3 * 2][][]
                {
                    new int[][] { new[] { 2, 3 } },
                    new int[][] { new[] { 1, 2 } },
                    new int[][] { new[] { 3, 1 } },

                    new int[][] { new[] { 3, 2 } },
                    new int[][] { new[] { 2, 1 } },
                    new int[][] { new[] { 1, 3 } }
                }
            },
            new object[]
            {
                2,
                5,
                new int[5 * 2][][]
                {
                    new int[][] { new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 5, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 3, 1 }, new[] { 4, 5 } },
                    new int[][] { new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 4, 2 }, new[] { 5, 1 } },

                    new int[][] { new[] { 5, 2 }, new[] { 4, 3 } },
                    new int[][] { new[] { 3, 5 }, new[] { 2, 1 } },
                    new int[][] { new[] { 1, 3 }, new[] { 5, 4 } },
                    new int[][] { new[] { 4, 1 }, new[] { 3, 2 } },
                    new int[][] { new[] { 2, 4 }, new[] { 1, 5 } },
                }
            },
            new object[]
            {
                3,
                8,
                new int[7 * 3][][]
                {
                    new int[][] { new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 } },
                    new int[][] { new[] { 8, 5 }, new[] { 6, 4 }, new[] { 7, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 2, 8 }, new[] { 3, 1 }, new[] { 4, 7 }, new[] { 5, 6 } },
                    new int[][] { new[] { 8, 6 }, new[] { 7, 5 }, new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 3, 8 }, new[] { 4, 2 }, new[] { 5, 1 }, new[] { 6, 7 } },
                    new int[][] { new[] { 8, 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 4, 8 }, new[] { 5, 3 }, new[] { 6, 2 }, new[] { 7, 1 } },

                    new int[][] { new[] { 8, 1 }, new[] { 7, 2 }, new[] { 6, 3 }, new[] { 5, 4 } },
                    new int[][] { new[] { 5, 8 }, new[] { 4, 6 }, new[] { 3, 7 }, new[] { 2, 1 } },
                    new int[][] { new[] { 8, 2 }, new[] { 1, 3 }, new[] { 7, 4 }, new[] { 6, 5 } },
                    new int[][] { new[] { 6, 8 }, new[] { 5, 7 }, new[] { 4, 1 }, new[] { 3, 2 } },
                    new int[][] { new[] { 8, 3 }, new[] { 2, 4 }, new[] { 1, 5 }, new[] { 7, 6 } },
                    new int[][] { new[] { 7, 8 }, new[] { 6, 1 }, new[] { 5, 2 }, new[] { 4, 3 } },
                    new int[][] { new[] { 8, 4 }, new[] { 3, 5 }, new[] { 2, 6 }, new[] { 1, 7 } },
                    
                    new int[][] { new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 } },
                    new int[][] { new[] { 8, 5 }, new[] { 6, 4 }, new[] { 7, 3 }, new[] { 1, 2 } },
                    new int[][] { new[] { 2, 8 }, new[] { 3, 1 }, new[] { 4, 7 }, new[] { 5, 6 } },
                    new int[][] { new[] { 8, 6 }, new[] { 7, 5 }, new[] { 1, 4 }, new[] { 2, 3 } },
                    new int[][] { new[] { 3, 8 }, new[] { 4, 2 }, new[] { 5, 1 }, new[] { 6, 7 } },
                    new int[][] { new[] { 8, 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 } },
                    new int[][] { new[] { 4, 8 }, new[] { 5, 3 }, new[] { 6, 2 }, new[] { 7, 1 } },
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