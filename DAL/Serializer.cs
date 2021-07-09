using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace JeopardyFinal.DAL
{
    /// <summary>
    /// This class will serialize and de-serialize person objects
    /// </summary>
    static class Serializer
    {
        // Serializes a player array with XMLSerializer
        public static string SerializeNow(Player[] myPlayers)
        {
            XmlSerializer aSerializer = new XmlSerializer(typeof(Player[]));
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            aSerializer.Serialize(sw, myPlayers);
            string serializedValue = sw.GetStringBuilder().ToString();
            return serializedValue;
        }


        // Deserializes data stored in xml format into a player array
        public static Player[] DeSerializeNow(string encodedData)
        {
            Player[] playerArray = new Player[3];
            var serializer = new XmlSerializer(typeof(Player[]));
            using (var stringReader = new StringReader(encodedData))
            {
                playerArray = (Player[])serializer.Deserialize(stringReader);
            }
            return playerArray;
        }
    }
}