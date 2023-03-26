using LinkedListStack;
static void pstr(string message)
{
    Console.WriteLine(message);
}
static void pint(int message)
{
    Console.WriteLine(message);
}
pstr("Hi from Stack!");

Stack st = new Stack();
st.peek();
st.push(1);
st.push(2);
st.push(3);
pstr("Stack Size:");
pint(st.size());
pstr("Printing Elements...");
while (!st.isEmpty())
{
    pint(st.pop());
}

pstr("Hi from queue!");
Queue q = new Queue();
q.peek();
q.enqueue(1);
q.enqueue(2);
q.enqueue(3);
pstr("Queue Size:");
pint(q.size());
pstr("Printing Elements...");
while (!q.isEmpty())
{
    pint(q.dequeue());
}
