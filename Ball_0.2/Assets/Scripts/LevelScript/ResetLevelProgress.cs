using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevelProgress : MonoBehaviour
{
    public void ResetGameProgress()
    {
        PlayerPrefs.DeleteKey("UnlockedLevelIndex");
        // �������������� �������� ��� ������ ���������, ���� ����������
        // ��������, ����� ������ ����������� ��������, ��������� � �.�.
        // PlayerPrefs.DeleteAll(); // ��� ������ ���� ����������� �������� � PlayerPrefs
    }
}

