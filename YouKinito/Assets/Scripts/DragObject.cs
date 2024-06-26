using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // ���� �� ������������� ������
        if (isDragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = cam.WorldToScreenPoint(transform.position).z;
            transform.position = cam.ScreenToWorldPoint(mousePosition) + offset;
        }
    }

    void OnMouseDown()
    {
        // ������ ��������������
        isDragging = true;
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        // ����� ��������������
        isDragging = false;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = cam.WorldToScreenPoint(transform.position).z;
        return cam.ScreenToWorldPoint(mousePoint);
    }
}