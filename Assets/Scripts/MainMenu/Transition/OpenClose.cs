using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    public GameObject MainUI;
    private void Start() {
        AnimateMainUI();
    }
    public void AnimateMainUI()
    {
        if (MainUI)
        {
            Animator m = MainUI.GetComponent<Animator>();
            bool n = m.GetBool("Open");
            m.SetBool("Open", false);
        }
    }
}
