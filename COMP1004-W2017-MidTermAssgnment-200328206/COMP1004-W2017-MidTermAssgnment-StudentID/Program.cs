/**
 * The App name: Generation of RPG Character
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: February 20, 2017
 * App Last Modification Date: February 20, 2017
 * App Short Revision History
 *  - 02:00 AM, Feb 20, 2017: Apply for Form Design except Menu, Follow name convention.
 *  - 12:00 PM, Feb 20, 2017: Finish RaceForm and Use Dependancy Injection for every form.
 *  - 01:00 PM, Feb 20, 2017: Change Component names properly
 *  - 04:00 PM, Feb 20, 2017: Finish Final Form Except Font Changes
 *  - 06:00 PM, Feb 20, 2017: Finish All UI and Functions (Work for Font Style)
 *  - 06:30 PM, Feb 20, 2017: Add all necessary comments. (Finish Midterm Assignment)
 * App description: After Users choose abilities, Race, Job, generatere pages of RPG characters
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200328206
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

            // Inject ability & next forms into jobForm
            //jobForm.raceForm = raceForm; // previous
            jobForm.abilityForm = abilityForm;
            jobForm.finalForm = finalForm; // next

            // Inject necessary objects into finalForm 
            finalForm.abilityForm = abilityForm;
            finalForm.raceForm = raceForm;
            finalForm.jobForm = jobForm;

            return abilityForm;
        }
    }
}
