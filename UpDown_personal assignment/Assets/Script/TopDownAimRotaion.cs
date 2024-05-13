using UnityEngine;

public partial class TopDownAimRotation : MonoBehaviour
{
    Transform tf;

    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;

        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);

        if (target.x < tf.position.x)
        {
            tf.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            tf.localScale = new Vector3(1, 1, 1);
        }
    }
}