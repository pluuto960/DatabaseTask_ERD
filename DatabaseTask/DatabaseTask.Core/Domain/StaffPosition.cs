using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class StaffPosition
    {
        [ForeignKey(nameof(Workers))]
        public int StaffID {  get; set; }

        [Key]
        public int ProjectLeaderID {  get; set; }
        public int ProjectStaffID { get; set; }
    }
}
