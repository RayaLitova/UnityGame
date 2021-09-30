using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
   
    private IEnumerator Start(){
        yield return new WaitForSeconds(1f);
        AsyncOperation op = SceneManager.LoadSceneAsync(Statics.SceneToLoad);
    }
}
