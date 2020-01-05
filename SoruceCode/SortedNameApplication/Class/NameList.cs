namespace SortedNameApplication.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class NameList
    {
        public NameList(string firstname, string lastname)
        {
            this.firstName = firstname; this.lastName = lastname;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
