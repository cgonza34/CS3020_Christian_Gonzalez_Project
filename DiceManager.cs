using System;
using System.Collections.Generic;
using System.Text;

namespace Christian_Gonzalez_Project
{
    public class DiceManager : IRollableTokenManager
    {
        private const int MinDice = 1;
        private int NumDice { get; set; }
        private int NumSidesPerDie { get; set; }
        private List<Die> Dice;
        private int TotalRolls { get; set; }
        private int CurrentRolls { get; set; }
        private int[] RollFrequencies;
        private double[] RollAverages;
        private List<List<int>> RollHistory;

        public DiceManager()
        {
            NumDice = MinDice;
            NumSidesPerDie = Die.MinSidesPerDie;

            Dice = new List<Die>();
            for (int i = 0; i < NumDice; i++)
            {
                Dice.Add(new Die(NumSidesPerDie));
            }

            TotalRolls = 0;
            CurrentRolls = 0;

            RollFrequencies = new int[NumSidesPerDie];
            RollAverages = new double[NumSidesPerDie];
            RollHistory = new List<List<int>>();
        } // End Constructor

        private void ResetDice(int numDice, int numSidesPerDie)
        {
            if (numDice < 1 || numSidesPerDie < Die.MinSidesPerDie)
            {
                throw new ArgumentOutOfRangeException(null, $"There must be at least {MinDice} dice with {Die.MinSidesPerDie} sides to roll.");
            }

            NumDice = numDice;
            NumSidesPerDie = numSidesPerDie;

            Dice = new List<Die>(NumDice);
            for (int i = 0; i < NumDice; i++)
            {
                Dice.Add(new Die(NumSidesPerDie));
            }

            CurrentRolls = 0;

            RollFrequencies = new int[NumSidesPerDie];
            RollAverages = new double[NumSidesPerDie];
        } // End ResetDice

        public string RollTokens(List<int> diceInfo)
        {
            if (diceInfo.Count != 2)
            {
                throw new ArgumentException("Invalid token information for rolling dice: must pass number of dice and sides per die.\n");
            }

            if (diceInfo[0] != NumDice || diceInfo[1] != NumSidesPerDie)
            {
                try
                {
                    ResetDice(diceInfo[0], diceInfo[1]);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    return $"{ex.Message}\n";
                }
            }

            List<int> results = new List<int>(NumDice);

            foreach (Die die in Dice)
            {
                results.Add(die.RollToken());
                TotalRolls++;
                CurrentRolls++;
            }

            for (int i = 0; i < NumDice; i++)
            {
                RollFrequencies[results[i] - 1]++;
            }

            for (int i = 0; i < NumSidesPerDie; i++)
            {
                RollAverages[i] = (double)RollFrequencies[i] / CurrentRolls;
            }

            RollHistory.Add(results);

            return $"{string.Join(", ", results)}\n";
        } // End RollTokens

        public string GetStatistics()
        {
            string statistics = new string($"Total dice rolled: {TotalRolls}\n\n");

            statistics += "Roll Frequencies:\n";
            for (int i = 0; i < NumSidesPerDie; i++)
            {
                statistics += $"\t{i + 1} = {RollFrequencies[i]} times\n";
            }
            statistics += "\n";

            statistics += "Roll Averages:\n";
            for (int i = 0; i < NumSidesPerDie; i++)
            {
                statistics += $"\t{i + 1} = {100 * RollAverages[i]:F2}%\n";
            }

            return statistics;
        } // End GetStatistics

        public string SaveHistory(string filepath)
        {
            if (RollHistory.Count == 0)
            {
                return "No history to save!\n";
            }

            try
            {
                using (var sw = new StreamWriter(Path.Combine(filepath, "dice_history.txt")))
                {
                    foreach (List<int> line in RollHistory)
                    {
                        sw.WriteLine(string.Join(",", line));
                    }
                }

                return "History saved!\n";
            }
            catch (DirectoryNotFoundException)
            {
                return "Error! Could not save history: the filepath is invalid.\n";
            }
            catch (IOException)
            {
                return "Error! Could not save history: the file may be in use.\n";
            }
            catch (Exception)
            {
                return "Error! Could not save history.\n";
            }

        } // End SaveHistory
    }
}
