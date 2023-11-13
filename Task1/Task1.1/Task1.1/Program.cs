using Task1._1;
int size;
bool isParceSuccessOne;
do
{
    Console.Write("Введите размер stack: ");
    isParceSuccessOne = int.TryParse(Console.ReadLine(), out size);
}
while (!isParceSuccessOne || size == 0);

MyStack myStack = new MyStack(size);
myStack.Push(2);
myStack.Push(5);
myStack.Push(6);
myStack.Pop();
myStack.Pop();
myStack.Pop();
myStack.Pop();