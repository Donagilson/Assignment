namespace ConsoleAppEventDemo
{
    public delegate string WelcomDelegate(string UserName);
    internal class Program
    {
        //2.Initialize /2.Declaring an Event using the delegate
        //this is the publisher
        //(the event lives here and will notify subscribers)

        event WelcomDelegate welcomeEvent;

        public Program()
        {
            //3 attaching the method/function to the event
            //This is the **scubsriber**(Welcome method subscribes to the +++++++++++++++++++++++++++
            welcomeEvent += new WelcomDelegate(this.Welcome);
        }


        static void Main(string[] args)
        {
            Program objProgram = new Program();
            string result = objProgram.welcomeEvent("Sanjay");
            Console.WriteLine(result);
            
            
            Console.ReadKey();
        }

        //Simple Function ---- Subscribers method
        //This is the Subscribers method
        //(it will be executed when event is raised)

        public string Welcome(string UserName)
        {
            return "Welcome:" + UserName;
        }
    }
}
