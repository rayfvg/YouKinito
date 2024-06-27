using UnityEngine;
using UnityEngine.UI;

public class ImagePrefab : MonoBehaviour
{
    public GameObject imagePrefab; // Префаб изображения
    public Button createButton; // Кнопка на канвасе
    public Vector3 startPosition = new Vector3(0, 0, 0); // Начальная позиция для создания изображения
    public Vector3 offset = new Vector3(50, 0, 0); // Смещение для каждого следующего изображения

    public int HP;

    public GameObject CloseScene;
    public GameObject OpenScene;

    private Vector3 nextPosition;

    void Start()
    {
        nextPosition = startPosition; // Инициализируем начальную позицию
        createButton.onClick.AddListener(CreateImage); // Добавляем обработчик события нажатия кнопки
    }

    void CreateImage()
    {
        // Создаем изображение из префаба в следующей позиции
        Instantiate(imagePrefab, nextPosition, Quaternion.identity, transform);
        // Обновляем позицию для следующего изображения
        nextPosition += offset;
        HP -= 1;
        if(HP <= 0)
        {
            OpenScene.SetActive(true);
            CloseScene.SetActive(false);
        }
    }
}
