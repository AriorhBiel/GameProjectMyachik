using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string[] levelNames; // ������ ���� �������
    private int unlockedLevelIndex = 0; // ������ ���������� ����������������� ������

    private void Start()
    {
        // �������� ����������� �������� ���������� ����������������� ������
        unlockedLevelIndex = PlayerPrefs.GetInt("UnlockedLevelIndex", 0);
    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex <= unlockedLevelIndex)
        {
            SceneManager.LoadScene(levelNames[levelIndex]);
        }
        else
        {
            Debug.Log("Level locked. Complete previous levels to unlock.");
            // ����� ����� �������� ��������� ��� ������, �����������, ��� ������� ������������
        }
    }

    public void CompleteLevel(int levelIndex)
    {
        if (levelIndex == unlockedLevelIndex)
        {
            unlockedLevelIndex++;

            // ��������� �������� ����������������� ������
            PlayerPrefs.SetInt("UnlockedLevelIndex", unlockedLevelIndex);
            PlayerPrefs.Save();
        }
    }
}
