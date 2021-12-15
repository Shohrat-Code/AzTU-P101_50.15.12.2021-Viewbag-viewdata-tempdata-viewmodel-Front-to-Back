using AspIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIntro.ViewModels
{
    public class VmStuGroup
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}
