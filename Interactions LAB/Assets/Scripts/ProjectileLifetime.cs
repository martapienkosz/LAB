using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float lifetime = 3.0f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
