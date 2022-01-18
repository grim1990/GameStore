using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Serial_Deserial_Games
    {
        public static void Serialize()
        {
            ISerialize<Games> xmlSerialize = new XmlSerializer<Games>(@".\gamesXML.xml");
            xmlSerialize.Serialize(GamesBase._games);
        }

        public static void Deserialize()
        {
            ISerialize<Games> xmlSerialize = new XmlSerializer<Games>(@".\gamesXML.xml");
            GamesBase._games = xmlSerialize.Deserialize();

            if (GamesBase._games == null)
            {
                GamesBase.GetInstance();
            }
            else if (GamesBase._games.Count() == 0)
            {
                GamesBase._games = GamesSample.CreateGamesSample();
            }
        }
    }
}
