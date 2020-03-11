using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scenes.Player.NewPlayerController.Tools
{
    class Tools
    {
        public static float Solve_ballistic_arc(Vector3 projectileInitialPosition, float projectileSpeed,
           Vector3 target, float gravity, out Vector3 lowAngleSolution, out Vector3 highAngleSolution)
        {

            // Handling these cases is up to your project's coding standards
            Debug.Assert(projectileInitialPosition != target && projectileSpeed > 0 && gravity > 0,
                "fts.Solve_ballistic_arc called with invalid data");

            // C# requires out variables be set
            lowAngleSolution = Vector3.zero;
            highAngleSolution = Vector3.zero;

            // Derivation
            //   (1) x = v*t*cos O
            //   (2) y = v*t*sin O - .5*g*t^2
            //
            //   (3) t = x/(cos O*v)                                        [solve t from (1)]
            //   (4) y = v*x*sin O/(cos O * v) - .5*g*x^2/(cos^2 O*v^2)     [plug t into y=...]
            //   (5) y = x*tan O - g*x^2/(2*v^2*cos^2 O)                    [reduce; cos/sin = tan]
            //   (6) y = x*tan O - (g*x^2/(2*v^2))*(1+tan^2 O)              [reduce; 1+tan O = 1/cos^2 O]
            //   (7) 0 = ((-g*x^2)/(2*v^2))*tan^2 O + x*tan O - (g*x^2)/(2*v^2) - y    [re-arrange]
            //   Quadratic! a*p^2 + b*p + c where p = tan O
            //
            //   (8) let gxv = -g*x*x/(2*v*v)
            //   (9) p = (-x +- sqrt(x*x - 4gxv*(gxv - y)))/2*gxv           [quadratic formula]
            //   (10) p = (v^2 +- sqrt(v^4 - g(g*x^2 + 2*y*v^2)))/gx        [multiply top/bottom by -2*v*v/x; move 4*v^4/x^2 into root]
            //   (11) O = atan(p)

            Vector3 diff = target - projectileInitialPosition;
            Vector3 diffXZ = new Vector3(diff.x, 0f, diff.z);
            float groundDist = diffXZ.magnitude;

            float speed2 = projectileSpeed * projectileSpeed;
            float speed4 = projectileSpeed * projectileSpeed * projectileSpeed * projectileSpeed;
            float y = diff.y;
            float x = groundDist;
            float gx = gravity * x;

            float root = speed4 - gravity * (gravity * x * x + 2 * y * speed2);

            // No solution
            if (root < 0)
                return 0;

            root = Mathf.Sqrt(root);

            float lowAng = Mathf.Atan2(speed2 - root, gx);
            float highAng = Mathf.Atan2(speed2 + root, gx);
            int numSolutions = lowAng != highAng ? 2 : 1;

            Vector3 groundDir = diffXZ.normalized;
            lowAngleSolution = groundDir * Mathf.Cos(lowAng) * projectileSpeed +
                               Vector3.up * Mathf.Sin(lowAng) * projectileSpeed;
            if (numSolutions > 1)
                highAngleSolution = groundDir * Mathf.Cos(highAng) * projectileSpeed +
                                    Vector3.up * Mathf.Sin(highAng) * projectileSpeed;

            return highAng;
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            if (angle < -360.0)
                angle += 360.0f;
            if (angle > 180.0)
                angle -= 360.0f;

            return Mathf.Clamp(angle, min, max);
        }
    }
}
