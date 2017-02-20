using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(getAbilityForm());
        }

        /// <summary>
        /// To get a data without tracking form class, injecting data into necessary classes at the first stage.
        /// </summary>
        static AbilityForm getAbilityForm()
        {
            // Inject Dependancy at first stage (Decide dependancy at first time)
            AbilityForm abilityForm = new AbilityForm();
            RaceForm raceForm = new RaceForm();
            JobForm jobForm = new JobForm();
            FinalForm finalForm = new FinalForm();

            // Inject next form into abilityForm
            abilityForm.raceForm = raceForm;

            // Inject previous & next forms into raceForm
            raceForm.abilityForm = abilityForm; // previous
            raceForm.jobForm = jobForm; // next

            // Inject previous & next forms into jobForm
            jobForm.raceForm = raceForm; // previous
            jobForm.finalForm = finalForm; // next

            // Inject necessary objects into finalForm 

            return abilityForm;
        }
    }
}
