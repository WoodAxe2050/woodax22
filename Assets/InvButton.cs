using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvButton : MonoBehaviour
{
    public void ChangeScene()
    {
        // "Inventory" ������ ��ȯ�մϴ�.
        SceneManager.LoadScene("Inventory");
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
