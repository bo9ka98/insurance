

namespace Model.entity
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
