namespace akiira_asp
{
    public class RouteConfig
    {
        public static void Include(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "MovieByReleaseDate",
                    "Movie/released/{year}/{month}",
                    new { controller = "Movies", action = "ByReleaseDate" });

            });
        }
    }
}
