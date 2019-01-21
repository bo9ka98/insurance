using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public AliasMan AliasMan { get; set; }
        public ControlUser UserControl { get; set; }
        
        public User (AliasMan youAliasMan, ControlUser youUserControl)
        {
            AliasMan = youAliasMan;
            UserControl = youUserControl;
        }
    }
}
