using Assignment04.MovieTicketSystem;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /* Static binding is done when there is a parent class and child class 
             * and there is a method in parent class that is used in the child class 
             * but with "new" keyowrd so the method of parent is hidden which is called 
             * method hiding and it occurs in compile time */


            /* dynamic binding used with virtual and override of functions when a child 
             * class override a method from the parent class with its own logic and it 
             * decide which method to use at run time */



            #endregion

            #region Question02

            /* method overloading is the method with the same name but different parameters */

            /* method overriding is when a child class override a virtual method from 
             * the parent class with its own logic */
            #endregion

            #region Question03

            /* virtual with parent method and override with child method */
            /* virtual means allow this function to be overriden */

            #endregion

            #region MovieTicketBook

            Cinema c = new Cinema("Vox Cinema");
            StandardTicket t1 = new StandardTicket("A1","Scream",130m);
            VIPTicket t2 = new VIPTicket(true, "Project Hail Mary", 200m);
            IMAXTicket t3 = new IMAXTicket(true, "The Bride", 250m);
     
            c.OpenCinema();
            t1.SetPrice(130m);
            t1.SetPrice(130m,2m);
            c.AddTicket(t1);
            c.AddTicket(t2);
            c.AddTicket(t3);
            c.PrintAllTickets();
            ProcessTicket(t2);
            c.CloseCinema();

            #endregion
        }
        public static void ProcessTicket(Ticket t)
        {

        }
    }
   
}
