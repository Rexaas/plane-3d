using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float total;
    public float inc;
    public Text scoretext;
    public move m;
    // Update is called once per frame
    private void Start()
    {
        total = 0;
        inc = 1;
    }
    void Update()
    {
        if (m.enabled == true) {
        scoretext.text = "score "+(int)total;
            total += inc * Time.deltaTime;
    }
    }
}
