using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RotateSquareWithButtons : MonoBehaviour
{
    public float rotationSpeed = 100f; // скорость вращения
    public Button leftButton;
    public Button rightButton;

    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    void Start()
    {
        // Добавляем EventTrigger для левой кнопки
        AddEventTrigger(leftButton.gameObject, EventTriggerType.PointerDown, () => OnButtonPressed(ref isRotatingLeft, true));
        AddEventTrigger(leftButton.gameObject, EventTriggerType.PointerUp, () => OnButtonReleased(ref isRotatingLeft));

        // Добавляем EventTrigger для правой кнопки
        AddEventTrigger(rightButton.gameObject, EventTriggerType.PointerDown, () => OnButtonPressed(ref isRotatingRight, true));
        AddEventTrigger(rightButton.gameObject, EventTriggerType.PointerUp, () => OnButtonReleased(ref isRotatingRight));
    }

    void Update()
    {
        if (isRotatingLeft)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        if (isRotatingRight)
        {
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    void OnButtonPressed(ref bool isRotating, bool state)
    {
        isRotating = state;
    }

    void OnButtonReleased(ref bool isRotating)
    {
        isRotating = false;
    }

    void AddEventTrigger(GameObject obj, EventTriggerType type, System.Action action)
    {
        EventTrigger trigger = obj.GetComponent<EventTrigger>();
        if (trigger == null)
        {
            trigger = obj.AddComponent<EventTrigger>();
        }
        var entry = new EventTrigger.Entry { eventID = type };
        entry.callback.AddListener((eventData) => { action(); });
        trigger.triggers.Add(entry);
    }
}

