using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controler : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;
    [SerializeField] float force;
    [SerializeField] ForceMode forceMode;
    

    private void Start()
    {
        forceMode = ForceMode.Force;
        rigidbody = GetComponent<Rigidbody>();
        force = 7.5f;
    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        
        direction.Normalize();
    }

    private void FixedUpdate()
    {
        // ForceMode.Force(지속적인 힘)
        // 입력한 힘(F)를 물체의 무게(m)으로 나눈 값에 물리 프레임 시간(t)를 곱한 만큼
        // 속도가 점진적으로 증가합니다.

        // ForceMode.Acceleration(지속적인 가속도)
        // 물체의 무게(m)를 연산에서 제외하며, 입력한 값 자체를 가속도로 지정하여,
        // 매 프레임마다 시간(t)을 곱한 만큼의 속도로 증가합니다.

        // ForceMode.Impulse(순간적인 힘)
        // 단 한 번의 프레임 만에 입력한 출력량(I)를 무게(m)로 나눈 만큼 속도를
        // 즉시 변화시키는 힘입니다.

        // ForceMode.Velocity(순간적인 속도 변화)
        // 무게(m)와 시간(t)을 모두 무시하며, 입력한 벡터 값 자체가 객체의 다음
        // 프레임 속도 변화량이 되는 것입니다.

        if (forceMode == ForceMode.Impulse)
        {
            rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);

            forceMode = ForceMode.Force;

            force = 7.5f;

            return;
        }

        rigidbody.AddForce(direction * force, forceMode);
    }

    public void Soar()
    {
        forceMode = ForceMode.Impulse;

        force = 5.0f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("OnCollisionEnter");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}
