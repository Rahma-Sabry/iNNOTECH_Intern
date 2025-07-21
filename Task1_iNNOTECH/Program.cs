namespace Task1_iNNOTECH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles(); // Serves index.html by default
            app.UseStaticFiles();

            app.Run();
        }
    }
}
