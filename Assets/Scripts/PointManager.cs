using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    GameManager _gm;
    Vector3 startPos;
    bool beenHit;// Start is called before the first frame update
    bool done;
    void Start()
    {
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        startPos= transform.position;
    }
    private void Update() {
        if(Vector3.Distance(startPos,transform.position)> 0.5f && !done  & !beenHit)
        {_gm.addPoint();
        beenHit = true;}
        if(beenHit && Vector3.Distance(startPos,transform.position)>1.5f && !done)
        {
            _gm.addMorePoint();
            done = true;
        }

    }

}
