using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    public void ChangeScene()
    {
        // "Inventory" ������ ��ȯ�մϴ�.
        SceneManager.LoadScene("Shop");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
