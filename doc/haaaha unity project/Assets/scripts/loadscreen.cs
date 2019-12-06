using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscreen : MonoBehaviour
{
    // Start is called before the first frame update
               
           public void LoadScene()
            {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("SampleScene");
            }
 }