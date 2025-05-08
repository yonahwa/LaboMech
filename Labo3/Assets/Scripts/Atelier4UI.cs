using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atelier4UI : MonoBehaviour
{
    [SerializeField] private Slider m_Slider;
    // Start is called before the first frame update
    public void LifeBare(int Life)
    {
        m_Slider.value = Life;
    }
}
