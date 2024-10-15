namespace Sample01
{
    class Point
    {
        public int x, y;

        // конструктор за замовчуванням
        public Point()
        {
            x = 0;
            y = 0;
        }

        // конструктор з параметрами
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // конструктор копіювання
        public Point(Point key)
        {
            x = key.x;
            y = key.y;
        }

        // перевантаження оператора інкремента
        public static Point operator ++(Point par)
        {
            par.x++;
            par.y++;
            return par;
        }

        // перевантаження оператора декремента
        public static Point operator --(Point par)
        {
            par.x--;
            par.y--;
            return par;
        }

        // приклад перевантаження бінарної операції "додавання"
        public static Point operator +(Point par1, Point par2)
        {
            return new Point(par1.x + par2.x, par1.y + par2.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(); // створюємо об'єкт з x = 0, y = 0

            p++; // збільшуємо x і y
            Console.WriteLine("x = {0} y = {1}", p.x, p.y); // очікуємо x=1, y=1

            p++; // знову збільшуємо x і y
            Console.WriteLine("x = {0} y = {1}", p.x, p.y); // очікуємо x=2, y=2

            p--; // зменшуємо x і y
            Console.WriteLine("x = {0} y = {1}", p.x, p.y); // очікуємо x=1, y=1

            --p; // ще раз зменшуємо x і y
            Console.WriteLine("x = {0} y = {1}", p.x, p.y); // очікуємо x=0, y=0

            // використовуємо перевантаження оператора додавання
            Point p2 = new Point(3, 4);
            Point sum = p + p2; // складаємо два об'єкти Point
            Console.WriteLine("sum x = {0} sum y = {1}", sum.x, sum.y);
        }
    }
}