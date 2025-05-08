using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralUi : MonoBehaviour
{
    private int m_index = 0;
    public void OnClickNext()
    {
        m_index++;
        if (m_index > 3)
        {
            m_index = 0;
        }
        SceneManager.LoadScene(m_index);
    }
    public void OnClickPrev()
    {
        m_index--;
        if (m_index <= -1)
        {
            m_index = 0;
        }
        SceneManager.LoadScene(m_index);
    }
}
