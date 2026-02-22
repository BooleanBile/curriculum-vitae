namespace OarabileMarwane_CV.Models.CV
{
    public class Certification
    {
        //prop  
        public int Id { get; set; }
        public string NameOfCert { get; set; }
        public string Organisation { get; set; }
        public DateOnly IssueDate { get; set; }

        public DateOnly ExpiryDate { get; set; }
        public string CredentialId { get; set; }

    }
}
