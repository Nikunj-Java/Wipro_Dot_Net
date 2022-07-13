namespace LoginTableDemo
{
    public class Login
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public int Check(string email, string password) {


            if (email.Equals("nikunj@gmail.com") && password.Equals("Nikunj@123")) {

                Console.WriteLine("User Verified : " + email);
                return 1;
            }
            else if (email.Equals("admin@gmail.com") && password.Equals("Admin@123")) {

                Console.WriteLine("User Verified : " +email);
                return 1;
            }
            else
            {
                Console.WriteLine("Unauthosired Access for: "+email);
                return 0;

            }

        }
    }
}