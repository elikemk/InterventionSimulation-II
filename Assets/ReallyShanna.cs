using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReallyShanna : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayFail()
    {
        SceneManager.LoadSceneAsync(1);
    }


}
