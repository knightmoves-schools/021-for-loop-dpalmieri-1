namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos)
    {
        for(int i = 0; i < todos.Length; i++)
        {
            todos[i] = todos[i] + " - Done";
            
        }

        return todos;
    }
    

}
