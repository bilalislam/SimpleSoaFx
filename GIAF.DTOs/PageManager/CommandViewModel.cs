using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{  
    public class CommandViewModel
    {
        public CommandViewModel()
        {
            DbTableList = new List<SelectListItem>();

            Columns = new List<string>();

            DataRows = new List<object>();
        }

        public string CommandText { get; set; }

        public List<object> DataRows { get; set; }

        public List<string> Columns { get; set; }

        public string SelectedDbTable { get; set; }

        public List<SelectListItem> DbTableList { get; set; }
    }
}
