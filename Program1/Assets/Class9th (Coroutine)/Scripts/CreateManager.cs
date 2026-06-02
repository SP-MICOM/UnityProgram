using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject elemental;
    [SerializeField] float offset = 1.5f;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject[] clone = new GameObject[5];

            clone[i] = Instantiate(elemental, transform);

            clone[i].transform.position = new Vector3(-3 + (1.5f * i), 0, 0);
        }
    }
}
