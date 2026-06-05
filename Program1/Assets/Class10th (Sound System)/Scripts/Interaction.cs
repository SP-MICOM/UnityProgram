using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] float distance = 100.0f;
    [SerializeField] LayerMask layerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, distance, layerMask))
            {
                Debug.Log(raycastHit.collider.gameObject.name);

                AudioSource audioSource = raycastHit.collider.gameObject.GetComponent<AudioSource>();

                if(audioSource.isPlaying == false)
                {
                    audioSource.Play();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray.origin, ray.direction * 100);
    }
}
