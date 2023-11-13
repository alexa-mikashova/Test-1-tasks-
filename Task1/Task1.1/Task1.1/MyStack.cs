namespace Task1._1
{
    internal class MyStack
    {
        private int[] stack;
        private int top;

        public MyStack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if (top >= stack.Length - 1)
            {
                Console.WriteLine("Массив stack переполнен!");
            }
            else
            {
                ++top;
                stack[top] = value;
                Console.WriteLine($"Число {value} добавлено в stack");
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Массив stack пуст!");
                return -1;
            }
            else
            {
                int value = stack[top];
                Console.WriteLine($"Число {value} удалено из stack");
                stack[top] = 0;
                --top;
                return value;
            }
        }
    }
}
