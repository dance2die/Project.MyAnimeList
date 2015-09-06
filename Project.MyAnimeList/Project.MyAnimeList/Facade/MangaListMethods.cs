using MyAnimeListSharp.Auth;
using MyAnimeListSharp.Parameters;

namespace MyAnimeListSharp.Facade
{
	public class MangaListMethods : MyAnimeListMethods
	{
		public MangaListMethods(ICredentialContext credentialContext) 
			: base(credentialContext)
		{
		}

		public string AddManga(int id, string data)
		{
			return GetResponseText(new AddMangaRequestParameters(CredentialContext, id, data));
		}

		public string UpdateManga(int id, string data)
		{
			return GetResponseText(new UpdateMangaRequestParameters(CredentialContext, id, data));
		}

		public string DeleteManga(int id)
		{
			return GetResponseText(new DeleteMangaRequestParameters(CredentialContext, id));
		}
	}
}