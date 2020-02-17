namespace TournamentScheduling.Test
{
    using FluentAssertions;
    using Xunit;

    public class RoundRobinScheduleTest
    {
        private readonly RoundRobinAlgorithm _algorithm = new RoundRobinAlgorithm();

        [Theory]
        [ClassData(typeof(RoundRobinScheduleExamples))]
        public void ShouldGetSingleRoundRobinSchedule(int participants, int[][][] expectedSchedule)
        {
            var schedule = _algorithm.GetCalculatedSchedule(participants);
            schedule.Length.Should().Be(expectedSchedule.Length);
            schedule[0].Length.Should().Be(expectedSchedule[0].Length);
            schedule[0][0].Length.Should().Be(expectedSchedule[0][0].Length);
            for (int i = 0; i < schedule.Length; i++)
            {
                for (int j = 0; j < schedule[i].Length; j++)
                {
                    for (int k = 0; k < schedule[i][j].Length; k++)
                    {
                        schedule[i][j][k].Should().Be(expectedSchedule[i][j][k]);
                    }
                }
            }
        }

        [Theory]
        [ClassData(typeof(RoundRobinNToursScheduleExamples))]
        public void ShouldGetNToursRoundRobinSchedule(int tours, int participants, int[][][] expectedSchedule)
        {
            var schedule = _algorithm.GetCalculatedSchedule(tours, participants);
            schedule.Length.Should().Be(expectedSchedule.Length);
            schedule[0].Length.Should().Be(expectedSchedule[0].Length);
            schedule[0][0].Length.Should().Be(expectedSchedule[0][0].Length);
            for (int i = 0; i < schedule.Length; i++)
            {
                for (int j = 0; j < schedule[i].Length; j++)
                {
                    for (int k = 0; k < schedule[i][j].Length; k++)
                    {
                        schedule[i][j][k].Should().Be(expectedSchedule[i][j][k]);
                    }
                }
            }
        }
    }
}