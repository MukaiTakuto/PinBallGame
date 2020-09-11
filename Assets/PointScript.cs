// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// public class PointScript : MonoBehaviour
// {
//     public Text  PointText;
//     private int points = 0;
//     // Start is called before the first frame update
//     void Start()
//     {
//         SetScore();   
//     }
//     void OnCollisionEnter(Collision collision)
//     {
//         string yourTag  = collision.gameObject.tag;
//         if (tag == "SmallStarTag")
//                 {
//                         points += 1;
//                 }
//         else if (tag == "LargeStarTag")
//                 {
//                         points += 20;
//                 }
//         else if(tag == "SmallCloudTag" || tag == "LargeCloudTag")
//                 {
//                         points += 15;
//                 }
//         SetScore();
//     }
//     void SetScore()
//     {
//         PointText.text = string.Format( "Score:{0}", points );
//     }
//     // Update is called once per frame
//     void Update()
//     {
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointScript : MonoBehaviour
{
    public Text  PointText;
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetScore();   
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
                {
                        points += 1;
                }
        else if (collision.gameObject.tag == "LargeStarTag")
                {
                        points += 20;
                }
        else if(collision.gameObject.tag == "SmallCloudTag" || collision.gameObject.tag == "LargeCloudTag")
                {
                        points += 15;
                }
        SetScore();
    }
    void SetScore()
    {
        PointText.text = string.Format( "Score:{0}", points );
    }
    // Update is called once per frame
    void Update()
    {
    }
}