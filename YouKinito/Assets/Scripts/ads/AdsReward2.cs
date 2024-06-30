
using UnityEngine;
using YG;

public class AdsReward2 : MonoBehaviour
{
  
    public GameObject OpenScene;


    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // ����������� ����� ��������� �������
    public void Rewarded(int id)
    {
        // ���� ID = 1, �� ����� "+100 �����"
        if (id == 3)
        {
            OpenScene.SetActive(true);
        }

    }

    // ����� ��� ������ ����� �������
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }
}
