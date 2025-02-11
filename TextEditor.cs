using System;

class TextState
{
    public string Text;
    public TextState Previous;
    public TextState Next;

    public TextState(string text)
    {
        Text = text;
        Previous = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState currentState;
    private int historyLimit;
    private int currentHistorySize;
    private TextState head;

    public TextEditor(int historyLimit = 10)
    {
        this.historyLimit = historyLimit;
        currentHistorySize = 0;
        currentState = null;
        head = null;
    }

    public void TypeText(string newText)
    {
        TextState newState = new TextState(newText);

        if (currentState != null)
        {
            if (currentState.Next != null)
            {
                currentState.Next = null;
            }

            newState.Previous = currentState;
            currentState.Next = newState;
        }

        currentState = newState;

        if (currentHistorySize < historyLimit)
        {
            currentHistorySize++;
        }
        else
        {
            RemoveOldestState();
        }

        if (head == null)
        {
            head = currentState;
        }

        DisplayCurrentState();
    }

    public void Undo()
    {
        if (currentState != null && currentState.Previous != null)
        {
            currentState = currentState.Previous;
            DisplayCurrentState();
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void Redo()
    {
        if (currentState != null && currentState.Next != null)
        {
            currentState = currentState.Next;
            DisplayCurrentState();
        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    public void DisplayCurrentState()
    {
        if (currentState != null)
        {
            Console.WriteLine("Current text: " + currentState.Text);
        }
        else
        {
            Console.WriteLine("Text is empty.");
        }
    }

    private void RemoveOldestState()
    {
        if (head != null && head.Next != null)
        {
            head = head.Next;
            head.Previous = null;
        }
    }

    public void ShowHistory()
    {
        TextState temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Text);
            temp = temp.Next;
        }
    }

    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor(5);

        editor.TypeText("Hello");
        editor.TypeText("Hello world.");
        editor.TypeText("Hello world, How are you?");
        editor.TypeText("Hello world How are you I'm fine");
        editor.TypeText("Hello world How are you I am fine, What are you doing?");

        Console.WriteLine("History of text changes:");
        editor.ShowHistory();

        Console.WriteLine("Undoing the last action.");
        editor.Undo();

        Console.WriteLine("Redoing the last undone action.");
        editor.Redo();

        Console.WriteLine("Undoing until the beginning.");
        editor.Undo();
        editor.Undo();
        editor.Undo();
        editor.Undo();

        Console.WriteLine("Undo when there's nothing left to undo.");
        editor.Undo();

        Console.WriteLine("Redo after undoing everything.");
        editor.Redo();
        editor.Redo();
    }
}
