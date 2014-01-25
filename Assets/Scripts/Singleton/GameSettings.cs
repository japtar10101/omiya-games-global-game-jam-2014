using UnityEngine;
using System.Collections;

public class GameSettings : ISingletonScript
{
	public const int NumLevels = 1;
	
	public const string NumLevelsUnlockedKey = "numLevelsUnlocked";
	private int mNumLevelsUnlocked = 1;
	
	public int NumLevelsUnlocked
	{
		get
		{
			return mNumLevelsUnlocked;
		}
		set
		{
			if((value >= 1) && (value <= NumLevels))
			{
				mNumLevelsUnlocked = value;
			}
		}
	}
	
	public override void SingletonStart()
	{
		RetrieveFromSettings();
	}
	
	public override void SceneStart()
	{
	}
	
	public void RetrieveFromSettings()
	{
		NumLevelsUnlocked = PlayerPrefs.GetInt(NumLevelsUnlockedKey, 1);
	}
	
	public void SaveSettings()
	{
		PlayerPrefs.SetInt(NumLevelsUnlockedKey, NumLevelsUnlocked);
		PlayerPrefs.Save();
	}
	
	public void ClearSettings()
	{
		NumLevelsUnlocked = 1;
		PlayerPrefs.DeleteAll();
	}
}