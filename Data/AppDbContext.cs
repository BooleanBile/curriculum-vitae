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
                    Location = "Gauteng",
                    Linkedin = "https://www.linkedin.com/in/oarabile-marwane-544478261/",
                    Email = "oarabile.marwane1@gmail.com",
                    PhoneNumber = "+27 66 2242737",
                    avatar = "profile.jpg"
                }
            );

            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    JobTitle = "IT Learnership",
                    Company = "Curro Holdings Ltd",
                    EmploymentType = "Full Time",
                    JobDescription = "Providing a variety of support services to users of IT, with limited supervision and direction of others.\r\nContributing to solving user technical problems and meeting their support needs.",
                    StartDate = new DateTime(2022, 12, 1),
                    EndDate = new DateTime(2024, 2, 1)
                }
                
            );

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = 1,
                    Degree = "Bachelor of Computer and Information Sciences in Application Development ",
                    InstitutionName = "Emeris Ruimsig",
                    Descrip = "This qualification has been designed to develop my ability to design, implement, and manage solutions for systemic thinkers, enabling me to develop software solutions for any device or platform in the South African economy.",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2026, 12, 1)
                },
                new Education
                {
                    Id = 2,
                    Degree = "Further Education and Training Certificate: Information Technology: Technical Support ",
                    InstitutionName = "CURRO HOLDINGS LTD ",
                    Descrip = " purpose of this qualification is to build a foundational entry into the field of Computer Sciences and Information Technology, specifically into the field of Systems Support, covering basic knowledge needed for further study in the field of Systems Support at Higher Education Levels.",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2023, 1, 1)
                }
            );


            modelBuilder.Entity<Certification>().HasData(
                new Certification
                {
                    Id = 1,
                    NameOfCert = "CompTIA A+",
                    Organisation = "CompTIA",
                    IssueDate = new DateTime(2023, 6, 1),
                    ExpiryDate = new DateTime(2026, 6, 1),
                    CredentialId = "WMKQNK95FJB11JGM"
                },
                new Certification
                {
                    Id = 2,
                    NameOfCert = "CompTIA Network+",
                    Organisation = "CompTIA",
                    IssueDate = new DateTime(2023, 11, 1),
                    ExpiryDate = new DateTime(2026, 11, 1),
                    CredentialId = "BSXTSTDRDJ4E159B"
                }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, SkillDescp = "Communicate effectively with fellow IT staff & users of information systems" },
                new Skill { Id = 2, SkillDescp = "Demonstrate an understanding of different types of computer systems and the use of computer technology in business." },
                new Skill { Id = 3, SkillDescp = "Hardware and Infrastructure Support for Personal Computers" },
                new Skill { Id = 4, SkillDescp = "Data Communications and Network Support" },
                new Skill { Id = 5, SkillDescp = "Design software applications on a variety of platforms" },
                new Skill { Id = 6, SkillDescp = "Communicate effectively and professionally as a member of a software design and development team." }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Name = "Cybersecurity Awareness Bot",
                    Description = "A chatbot built in C# with NLP and task manager.",
                    GitHubLink = "https://github.com/MarwaneOarabile/CyberBot_ST10436124.git"
                }
            );

            



        }
    }

}
