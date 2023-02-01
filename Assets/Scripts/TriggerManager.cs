using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
private void OnTriggerEnter(Collider other) {
    if(other.gameObject.CompareTag("balle"))
    Destroy(other.gameObject,5f);
}
}
