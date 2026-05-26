using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 direction;

    private void Start()
    {
        transform.position = new Vector3(1, 1, 1);
    }

    private void Update()
    {
        direction.x += Input.GetAxis("Horizontal");
        direction.z += Input.GetAxis("Vertical");

        transform.position = transform.position + direction;
    }

}
