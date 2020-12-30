using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    public CheckPoint2 cp;

    // Start is called before the first frame update
    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("CP").GetComponent<CheckPoint2>();
        transform.position = cp.checkPoint;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //     }
    // }
}
