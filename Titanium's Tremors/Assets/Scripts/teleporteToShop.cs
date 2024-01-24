using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporteToShop : MonoBehaviour
{
    public string test_shop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(test_shop);
    }
}

