using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Assets.Scripts
{
    internal static class SaveRecords
    {
        private static string path = Path.Combine(Application.persistentDataPath + "bestRecord.flappy");

        public static void SaveRecord(PlayerBestScore score)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                PlayerBestScore playerBestScore = new PlayerBestScore();

                formatter.Serialize(stream, playerBestScore);
                stream.Close();
            }
        }

        public static PlayerBestScore LoadRecord()
        {
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using(FileStream stream = new FileStream(path, FileMode.Open))
                {
                    PlayerBestScore playerBestScore = formatter.Deserialize(stream) as PlayerBestScore;

                    stream.Close();

                    return playerBestScore;
                }
            }
            else
            {
                Debug.LogError("Cannot save file in " + path);
                return null;
            }
        }
    }
}
