namespace HTMLBuilder;

public class Builder : Handler
{
    public Builder() {}
 
    public dynamic Build(bool returnValue = false) {
        string output = "";
        if(returnValue) {
            output = GetCode();
        }else {
            output = "SET THE 'returnValue' TO TRUE TO RETURN A STRING!!";
            Console.WriteLine(GetCode());
        }
        return output;
    }
}
