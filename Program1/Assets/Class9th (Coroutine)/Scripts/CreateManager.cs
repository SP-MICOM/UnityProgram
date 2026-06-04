using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour 
{
    [SerializeField] GameObject elemental;
    [SerializeField] float offset = 1.5f;
    [SerializeField] List<GameObject> clone;
    [SerializeField] WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);
    private int count;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            clone.Add(Instantiate(elemental, transform));

            clone[i].transform.position = new Vector3(-3 + (offset * i), 0, 0);

            clone[i].SetActive(false);
        }

        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while(count < clone.Count)
        {
            if (count < clone.Count)
            {
                clone[count++].SetActive(true);
            }

            yield return waitForSeconds;
        }
    }
}
