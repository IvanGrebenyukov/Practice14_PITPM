using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice14_Grebenukov
{
    public abstract class SubjectOfInsurance
    {
        private string surname;
        private string name_of_the_subject_of_insurance;
        private double insurance_cost;
        private int term_of_insurance;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string NameOfTheSubjectOfInsurance
        {
            get { return name_of_the_subject_of_insurance; }
            set { name_of_the_subject_of_insurance = value; }
        }
        public double InsuranceCost
        {
            get { return insurance_cost; }
            set { insurance_cost = value; }
        }
        public int TermOfInsurance
        {
            get { return term_of_insurance; }
            set { term_of_insurance = value; }
        }

        public SubjectOfInsurance(string surname, string name_of_the_subject_of_insurance, double insurance_cost, int term_of_insurance)
        {
            this.surname = surname;
            this.name_of_the_subject_of_insurance = name_of_the_subject_of_insurance;
            this.insurance_cost = insurance_cost;
            this.term_of_insurance = term_of_insurance;
        }
        public abstract string Info();
    }
}
