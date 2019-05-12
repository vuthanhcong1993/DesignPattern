using UnityEngine;
using UnityEngine.Assertions;
using System.Reflection;
using System.Linq;
using UnityEngine.Serialization;

public class AssertionExampleClass : MonoBehaviour
{
    public int health { get; set; }

    public int G
    {
        get
        {
            Debug.Log("mm");
            return g;
        }

        set
        {
            g = value;
            Debug.Log("hihi");
        }
    }

    private int g;
    [FormerlySerializedAs("cdsd")]
    public GameObject go;
    [FormerlySerializedAs("myValue")]
    public string myValuesxxx;

    private void Start()
    {
        Destroy(GetComponent<AssertionExampleClass>());
        gg();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            int a = G;
            G = 1;
        }
    }

    public void gg()
    {
        
        var ass = Assembly.GetAssembly(typeof(Prototype)).GetTypes().Where(type=> type.IsSubclassOf(typeof(Prototype)));
        foreach (var item in ass)
        {
            Debug.Log(item.Name);
        }
    }
}