// See https://aka.ms/new-console-template for more information
using PipelineNew;
class program
{
    static void Main(string[] args)
    {
        CommandFactory commandFactory = new BasicCommandFactory();
        Application application = new Application(commandFactory);

        // Provide the path to your commands file
        string filePath = @"c:\Assignment\commands.xml";
        application.ExecuteCommandsFromFile(filePath);

    }
}