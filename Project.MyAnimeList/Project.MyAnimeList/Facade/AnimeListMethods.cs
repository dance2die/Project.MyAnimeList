using Project.MyAnimeList.Auth;
using Project.MyAnimeList.Web;

namespace Project.MyAnimeList.Facade
{
	public class AnimeListMethods : MyAnimeListMethods
	{
		public AnimeListMethods(ICredentialContext credentialContext) 
			: base(credentialContext)
		{
		}

		public string AddAnime(int? id, string data)
		{
			return GetResponseText(new AddAnimeRequestParameters(CredentialContext, id, data));
		}

		public string UpdateAnime(int? id, string data)
		{
			return GetResponseText(new UpdateAnimeRequestParameters(CredentialContext, id, data));
		}

		public string DeleteAnime(int id)
		{
			return GetResponseText(new DeleteAnimeRequestParameters(CredentialContext, id));
		}
	}

	public class DeleteAnimeRequestParameters : CrudRequestParameters
	{
		public override string BaseUri { get; set; } = "http://myanimelist.net/api/animelist/delete";

		public DeleteAnimeRequestParameters(ICredentialContext credential, int? id, string data = "") 
			: base(credential, id, data)
		{
		}
	}

	public class UpdateAnimeRequestParameters : CrudRequestParameters
	{
		public override string BaseUri { get; set; } = "http://myanimelist.net/api/animelist/update";

		public UpdateAnimeRequestParameters(ICredentialContext credentialContext, int? id, string data)
			: base(credentialContext, id, data)
		{
		}
	}
}