using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace GIAF.DTOs.PageManager
{
    public class ConnectionViewModel
    {
        public ConnectionViewModel()
        {
            DbTableList = new List<SelectListItem>();
        }

        [Required]
        public string ServerName { get; set; }

        [Required]
        public string DbName { get; set; }

        [Required]
        public string Port { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsTestConnection { get; set; }

        public bool IsConnectionCorrect { get; set; }

        public string SelectedDbTable { get; set; }

        public List<SelectListItem> DbTableList { get; set; }

        public string CommandText { get; set; }
    }
}
