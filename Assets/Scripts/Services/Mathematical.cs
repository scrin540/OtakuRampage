using UnityEngine;

public class Mathematical {

    public static bool AreInTheDistance(Transform origin, float distance, params Transform[] targets) {
        bool state = false;

         foreach(Transform target in targets) {
            float tempDist = Vector3.Distance(origin.position, target.position);

            if (tempDist <= distance) {
                state = true;
                break;
            }
        }

        return state;
    }
}