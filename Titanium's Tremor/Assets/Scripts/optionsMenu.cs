using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject playMenu;

    public void playMenuShow()
    {
        gameObject.SetActive(false);
        playMenu.SetActive(true);
    }
}
