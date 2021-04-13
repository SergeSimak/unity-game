using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
	public class DoSave : MonoBehaviour
	{
        // Save object and return to menu
        private void OnTriggerEnter2D(Collider2D playerCollider) 
		{
			if (playerCollider.CompareTag("Player")) 
			{
				SaveGame(playerCollider);
				SceneManager.LoadScene("MainMenu");
			}
		}

		public void SaveGame(Collider2D playerCollider)
		{
			PlayerData playerData = new PlayerData();
			int coins = playerData.PlayerCoins;
			// Save with PlayerPrefs 
			PlayerPrefs.SetString("PlayerName", PlayerController.playerName);
			PlayerPrefs.SetString("PlayerCoins", coins.ToString());
 			PlayerPrefs.Save();

			// Save using persistent data		
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			FileStream file;

			if(File.Exists(Application.persistentDataPath + "/gameSave.dat"))
			{
				file = File.OpenWrite(Application.persistentDataPath + "/gameSave.dat");			
			}    	
			else
			{
				file = File.Create(Application.persistentDataPath + "/gameSave.dat");
			}

			binaryFormatter.Serialize(file, playerData);
    		file.Close();
		}
	}
}