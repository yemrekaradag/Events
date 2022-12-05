

public delegate void dg_OddNumber(); //delegate

public class Number
{
    public event dg_OddNumber ev_OddNumber; // event

    public void Add(int number)
    {
        Console.WriteLine($"Process Started!\n{number.ToString()}");
        OnProcessCompleted(number);
    }

    protected virtual void OnProcessCompleted(int number) //protected virtual method
    {
        //Check if number is odd number and ev_OddNumber is not null then call delegate (raise the event)
        if ((number % 2 != 0))
            ev_OddNumber?.Invoke(); //Raised Event
    }
}

class Program
{
    public static void Main()
    {
        Number num = new Number();
        int number = 0;
        //num.ev_OddNumber += new dg_OddNumber(EventMessage);

        //Event gets binded with delegates
        num.ev_OddNumber += EventMessage; // register with an event

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
                num.Add(number);
            else
                break;
        }


        Console.Read();
    }

    //Delegates calls this method when event raised.
    //event handler
    public static void EventMessage()
    {
        Console.WriteLine("********Event Executed(from Event Handler) : This is Odd Number**********");
    }
}