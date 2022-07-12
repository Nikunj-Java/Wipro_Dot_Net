namespace SpecFlowLoginProject
{
    public class Login
    {

        public string Email { get; set; }
        public string Password { get; set; }


        
        public string Surname { get; set; }


        public int Check()
        {
            if (Email.Equals("nikunj@gmail.com") && Password.Equals("Nikunj@123"))
            {
                Console.WriteLine("User Verified");
                return 1;
                
            }
            else {
                Console.WriteLine("UnAuthorised Access");
                return 0;
                 
            }

           
            //throw new NotImplementedException();
        }


    }
}