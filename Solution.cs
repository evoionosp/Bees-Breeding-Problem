using System;

namespace myApp
{
    class Code
    {
        static void Main() 
        {
            while (true)
            {
                string str_a = Console.ReadLine();
                string str_b = Console.ReadLine();
                if (Int32.TryParse(str_a, out int a) && Int32.TryParse(str_b, out int b))
                {
                    if (a == 0 && b == 0) break;
                    Point p = new Point(0, 0);
                    p = cal(a);
                    Point p1 = new Point(p.getX(), p.getY());
                    p = cal(b);
                    Point p2 = new Point(p.getX(), p.getY());
                    int x = p1.getX() - p2.getX();
                    int y = p1.getY() - p2.getY();
                    int ans;
                    if (x * y <= 0)
                        ans = Math.Max(Math.Abs(x), Math.Abs(y));
                    else
                        ans = Math.Abs(x + y);
                    Console.WriteLine("The distance between cells "+a+ " and "+b+ " is "+ans);

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }



        }

        public static Point cal(int a)
        {
            if (a == 1)
            {
                return new Point(0, 0);
            }
            int x;
            int y;
            int n = 0;
            while (3 * (n - 1) * n + 1 < a)
                n++;
            n--;
            a -= 3 * (n - 1) * n + 1;
            if (a <= n)
            {
                x = n;
                y = -a;
            }
            else if (a > n && a <= 2 * n)
            {
                x = 2 * n - a;
                y = -n;
            }
            else if (a > 2 * n && a <= 3 * n)
            {
                x = 2 * n - a;
                y = -n - x;
            }
            else if (a > 3 * n && a <= 4 * n)
            {
                x = -n;
                y = a - 3 * n;
            }
            else if (a > 4 * n && a <= 5 * n)
            {
                x = a - 5 * n;
                y = n;
            }
            else
            {
                x = a - 5 * n;
                y = n - x;
            }
            Point p = new Point(x, y);
            return p;
        }
    }

    class Point
    {
        int x;
        int y;
        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public int getX(){
            return x;
        }

        public int getY(){
            return y;
        }
    }
}
