using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaustVariableController : MonoBehaviour
{
    public FaustPlugin_freeverbPlugin scriptFaust;
    public int dummy_Toggle = 1;
    public GameObject this_Object;
    public float wet;

    // Start is called before the first frame update
    void Start()
    {
        print("FAUSTVARIABLECONTROLLER: inside Start");
        scriptFaust = this_Object.GetComponent<FaustPlugin_freeverbPlugin>();
        wet = scriptFaust.getParameter(3);
        print("scriptFaust.parameters damp = " + wet);

    }

    // Update is called once per frame
    void Update()
    {
        if (dummy_Toggle == 1)
        {
            // setParameter(int param, float x)
            scriptFaust.setParameter(3, 0.9f);
            print("VALUE CHANGED! scriptFaust.getParameter(3)= " + (scriptFaust.getParameter(3)));
            dummy_Toggle = 0;
        }
    }
}
