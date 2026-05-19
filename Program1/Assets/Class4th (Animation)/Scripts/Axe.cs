using UnityEngine;

public class Axe : MonoBehaviour
{
    public void Attack(int count)
    {
        Debug.Log("Attacked");

        count++;

        if (count >= 10)
        {
            Debug.Log("Critical!");
        }
    }

    public void Deffend(int def)
    {

    }

    public void Throw(float power)
    {

    }
}
