using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallReload : MonoBehaviour
{

    public float fallDrop = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= fallDrop){
Scene scene = SceneManager.GetActiveScene();
Destroy(gameObject);
SceneManager.LoadScene(scene.name);
        }
    }
}
