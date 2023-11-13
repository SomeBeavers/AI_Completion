namespace Multi
{
	public class Multi1
	{
#if !NETCOREAPP
		public void Test()
		{
		}
#endif
		public string GetName()
		{
			return Name;
		}

		public string Name { get; set; }
	}
}