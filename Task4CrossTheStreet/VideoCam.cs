using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class VideoCam
    {
        private Dictionary<string, List<Stat>> statistic = new Dictionary<string, List<Stat>>();

        public void FillStatistic(object sender, HumanActionEventArgs e)
        {
            if (sender != null)
            {
                List<Stat> humansStat;
                if (!statistic.TryGetValue(e.SvetoforLight, out humansStat))
                {
                    humansStat = new List<Stat>();
                    humansStat.Add(new Stat((Human)sender, e.Date, e.SvetoforLight));
                    statistic.Add(e.SvetoforLight, humansStat);
                }
                else
                {
                    statistic[e.SvetoforLight].Add(new Stat((Human)sender, e.Date, e.SvetoforLight));
                }
            }            
        }
/// <summary>
/// Full Stat
/// </summary>
/// <returns></returns>
        public string GetStatistic()
        {
            StringBuilder result = new StringBuilder();
            foreach (KeyValuePair<string, List<Stat>> pair in statistic)
            {
                result.AppendLine(String.Format("At {0} crossed the street {1} humans", pair.Key, pair.Value.Count));
                foreach (Stat st in pair.Value)
                {
                    result.AppendLine(String.Format("At {0}, crossed the road : {1} at {2}",st.Light, st.Human.Name, st.Date.Date));
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Stat by Lights
        /// </summary>
        /// <param name="light">Light color</param>
        /// <returns></returns>
        public string GetStatistic(string light)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format(" At {0} crossed the street {1} humans ", light, statistic[light].Count));
            foreach (Stat st in statistic[light])
            {
                result.AppendLine(String.Format(" At {0}, crossed the road : {1} at {2} ", light, st.Human.Name, st.Date.Date));
            }
            return result.ToString(); ;
        }
    }
}
