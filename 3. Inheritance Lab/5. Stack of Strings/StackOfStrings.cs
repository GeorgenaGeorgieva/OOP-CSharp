namespace CustomStack
{
    using System.Collections.Generic;
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }

            return false;
        }

        public Stack<string> AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
            {
                this.Push(element);
            }

            return this;
        }
    }
}
