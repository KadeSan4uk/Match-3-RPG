namespace Project.Scripts.Repositories
{
	public class PlayerProgressRepository
	{
		private static PlayerProgressRepository _instance;

		public int CurrentLevel { get; private set; }

		public static PlayerProgressRepository Instance
		{
			get
			{
				_instance ??= new PlayerProgressRepository();

				return _instance;
			}
		}


		private PlayerProgressRepository()
		{
			CurrentLevel = 0;
		}
	}
}