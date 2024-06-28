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

// Подписываемся на событие открытия рекламы в OnEnable
private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// Отписываемся от события открытия рекламы в OnDisable
private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

// Подписанный метод получения награды
void Rewarded(int id)
{
    // Если ID = 1, то выдаём "+100 монет"
    if (id == 1)
        {
            FrendlyOpenScene.SetActive(true);
            FrendlyCloseScene.SetActive(false);
        }

    // Если ID = 2, то выдаём "+оружие".
    else if (id == 2)
        {
            DestrOpenScene.SetActive(true);
            DestrCloseScene.SetActive(false);
        }
      
}

// Метод для вызова видео рекламы
public void ExampleOpenRewardAd(int id)
{
    // Вызываем метод открытия видео рекламы
    YandexGame.RewVideoShow(id);
}
}
