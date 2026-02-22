using Microsoft.EntityFrameworkCore;
using OarabileMarwane_CV.Models.CV;
using System;

namespace OarabileMarwane_CV.Data
{
    public class AppDbContext : DbContext
    {
        //ctor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Certification> Certifications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo
                {
                    Id = 1,
                    FirstName = "Oarabile",
                    LastName = "Marwane",
                    Title = "3rd Student in Bachelor of Computer and Information Science In Application Development Student | Emeris Ruimsig",
                    AboutMe = "I am currently in my final year of studying a Bachelor of Computer and Information Sciences in Application Development at Emeris Ruimsig – Johannesburg Campus. \r\nI am excited about the challenges and knowledge that will be presented to me this year as I pursue a career as a software developer and, later on, a project manager.\r\n\r\nI also have a passionate backup interest in Technical Support, in terms of building and maintaining devices used in our day-to-day. If becoming a software engineer doesn’t work out, I would love being Technical Support to improve user experiences,",
                    Location = "Johannesburg, South Africa",
                    Linkedin = "https://www.linkedin.com/in/oarabile-marwane-544478261/",
                    Email = "oarabile.marwane1@email.com",
                    PhoneNumber = "0000000000",
                    avatar = "profile.jpg"
                }
            );

            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    JobTitle = "Junior Software Developer",
                    Company = "Freelance / Personal Projects",
                    EmploymentType = "Contract",
                    JobDescription = "Developed web applications using ASP.NET Core MVC, implemented EF Core with SQLite and SQL Server, and deployed applications to Microsoft Azure.",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2025, 1, 1)
                }
                
            );

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = 1,
                    Degree = "Diploma in Information Technology",
                    InstitutionName = "IIE Rosebank College",
                    Descrip = "Focused on software development, databases, system analysis and design.",
                    StartDate = new DateOnly(2022, 1, 1),
                    EndDate = new DateOnly(2024, 12, 1)
                }
            );


            modelBuilder.Entity<Certification>().HasData(
                new Certification
                {
                    Id = 1,
                    NameOfCert = "Microsoft Azure Fundamentals (AZ-900)",
                    Organisation = "Microsoft",
                    IssueDate = new DateOnly(2025, 6, 1),
                    ExpiryDate = new DateOnly(2028, 6, 1),
                    CredentialId = "AZ900-123456"
                },
                new Certification
                {
                    Id = 2,
                    NameOfCert = "Introduction to Cybersecurity",
                    Organisation = "Cisco Networking Academy",
                    IssueDate = new DateOnly(2024, 5, 1),
                    ExpiryDate = new DateOnly(2027, 5, 1),
                    CredentialId = "CISCO-987654"
                }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Skill = "C#" },
                new Skill { Id = 2, Skill = "ASP.NET Core MVC" },
                new Skill { Id = 3, Skill = "SQL Server" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Name = "Cybersecurity Awareness Bot",
                    Description = "Console chatbot built in C# with NLP and task manager.",
                    GitHubLink = "https://github.com/yourrepo"
                }
            );

            



        }
    }

}
