using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtoMainScene : MonoBehaviour
{
    public void ChangeScene()
    {
        // "Inventory" ������ ��ȯ�մϴ�.
        SceneManager.LoadScene("Mainscene");
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
