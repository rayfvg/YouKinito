using UnityEngine;

public class DragAndDropWithCollisions : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Camera cam;
    private Rigidbody2D rb;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = cam.WorldToScreenPoint(transform.position).z;
            Vector3 targetPosition = cam.ScreenToWorldPoint(mousePosition) + offset;

            // Используем Rigidbody2D для перемещения объекта
            rb.MovePosition(targetPosition);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = cam.WorldToScreenPoint(transform.position).z;
        return cam.ScreenToWorldPoint(mousePoint);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            isDragging = false;
        }
    }
}
