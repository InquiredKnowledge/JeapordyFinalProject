using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;
using System.Data.SqlClient;

namespace JeopardyFinal.DAL
{
    static class DataAdapter
    {
        // SqlConnection to database and name of XML file
        static SqlConnection oConn = new SqlConnection(@"Data Source = stusql-cis151-101-fa20.cimq4ah3jd04.us-east-2.rds.amazonaws.com;
        Initial Catalog = ik0920485; User Id = ik0920485; Password=920485");
        private static string xmlFileName = "XMLQuestions.xml";

        /// <summary>
        /// XML Method
        /// Grabs all questions from xml file and converts into question info class
        /// </summary>
        /// <returns></returns>
        public static List<QuestionInfo> LoadCategoriesXML()
        {
            var questionsList = new List<QuestionInfo>();
            try
            {
                var xml = XDocument.Load(xmlFileName).Root;
                QuestionInfo category = new QuestionInfo("null");

                foreach (var i in xml.Elements())
                {
                    foreach(var e in i.Elements())
                    {
                        category = new QuestionInfo(i.Attribute("title").Value.ToString());
                        category.Question = e.Elements().Where(x => x.Name == "question").FirstOrDefault().Value.ToString();
                        category.Answer = e.Elements().Where(x => x.Name == "answer").FirstOrDefault().Value.ToString();
                        category.Value = Convert.ToInt32(e.Elements().Where(x => x.Name == "value").FirstOrDefault().Value);

                        questionsList.Add(category);
                    }
                }

                return questionsList;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Connection Method using oConn string
        /// </summary>
        private static void Connect()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Closes connection of oConn string
        /// </summary>
        private static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Inserts serialized player[] into database as a string.
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public static int InsertGameData(Player[] players)
        {
            int id = 0;
            string data = Serializer.SerializeNow(players);
            string sqlIns = "INSERT INTO Game(Data) VALUES(@data); SELECT CAST(scope_identity() AS int);";
            Connect();

            try
            {
                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn); 
                cmdIns.Parameters.AddWithValue("@data", data);

                id = (int)cmdIns.ExecuteScalar();                   

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return id;
        }

        /// <summary>
        /// Grabs all games from database with oConn string
        /// Deserializes them and stores the player arrays into an arraylist
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetAllGames() 
        {
            ArrayList allGames = new ArrayList();
            Connect();
            try
            {
                string sql = "SELECT * FROM Game";

                SqlCommand cmd = new SqlCommand(sql, oConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Player[] Game = new Player[3];
                    Game = Serializer.DeSerializeNow((string)reader["Data"]);
                    allGames.Add(Game);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return allGames;
        }
    }
}
