namespace sistemgiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "123456";
            // hocam izninizle ben while ı ögrendim ve kendimi test etmek için goto ile degil while ile loopa almak istedim burayı. goto yu digerlerinde kullanmıştım.
            while (true)
            {
                Console.WriteLine("Kullanıcı adı giriniz.");

                string ad = Console.ReadLine();

                Console.WriteLine("Şifre giriniz");

                string sifre = Console.ReadLine();

                if (ad == username && sifre == password)
                {
                    Console.WriteLine("giriş başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("lütfen bilgileriniz kontrol ediniz");
                }
            }
        }
    }
}
