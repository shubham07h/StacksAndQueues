using System.Xml.Linq;

namespace StacksandQueues
{
    public class Program
    {

        static void Main(string[] args)
        {
            Queue_Ex que = new Queue_Ex();
            que.Enqueue(70);
            que.Enqueue(30);
            que.Enqueue(56);
            que.Display();
            que.Dequeue();
            que.Display();
            que.Dequeue();
            que.Display();
            que.Dequeue();
            que.Display();
        }
    }
}