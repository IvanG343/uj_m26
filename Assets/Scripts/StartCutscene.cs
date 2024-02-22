using UnityEngine;
using UnityEngine.Playables;

public class StartCutscene : MonoBehaviour
{
    [SerializeField] private PlayableDirector cutSceneTimeline;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cutSceneTimeline.Play();
        }
    }
}
