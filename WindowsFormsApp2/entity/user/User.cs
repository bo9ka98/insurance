using System;
using Model.entity;

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
