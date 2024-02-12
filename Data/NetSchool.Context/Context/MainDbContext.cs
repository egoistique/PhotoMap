namespace NetSchool.Context;

using NetSchool.Context.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class MainDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<AuthorDetail> AuthorDetails { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }


    public DbSet<PointCategory> PointCategories { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<ImagePath> ImagePathes { get; set; }
    public DbSet<Point> Points { get; set; }

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAuthors();
        modelBuilder.ConfigureAuthorDetails();
        modelBuilder.ConfigureBooks();
        modelBuilder.ConfigureCategories();

        modelBuilder.ConfigurePointCategories();
        modelBuilder.ConfigurePoints();
        modelBuilder.ConfigureFeedbacks();
        modelBuilder.ConfigureImagePathes();


        modelBuilder.ConfigureUsers();
    }
}
