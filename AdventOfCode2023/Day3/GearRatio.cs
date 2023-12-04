using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Day3
{
    public class GearRatio
    {
        public List<List<char>> Matrix { get; set; }

        public void PopulateMatrix(string filepath = @"Day3/Input.txt")
        {
            Matrix = new List<List<char>>();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                List<char> row = new List<char>();
                foreach (char c in line)
                {
                    row.Add(c);
                }
                Matrix.Add(row);
            }

        }

        private static bool IsSymbol(char c)
        {
            if (char.IsNumber(c))
            {
                return false;
            }

            if (c.ToString() == ".")
            {
                return false;
            }
            return true;
        }

        public int SumPartNumbers()
        {
            int sum = 0;
            Dictionary<int, bool> partNumbers = new Dictionary<int, bool>();
            for (int i = 0; i < Matrix.Count; i++)
            {
                string numStr = "";
                bool isValid = false;
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    // check for numbers
                    if (char.IsNumber(Matrix[i][j]))
                    {
                        numStr += Matrix[i][j];

                        // check if this character is valid
                        if (i > 0)
                        {
                            if (IsSymbol(Matrix[i - 1][j]))
                            {
                                isValid = true;
                                continue;
                            }
                            if (j > 0 && IsSymbol(Matrix[i - 1][j - 1]))
                            {
                                isValid = true;
                                continue;
                            }
                            if (j < Matrix[i].Count - 1 && IsSymbol(Matrix[i - 1][j + 1]))
                            {
                                isValid = true;
                                continue;
                            }
                        }

                        if (j > 0 && IsSymbol(Matrix[i][j - 1]))
                        {
                            isValid = true;
                            continue;
                        }
                        if (j < Matrix[i].Count - 1 && IsSymbol(Matrix[i][j + 1]))
                        {
                            isValid = true;
                            continue;
                        }

                        if (i < Matrix.Count - 1)
                        {
                            if (IsSymbol(Matrix[i + 1][j]))
                            {
                                isValid = true;
                                continue;
                            }
                            if (j > 0 && IsSymbol(Matrix[i + 1][j - 1]))
                            {
                                isValid = true;
                                continue;
                            }
                            if (j < Matrix[i].Count - 1 && IsSymbol(Matrix[i + 1][j + 1]))
                            {
                                isValid = true;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if (numStr.Length > 0)
                        {
                            if (isValid)
                            {
                                int num = Convert.ToInt32(numStr);
                                sum += num;
                                if (!partNumbers.ContainsKey(num))
                                {
                                    partNumbers.Add(num, true);
                                }
                            }                            
                        }
                        numStr = "";
                        isValid = false;
                        continue;
                    }

                    if (j == Matrix[i].Count - 1)
                    {
                        if (numStr.Length > 0)
                        {
                            if (isValid)
                            {
                                int num = Convert.ToInt32(numStr);
                                sum += num;
                                if (!partNumbers.ContainsKey(num))
                                {
                                    partNumbers.Add(num, true);
                                }
                            }
                        }
                        numStr = "";
                        isValid = false;
                        
                    }

                    
                }
            }

            return sum;
        }
    }

}
