using UnityEngine;
using System.Collections;
using UnityEngine.UI;


// add top parent
public class Scroll : MonoBehaviour
{
    // Public Variables
    // Center to compare the distance for each button

    // Private Variables
    public float[] distance = null;	// All buttons' distance to the center
    public float[] distReposition = null;
    private bool isDragging = false;	// Will be true, while we drag the panel
    private int bttnDistance = 0;   // Will hold the distance between the buttons
    public int minButtonNum = 0;	// To hold the number of the button, with smallest distance to center


    public RectTransform panel = null;	// To hold the ScrollPanel  , this is content scroll rect
    public Button[] bttn = null; // button child panel


    public RectTransform center = null;


    private int bttnLength;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {

        bttnLength = bttn.Length;
        distance = new float[bttnLength];
        distReposition = new float[bttnLength];
        // Get distance between buttons
        bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);
    }

    void Update()
    {
        for (int i = 0; i < bttn.Length; i++)
        {
            distReposition[i] = center.transform.position.x - bttn[i].transform.position.x;
            distance[i] = Mathf.Abs(distReposition[i]);

        }
        float minDistance = Mathf.Min(distance);	// Get the min distance

        for (int i = 0; i < bttn.Length; i++)
        {
            if (minDistance == distance[i])
            {
                minButtonNum = i;
            }
        }

        if (!isDragging)
        {
            //LerpToBttn(minButtonNum * -bttnDistance);
            LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.x);
        }
    }


    void LerpToBttn(float position)
    {
        float speed = 10;
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * speed);
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);
        panel.anchoredPosition = newPosition;
    }

    // Add event trigger drag in scroll rect
    public void StartDrag()
    {
        isDragging = true;
    }

    // Add event trigger end drag in scroll rect
    public void EndDrag()
    {
        isDragging = false;
    }

}
