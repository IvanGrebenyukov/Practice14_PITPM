using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14_Grebenukov
{
    public class RealEstate : SubjectOfInsurance
    {
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public RealEstate(string address, string surname, string name_of_the_subject_of_insurance, double insurance_cost, int term_of_insurance) : base(surname, name_of_the_subject_of_insurance, insurance_cost, term_of_insurance)
        {
            this.address = address;
        }
        public override string Info()
        {
            return $@"{Address} 
{this.Surname} 
{this.NameOfTheSubjectOfInsurance} 
{this.InsuranceCost} 
{this.TermOfInsurance}";
        }
    }
}
