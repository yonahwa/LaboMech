using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atelier1Player : MonoBehaviour
{
    private Rigidbody m_Body;
    [SerializeField] private int m_Speed = 4;
    [SerializeField] private int m_JumpForce = 3;
    // Start is called before the first frame update
    void Start()
    {
        m_Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 CalculatedVelocity = m_Body.velocity;
        CalculatedVelocity.x = HorizontalInput * m_Speed;
        CalculatedVelocity.z = VerticalInput * m_Speed;
        m_Body.velocity = CalculatedVelocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Body.AddForce(Vector3.up * m_JumpForce, ForceMode.Impulse);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.DrawRay(transform.position, Vector3.down * 1, Color.red);
        RaycastHit HitInfo;
        if (Physics.Raycast(transform.position, Vector3.down, out HitInfo, 1.0f))
        {
            if (HitInfo.collider.name == "Enemy")
            {
                Destroy(HitInfo.collider.gameObject);
            }
        }
        else if (collision.collider.name == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
