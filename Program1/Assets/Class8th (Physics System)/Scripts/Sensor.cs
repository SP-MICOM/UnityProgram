using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Controler controler = other.GetComponent<Controler>();

        if (controler != null)
        {
            controler.Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {

    }
}
