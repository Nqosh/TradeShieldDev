namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points == null || points.Length < 3)
            return -1;

        int maxDepth = -1;
        int i = 0;
        int n = points.Length;

        while (i < n - 2)
        {
            if (points[i] <= 0)
            {
                i++;
                continue;
            }

            int p = i;
            int q = i;

            while (q + 1 < n && points[q + 1] < points[q])
            {
                q++;
            }

            if (q == p)
            {
                i++;
                continue;
            }

            int r = q;
            while (r + 1 < n && points[r + 1] > points[r])
            {
                r++;
            }

            if (r == q)
            {
                i = q + 1;
                continue;
            }

            int depth = Math.Min(points[p] - points[q], points[r] - points[q]);
            maxDepth = Math.Max(maxDepth, depth);

            i = r;
        }

        return maxDepth;
    }
}
