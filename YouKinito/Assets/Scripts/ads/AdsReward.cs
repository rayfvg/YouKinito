using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

 

public class AdsReward : MonoBehaviour
{
    public GameObject FrendlyCloseScene;
    public GameObject FrendlyOpenScene;


    public GameObject DestrOpenScene;
    public GameObject DestrCloseScene;

// ������������� �� ������� �������� ������� � OnEnable
private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// ������������ �� ������� �������� ������� � OnDisable
private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

// ����������� ����� ��������� �������
void Rewarded(int id)
{
    // ���� ID = 1, �� ����� "+100 �����"
    if (id == 1)
        {
            FrendlyOpenScene.SetActive(true);
            FrendlyCloseScene.SetActive(false);
        }

    // ���� ID = 2, �� ����� "+������".
    else if (id == 2)
        {
            DestrOpenScene.SetActive(true);
            DestrCloseScene.SetActive(false);
        }
      
}

// ����� ��� ������ ����� �������
public void ExampleOpenRewardAd(int id)
{
    // �������� ����� �������� ����� �������
    YandexGame.RewVideoShow(id);
}
}
