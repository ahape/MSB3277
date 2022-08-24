namespace LibraryB
{
    public class Class1
    {
        private readonly string version;
        public string DependsOn => "Library A depends on SharedDependency version " + version;
        public Class1()
        {
            var inst = new SharedDependency.SharedThing();
            version = inst.Version;
        }
    }
}
