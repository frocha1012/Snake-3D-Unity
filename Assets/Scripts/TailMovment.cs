using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TailMovment : MonoBehaviour
{
    #region variable
    public float speed;
    public Vector3 tailTarget;
    public SnakeMovment mainSnake;
    public GameObject tailTargetObj;
    public int id;
    #endregion
    void Start()
    {
        
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
        speed = mainSnake.speed;
        tailTargetObj = mainSnake.tail[^2];
        id = mainSnake.tail.IndexOf(gameObject);
    }
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget,Time.deltaTime*speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if(id>2)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
