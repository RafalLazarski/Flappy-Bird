using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Assets.Scripts
{
    public static class SaveRecords
    {
        private static string path = Path.Combine(Application.persistentDataPath + "/bestRecord.flappy");

        public static void SaveRecord(PlayerBestScore playerBestScore)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, playerBestScore.Score);
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
