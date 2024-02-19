using Entities;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public partial class CineFlixContext : DbContext
{
    public CineFlixContext()
    {
    }

    public CineFlixContext(DbContextOptions<CineFlixContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ASACBDH;Database=CineFlix;TrustServerCertificate=True;User Id=sa;Password=Qwerty1");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.Property(e => e.CommentId).HasColumnName("commentId");
            entity.Property(e => e.CommentDate)
                .HasColumnType("datetime")
                .HasColumnName("commentDate");
            entity.Property(e => e.CommentText).HasColumnName("commentText");
            entity.Property(e => e.MovieId).HasColumnName("movieId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            //entity.HasOne(d => d.Movie).WithMany(p => p.Comments)
            //    .HasForeignKey(d => d.MovieId)
            //    .HasConstraintName("FK_Comments_Movies");

            //entity.HasOne(d => d.User).WithMany(p => p.Comments)
            //    .HasForeignKey(d => d.UserId)
            //    .HasConstraintName("FK_Comments_Users");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.Property(e => e.GenreId).HasColumnName("genreId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.MovieId).HasColumnName("movieId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GenreId).HasColumnName("genreId");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("date")
                .HasColumnName("releaseDate");
            entity.Property(e => e.Title).HasColumnName("title");

            //entity.HasOne(d => d.Genre).WithMany(p => p.Movies)
            //    .HasForeignKey(d => d.GenreId)
            //    .HasConstraintName("FK_Movies_Genres");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.Property(e => e.RatingId).HasColumnName("ratingId");
            entity.Property(e => e.MovieId).HasColumnName("movieId");
            entity.Property(e => e.RatingValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ratingValue");
            entity.Property(e => e.UserId).HasColumnName("userId");

            //entity.HasOne(d => d.Movie).WithMany(p => p.Ratings)
            //    .HasForeignKey(d => d.MovieId)
            //    .HasConstraintName("FK_Ratings_Movies");

            //entity.HasOne(d => d.User).WithMany(p => p.Ratings)
            //    .HasForeignKey(d => d.UserId)
            //    .HasConstraintName("FK_Ratings_Users");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.Property(e => e.SeriesId).HasColumnName("seriesId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GenreId).HasColumnName("genreId");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("date")
                .HasColumnName("releaseDate");
            entity.Property(e => e.Title).HasColumnName("title");

            //entity.HasOne(d => d.Genre).WithMany(p => p.Series)
            //    .HasForeignKey(d => d.GenreId)
            //    .HasConstraintName("FK_Series_Genres");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
