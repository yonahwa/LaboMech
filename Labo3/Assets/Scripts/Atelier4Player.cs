using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Atelier4Player : MonoBehaviour
{
    
    private NavMeshAgent m_Agent;
    private Atelier4Enemy m_CurrentEnemyTarget;
    private float m_Elapsed;
    private float m_Delay = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayFromCam = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayFromCam, out RaycastHit hit))
            {
                if(hit.collider.tag == "Enemy")
                {
                    m_CurrentEnemyTarget = hit.collider.GetComponent<Atelier4Enemy>();
                    
                }

                m_Agent.SetDestination(hit.point);

            }
        }
        m_Elapsed += Time.deltaTime;
        if (m_Agent.remainingDistance <= 1 && m_CurrentEnemyTarget != null && m_Elapsed >= m_Delay)
        {
            m_CurrentEnemyTarget.LoseLife();
            m_Elapsed = 0;
        }
    }

    
}
