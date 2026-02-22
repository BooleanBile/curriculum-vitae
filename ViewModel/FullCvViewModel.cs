using OarabileMarwane_CV.Models.CV;

namespace OarabileMarwane_CV.ViewModel
{
    public class FullCvViewModel
    {
        public ContactInfo ContactInfo { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Education> Educations { get; set; }
        public List<Certification> Certifications { get; set; }
    }
}
