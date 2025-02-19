using System;
using System.Collections.Generic;
using System.Linq;

    class Voting
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
            List<KeyValuePair<string, int>> orderOfVotes = new List<KeyValuePair<string, int>>();

            CastVote("Alice", votes, sortedResults, orderOfVotes);
            CastVote("Bob", votes, sortedResults, orderOfVotes);
            CastVote("Alice", votes, sortedResults, orderOfVotes);
            CastVote("Charlie", votes, sortedResults, orderOfVotes);
            CastVote("Bob", votes, sortedResults, orderOfVotes);
            CastVote("Alice", votes, sortedResults, orderOfVotes);

            Console.WriteLine("Voting Results (Sorted by Candidate Name):");
            DisplayResults(sortedResults);

            Console.WriteLine("Voting Results (In Order of Votes Cast):");
            DisplayResultsInOrder(orderOfVotes);

            Console.WriteLine("Final Vote Count:");
            DisplayVoteCount(votes);
        }

        static void CastVote(string candidate, Dictionary<string, int> votes, SortedDictionary<string, int> sortedResults, List<KeyValuePair<string, int>> orderOfVotes)
        {
            if (!votes.ContainsKey(candidate))
            {
                votes[candidate] = 0;
            }
            votes[candidate]++;

            if (!sortedResults.ContainsKey(candidate))
            {
                sortedResults[candidate] = 0;
            }
            sortedResults[candidate]++;

            orderOfVotes.Add(new KeyValuePair<string, int>(candidate, votes[candidate]));
        }

        static void DisplayResults(SortedDictionary<string, int> sortedResults)
        {
            foreach (var result in sortedResults)
            {
                Console.WriteLine(result.Key + ": " + result.Value + " votes");
            }
        }

        static void DisplayResultsInOrder(List<KeyValuePair<string, int>> orderOfVotes)
        {
            foreach (var result in orderOfVotes)
            {
                Console.WriteLine(result.Key + ": " + result.Value + " votes");
            }
        }

        static void DisplayVoteCount(Dictionary<string, int> votes)
        {
            foreach (var vote in votes)
            {
                Console.WriteLine(vote.Key + ": " + vote.Value + " votes");
            }
        }
    }