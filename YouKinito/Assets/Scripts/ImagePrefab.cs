using UnityEngine;
using UnityEngine.UI;

public class ImagePrefab : MonoBehaviour
{
    public GameObject imagePrefab; // ������ �����������
    public Button createButton; // ������ �� �������
    public Vector3 startPosition = new Vector3(0, 0, 0); // ��������� ������� ��� �������� �����������
    public Vector3 offset = new Vector3(50, 0, 0); // �������� ��� ������� ���������� �����������

    public int HP;

    public GameObject CloseScene;
    public GameObject OpenScene;

    private Vector3 nextPosition;

    void Start()
    {
        nextPosition = startPosition; // �������������� ��������� �������
        createButton.onClick.AddListener(CreateImage); // ��������� ���������� ������� ������� ������
    }

    void CreateImage()
    {
        // ������� ����������� �� ������� � ��������� �������
        Instantiate(imagePrefab, nextPosition, Quaternion.identity, transform);
        // ��������� ������� ��� ���������� �����������
        nextPosition += offset;
        HP -= 1;
        if(HP <= 0)
        {
            OpenScene.SetActive(true);
            CloseScene.SetActive(false);
        }
    }
}
