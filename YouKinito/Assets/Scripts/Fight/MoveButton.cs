using UnityEngine;
using UnityEngine.UI;

public class MoveButtonInSquare : MonoBehaviour
{
    public RectTransform moveArea;  // Область, в пределах которой будет перемещаться кнопка
    public int squareSize = 200;    // Размер квадрата
    private RectTransform buttonRectTransform;
    private Button button;
    private int clickCount = 0;

    public GameObject SceneClose;
    public GameObject SceneOpen;


    void Start()
    {
        button = GetComponent<Button>();
        buttonRectTransform = GetComponent<RectTransform>();

        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }

        // Устанавливаем размер moveArea на основе squareSize
        if (moveArea != null)
        {
            moveArea.sizeDelta = new Vector2(squareSize, squareSize);
        }
    }

    void OnButtonClick()
    {
        clickCount++;
        if (clickCount >= 10)
        {
            SceneOpen.SetActive(true);
            SceneClose.SetActive(false);
        }

        Vector2 newPosition = GetRandomPositionWithinSquare();
        buttonRectTransform.anchoredPosition = newPosition;
    }

    Vector2 GetRandomPositionWithinSquare()
    {
        float halfSquareSize = squareSize / 2f;
        float x = Random.Range(-halfSquareSize, halfSquareSize);
        float y = Random.Range(-halfSquareSize, halfSquareSize);

        return new Vector2(x, y);
    }
}