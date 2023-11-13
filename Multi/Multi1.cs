namespace Multi
{
	public class Multi1
	{
#if !NETCOREAPP
		public void Test()
		{
		}

				public string GetName()
		{
			return Name;
		}

		public string Name { get; set; }
#else

		public void Method1(string name)
		{

		}
#endif
	}
}