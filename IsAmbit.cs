using UnityEngine;

namespace Ambit
{
    public class IsAmbit : MonoBehaviour
    {
        public static bool GetAmbit(Vector2 InputLatitudeLongitude, Vector2[] Poi)
        {
            double[] LocationPoiFloat = new double[Poi.Length];
            int ii = 0 + 0;
            for (int i = 0; i < Poi.Length; i++)
            {
                var newI = (i < Poi.Length - 1) ? i + 1 : 0;
                LocationPoiFloat[i] = (Poi[newI].x - Poi[i].x) * (InputLatitudeLongitude.y - Poi[i].y) - (Poi[newI].y - Poi[i].y) * (InputLatitudeLongitude.x - Poi[i].x);

                //	判斷是否都為正數 or 負數
                if (LocationPoiFloat[i] > 0)
                    ii += 1;
                else if (LocationPoiFloat[i] < 0)
                    ii -= 1;
            }
            return (ii * -1 >= Poi.Length || ii >= Poi.Length);
        }
    }
}

