using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atelier4Enemy : MonoBehaviour
{
    [SerializeField] private Atelier4UI m_Ui;
    private int m_life = 5;
    private bool m_dead = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_life <= 0) { m_dead = true; }
        if (m_dead)
        {
            Destroy(gameObject);
        }
    }

    public void LoseLife()
    {
 
            m_life--;
            m_Ui.LifeBare(m_life);
        

    }
}
