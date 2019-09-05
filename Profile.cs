using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v3
{
    class Profile
    {
        string name;
        byte id;
        List<int> scores = new List<int>();
        List<int> steps = new List<int>();
        List<int> levels = new List<int>();

        public string Name { get => name; set => name = value; }
        public byte Id { get => id; set => id = value; }
        public List<int> Scores { get => scores; set => scores = value; }
        public List<int> Steps { get => steps; set => steps = value; }
        public List<int> Levels { get => levels; set => levels = value; }

        public Profile()
        {
        }
        public int MaxScore(int level)
        {
            int max = Scores[0];
            for (int i = 0; i < Scores.Count; i++)
            {
                if (Levels[i] == level)
                {
                    if (Scores[i] > max) max = Scores[i];
                }
            }
            return max;
        }
        public int MaxStep(int level)
        {
            List<int> step = new List<int>();
            for (int i = 0; i < Scores.Count; i++)
            {
                if (Scores[i] == this.MaxScore(level) && Levels[i] == level) step.Add(Steps[i]);
            }
            return step.Min();
        }
    }
}
