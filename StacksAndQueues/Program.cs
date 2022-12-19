
using System.Xml.Linq;

namespace StacksandQueues
{
    public class Program
    {

        static void Main(string[] args)
        {
            Stack_Ex stack_ = new Stack_Ex();
            stack_.Push(70);
            stack_.Push(30);
            stack_.Push(56);
            stack_.Display();
        }
    }
}