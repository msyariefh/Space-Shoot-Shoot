using Agate.MVC.Base;

namespace SpaceShootShoot.Persistent.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public string[] LeaderNames { get; private set; }
        public int[] LeaderScores { get; private set; }

        public int HighScore { get; private set; }

        public void SetLeaderboard(string[] names, int[] scores)
        {
            string[] _names = names;
            int[] _scores = scores;

            System.Array.Sort(_scores, _names);
            System.Array.Reverse(_names);
            System.Array.Reverse(_scores);
            LeaderNames = _names;
            LeaderScores = _scores;

            if(_scores.Length > 0)
            {
                HighScore = _scores[0];
            }
            else
            {
                HighScore = 0;
            }
            SetDataAsDirty();

            
        }
        public void AddNewHighScore(int position, string name, int score)
        {
            int[] slicedScores = new int[LeaderScores.Length - position - 1];
            string[] slicedNames = new string[LeaderScores.Length - position - 1];

            System.Array.Copy(LeaderScores, position, slicedScores, 0, slicedScores.Length);
            System.Array.Copy(LeaderNames, position, slicedNames, 0, slicedNames.Length);

            LeaderScores[position] = score;
            LeaderNames[position] = name;

            for(int i =0; i< slicedNames.Length; i++)
            {
                LeaderNames[position + i + 1] = slicedNames[i];
                LeaderScores[position + i + 1] = slicedScores[i];
            }

            if (position == 0) HighScore = score;

            SetDataAsDirty();
        }
    }
}

