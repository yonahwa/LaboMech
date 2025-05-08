using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atelier3Player : MonoBehaviour
{
    private int m_EnemyCount;
    private RaycastHit[] hits;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hits = Physics.RaycastAll(transform.position, transform.right, 150.0F);
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].collider.tag == "Enemy")
                {
                    Destroy(hits[i].collider.gameObject);
                    m_EnemyCount++;
                }
            }
            Debug.Log(m_EnemyCount);
        }
        Debug.DrawRay(transform.position, transform.right, Color.red, 150.0F);
    }
}
