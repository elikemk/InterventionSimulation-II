using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeFramed : MonoBehaviour
{

    public GameObject[] npcs;
    public GameObject uiCanvas;
    // Start is called before the first frame update
    void Start()
    {
        uiCanvas.SetActive(false);
    }

    // Update is called once per frame
    public void FreezeNPCs()
    {
        foreach (var npc in npcs)
        {
            var rb = npc.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
            }
        }
    }
    public void UnfreezeNPCs()
    {
        foreach(var npc in npcs)
        {
            var rb = npc.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }
    
}
 