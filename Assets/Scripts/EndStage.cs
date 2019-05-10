using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStage : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject EndCam;

    IEnumerator OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Finish"))
        {
            Debug.Log("setting end cam active");
            yield return new WaitForSeconds(4);
            EndCam.SetActive(true);
            MainCam.SetActive(false);
        }
    }
}
