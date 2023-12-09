using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsController : MonoBehaviour
{
    public Material[] skins;
    public GameObject customMenu;
    public CustomMenu cm;
    public int objType;

    void Start()
    {
        cm = customMenu.GetComponent<CustomMenu>();
    }
    void OnEnable()
    {
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(0.1f);
        if(objType == 0)
        {
            if (cm.cubeEquiped == "default")
                GetComponent<Renderer>().material = skins[0];
            if (cm.cubeEquiped == "creeper")
                GetComponent<Renderer>().material = skins[1];
            if (cm.cubeEquiped == "bob")
                GetComponent<Renderer>().material = skins[2];
            if (cm.cubeEquiped == "lego")
                GetComponent<Renderer>().material = skins[3];
            if (cm.cubeEquiped == "villager")
                GetComponent<Renderer>().material = skins[4];
            if (cm.cubeEquiped == "slime")
                GetComponent<Renderer>().material = skins[5];
        }
        if (objType == 1)
        {
            if (cm.sphereEquiped == "default")
                GetComponent<Renderer>().material = skins[0];
            if (cm.sphereEquiped == "among")
                GetComponent<Renderer>().material = skins[1];
            if (cm.sphereEquiped == "fall")
                GetComponent<Renderer>().material = skins[2];
            if (cm.sphereEquiped == "jack")
                GetComponent<Renderer>().material = skins[3];
            if (cm.sphereEquiped == "homer")
                GetComponent<Renderer>().material = skins[4];
            if (cm.sphereEquiped == "bean")
                GetComponent<Renderer>().material = skins[5];
        }
        if (objType == 2)
        {
            if (cm.triangleEquiped == "default")
                GetComponent<Renderer>().material = skins[0];
            if (cm.triangleEquiped == "angry")
                GetComponent<Renderer>().material = skins[1];
            if (cm.triangleEquiped == "bill")
                GetComponent<Renderer>().material = skins[2];
            if (cm.triangleEquiped == "plankton")
                GetComponent<Renderer>().material = skins[3];
            if (cm.triangleEquiped == "bender")
                GetComponent<Renderer>().material = skins[4];
            if (cm.triangleEquiped == "fruta")
                GetComponent<Renderer>().material = skins[5];
        }
    }
}
