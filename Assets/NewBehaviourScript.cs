using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("NewBehaviourScript script has started.");
        Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movment = new Vector2(horizontal, vertical);
        transform.Translate(movment * speed * Time.deltaTime);
    }
}
