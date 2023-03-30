using Microsoft.EntityFrameworkCore;
using MobileApplicationBackend.Models;

namespace MobileApplicationBackend.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
        
    }
    public DbSet<News>? News { get; set; }
    
    public DbSet<Workout>? Workout { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Tournament>? Tournament { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Event>? Event { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Seminar>? Seminar { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Student>? Student { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Coach>? Coach { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Seminar_student_link>? Seminar_student_link { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Tournament_student_link>? Tournament_student_link { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Manager>? Manager { get; set; }
    
    public DbSet<MobileApplicationBackend.Models.Workout_student_link>? Workout_student_link { get; set; }
}