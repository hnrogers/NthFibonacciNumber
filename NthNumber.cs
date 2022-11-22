class Working
{
    
    public string NthNum(int n)
    {
        double current = 1, previous = 0;
        
        for (int i = 1; i < n; i++)
        {
          
          current = current + previous;
          previous = current - previous;
          
        }
        return current.ToString();
    }
}