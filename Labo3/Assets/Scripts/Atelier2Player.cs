using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atelier2Player : MonoBehaviour
{
    [SerializeField] private GameObject m_Sphere;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayFromCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(rayFromCamera, out raycastHit))
            {
                if (raycastHit.collider.tag != "Sphere")
                {
                    Instantiate(m_Sphere, raycastHit.point, Quaternion.identity);
                }
                else
                {
                    raycastHit.collider.GetComponent<Renderer>().material.color = Random.ColorHSV();
                }
            }
        }
    }
}
