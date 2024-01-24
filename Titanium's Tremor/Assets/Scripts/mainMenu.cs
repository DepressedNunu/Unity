using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class mainMenu: MonoBehaviour
{
    [SerializeField] private GameObject playMenu;
    void Update()
    {
        if ( Input.anyKeyDown)
        {
            gameObject.SetActive(false);
            playMenu.SetActive(true);
        }
    }
}
