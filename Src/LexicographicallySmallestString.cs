namespace Src
{
    public class LexicographicallySmallestString
    {
        public static string FindLexSmallestString(string s, int a, int b)
        {
            var best = s;
            var seen = new HashSet<string> { s };
            var q = new Queue<string>();
            q.Enqueue(s);

            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                if (IsLexicographicallySmaller(cur, best))
                   best = cur;

                var aNext = ApplyOperationA(cur, a);
                if (seen.Add(aNext))
                {
                    q.Enqueue(aNext);
                }

                var bNext = ApplyOperationB(cur, b);
                if (seen.Add(bNext))
                {
                    q.Enqueue(bNext);
                }
            }

            return best;
        }

        public static string ApplyOperationA(string s, int a)
        {
            var chars = s.ToCharArray();

            for (var i = 1; i < chars.Length ; i+=2)
            {
                var digit = chars[i] - '0';
                var number = digit + a;

                chars[i] = (char)(number % 10 + '0');
            }

            return new string(chars);
        }

        public static string ApplyOperationB(string s, int b)
        {
            var n = s.Length;
            return s.Substring(n - b, b) + s.Substring(0, n - b);

        }
        public static bool IsLexicographicallySmaller(string a, string b) => string.CompareOrdinal(a, b) < 0;
    }
}
