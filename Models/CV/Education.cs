namespace OarabileMarwane_CV.Models.CV
{
    public class Education
    {
        //prop
        public int Id { get; set; }
        public string Degree { get; set; }
        public string InstitutionName { get; set; }

        public string Descrip { get; set; }


        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }


    }
}
