using UnityEngine;
using GameDevWithMarco.Singleton;
using System.Collections;

namespace GameDevWithMarco.Managers
{
    public class VfxManager : Singleton<VfxManager>
    {
        //To call the logic in other scripts
        public void HitStop(float stopDuration)
        {
            StartCoroutine(HitStopCoroutine(stopDuration));
        }

        //Will stop the game for set time and then resume
        IEnumerator HitStopCoroutine(float duration)
        {
            Time.timeScale = 0;

            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = 1;
        }
    }
}
