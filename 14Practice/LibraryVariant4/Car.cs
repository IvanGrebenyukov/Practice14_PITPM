using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Practice14_Grebenukov
{
    public class Car : SubjectOfInsurance
    {
        private string brand;
        private int year_of_issue;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int YearOfIssue
        {
            get { return year_of_issue; }
            set { year_of_issue = value; }
        }
        public Car(string brand, int year_of_issue, string surname, string name_of_the_subject_of_insurance, double insurance_cost, int term_of_insurance) : base(surname, name_of_the_subject_of_insurance, insurance_cost, term_of_insurance)
        {
            this.brand = brand;
            this.year_of_issue = year_of_issue;
        }
        public override string Info()
        {
            return $@"{Brand} 
{YearOfIssue} 
{Surname} 
{NameOfTheSubjectOfInsurance} 
{InsuranceCost} 
{TermOfInsurance}";
        }
    }
}
