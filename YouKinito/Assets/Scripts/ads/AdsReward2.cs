
using UnityEngine;
using YG;

public class AdsReward2 : MonoBehaviour
{
  
    public GameObject OpenScene;


    // Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // Подписанный метод получения награды
    public void Rewarded(int id)
    {
        // Если ID = 1, то выдаём "+100 монет"
        if (id == 3)
        {
            OpenScene.SetActive(true);
        }

    }

    // Метод для вызова видео рекламы
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }
}
