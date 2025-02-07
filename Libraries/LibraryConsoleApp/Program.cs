
using LibraryShared;

/// <summary>
/// main program
/// </summary>
public class Program
{
    /// <summary>
    /// shared HTTP client, not currently using Http Client Factory
    /// </summary>
    private static HttpClient hc = new HttpClient();

    /// <summary>
    /// main method
    /// </summary>
    /// <param name="args">command line arguments</param>
    public static void Main(string[] args)
    {
        int result = Common.NORMAL_EXIT;
        try
        {
            //put the library run logic here
            //result = NameSpace.Library.RunMain(args)
        }
        catch (Exception ex)
        {
            Console.Out.WriteLine(ex);
            result = Common.READ_NEWLINE;
        }

        if (result != Common.NORMAL_EXIT)
        {
            if (result == Common.READ_NEWLINE)
            {
                Console.ReadLine();
            }
        }
    }
}