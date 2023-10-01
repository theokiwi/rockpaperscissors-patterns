using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanObjects : MonoBehaviour
{
    public static CleanObjects clean;
    void Start(){
        clean = this;
    }
    public void CallDestruction(GameObject objectToDestroy){
        StartCoroutine(DestroyObjectAfterTurn(objectToDestroy));
    }
    IEnumerator DestroyObjectAfterTurn(GameObject objectToDestroy){
        yield return new WaitForSeconds(1f);
        Destroy(objectToDestroy);
   }
}
