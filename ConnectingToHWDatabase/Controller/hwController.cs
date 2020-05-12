using ConnectingToHWDatabase.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ConnectingToHWDatabase.Controller
{
    public class HWController
    {
        //private readonly Form centralForm;
        private readonly HWContext db;
        private CSharpHWForm cSharpHWForm;

        public HWController(CSharpHWForm cSharpHWForm)
        {
            this.cSharpHWForm = cSharpHWForm;
            db = new HWContext();
        }
        

          internal void ShowCSharpHWForm()
     {
         
        cSharpHWForm = new CSharpHWForm();
          cSharpHWForm.Show();

     }

     
        public HWContext GetDbContext()
        {
            return db;
        }
    }
}
