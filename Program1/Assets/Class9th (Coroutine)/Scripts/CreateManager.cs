using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject elemental;
    [SerializeField] float offset = 1.5f;
    [SerializeField] List<GameObject> clone;
    private float time;
    private int count;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            clone.Add(Instantiate(elemental, transform));

            clone[i].transform.position = new Vector3(-3 + (1.5f * i), 0, 0);

            clone[i].SetActive(false);
        }

        StartCoroutine(Coroutine());
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (count < clone.Count && time >= 5.0f)
        {
            clone[count++].SetActive(true);

            time = 0.0f;
        }
    }

    IEnumerator Coroutine()
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(5.0f);

        Debug.Log("Stop Coroutine");
    }
}
