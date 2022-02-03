namespace Proverochnaya
{
    class Employee
    {   
        public string FIO { get; init; }
        public string tel { get; set; }
        public Shovel shovel { get; set; } = new Shovel();
        public SystemE systeme { get; set; }
        public void DestroyShovel()
        {
            if (systeme.DestroyCount.ContainsKey(this))
            {
                systeme.DestroyCount[this] += 1;
            }
            else
            {
                systeme.DestroyCount.Add(this, 1);
            }
        }
    }
}
