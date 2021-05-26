using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //      Scroll Text For each 10 lines it will start scrolling
   [TextArea(14,10)] [SerializeField] string storyText;
}
