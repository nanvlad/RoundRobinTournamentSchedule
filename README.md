# Round-Robin Tournament Schedule
A round-robin tournament (or all-play-all tournament) is a competition in which each contestant meets all other contestants in turn.
https://en.wikipedia.org/wiki/Round-robin_tournament

Usage: 
- 
Call GetCalculatedSchedule(int participants) method with a participants count. 
As a result you receive multi-dimensional array with the following structure:
  - First array rows contain Round
  - Second array rows contain Pairs for Round
  - Third array rows contain corresponding participant numbers for every Pair (from 1 to participantsCount)

Test examples can be found in Tests folder
